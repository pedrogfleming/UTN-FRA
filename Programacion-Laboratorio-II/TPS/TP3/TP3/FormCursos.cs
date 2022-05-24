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
namespace TP3
{
    public partial class FormCursos : Form
    {
        private Instituto miInstituto;
        public FormCursos(Instituto auxInstituto)
        {
            InitializeComponent();            
            this.miInstituto = auxInstituto;
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            try
            {
                if(miInstituto.Cursos.Count > 0)
                {
                    ExtencionFormularios.RefrescarDGV(dgvListadoCursos, miInstituto.Cursos);
                }          
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
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
                        lbResultado.Text = "Se agrego el siguiente curso: ";
                        lbResultado.Text += c.MostrarDatos();
                        ExtencionFormularios.RefrescarDGV(dgvListadoCursos, miInstituto.Cursos);
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

                ExtencionFormularios.MostrarMensajeError(ex);
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
                                lbResultado.Text = "Se ha eliminado el siguiente curso:\n";
                                lbResultado.Text += item.MostrarDatos();
                                ExtencionFormularios.RefrescarDGV(dgvListadoCursos, miInstituto.Cursos);
                                break;
                            }
                            i++;
                        }
                    }
                }          
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }
    }
}
