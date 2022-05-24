using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace TP4
{
    public partial class FormCursos : Form
    {
        private Instituto miInstituto;
        delForm delCursosEnvioMail;
        public FormCursos(Instituto auxInstituto, delForm manejadorEventoMails)
        {
            InitializeComponent();            
            this.miInstituto = auxInstituto;
            this.delCursosEnvioMail = manejadorEventoMails;
        }
        private void FormCursos_Load(object sender, EventArgs e)
        {
            try
            {
                if(miInstituto.Cursos.Count > 0)
                {
                    this.dgvListadoCursos.RefrescarDGV(miInstituto.Cursos);
                }          
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    Curso c = new Curso(miInstituto.IdCursos, txtDescripcion.Text.Trim(), dtpFechaInicio.Value, dtpFechaFin.Value, chkElearning.Checked);
                    if(this.miInstituto + c)
                    {                        
                        AccesoDatos aD = new AccesoDatos();
                        if(!aD.AgregarCurso(c))
                        {
                            if(this.miInstituto - c)
                            {
                                lbResultado.Text = "Se cancelo agregar el siguiente curso: ";
                                lbResultado.Text += c.MostrarDatos();
                            }
                            throw new InstitutoExcepciones("Error al intentar actualizar la base de datos con el curso nuevo");
                        }
                        else
                        {
                            lbResultado.Text = "Se agrego el siguiente curso: ";
                            lbResultado.Text += c.MostrarDatos();
                            this.dgvListadoCursos.RefrescarDGV(miInstituto.Cursos);
                            if(delCursosEnvioMail is not null)
                            {
                                delCursosEnvioMail.Invoke($"Enviar comunicado a los alumnos sobre el nuevo curso: \n{c.MostrarDatos()}");
                            }                            
                        }
                    }
                    else
                    {
                        lbResultado.Text = "No se pudo agregar el siguiente curso";

                        lbResultado.Text += c.MostrarDatos();
                        if(c.FechaInicio.CompareTo(c.FechaFin) > 0)
                        {
                            MessageBox.Show("Fechas invalidas",
                                "La fecha de inicio no puede ser posterior a la fecha de fin",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }                
                }
                else
                {
                    lbResultado.Text = "Ingrese nombre del curso";
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvListadoCursos.CurrentCell is not null)
                {
                    int rowIndex = dgvListadoCursos.CurrentCell.RowIndex;
                    int i = 0;
                    if (rowIndex >= 0 && rowIndex < miInstituto.Cursos.Count)
                    {
                        foreach (Curso item in miInstituto.Cursos)
                        {
                            if (i == rowIndex && miInstituto - item)
                            {

                                AccesoDatos aD = new AccesoDatos();
                                if(!aD.EliminarCurso(item.Id))
                                {
                                    lbResultado.Text = "Se ha cancelado la eliminacion del siguiente curso:\n";
                                    lbResultado.Text += item.MostrarDatos();
                                    throw new InstitutoExcepciones("Error al intentar actualizar la base de datos");
                                }
                                else
                                {
                                    lbResultado.Text = "Se ha eliminado el siguiente curso:\n";
                                    lbResultado.Text += item.MostrarDatos();
                                    this.dgvListadoCursos.RefrescarDGV(miInstituto.Cursos);
                                    if(item.Inscriptos.Count>0)
                                    {
                                        aD = null;
                                        aD = new AccesoDatos();
                                        foreach (Alumno alumnoInscripto in item.Inscriptos)
                                        {
                                            if(!aD.EliminarInscripto(item.Id,alumnoInscripto.Id))
                                            {
                                                throw new InstitutoExcepciones("Error al intentar actualizar los inscriptos en la base de datos");
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            i++;
                        }
                    }
                }          
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
    }
}
