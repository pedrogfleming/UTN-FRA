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
    public partial class FormInscripcionesAlumnos : Form
    {
        private Instituto miInstituto;
        public FormInscripcionesAlumnos(Instituto AuxInstituto)
        {
            InitializeComponent();
            this.miInstituto = AuxInstituto;
        }
        #region Metodos
        private void RefrescarAlumnos()
        {
            //ExtencionFormularios.RefrescarDGV(dgvListadoAlumnos, miInstituto.Alumnos);
            this.dgvListadoAlumnos.RefrescarDGV(miInstituto.Alumnos);
        }
        private void RefrescarCursos()
        {
            //ExtencionFormularios.RefrescarDGV(dgvListadoCursos, miInstituto.Cursos);
            this.dgvListadoCursos.RefrescarDGV(miInstituto.Cursos);
        }
        private Curso obtenerCursoSeleccionado()
        {
            if (dgvListadoCursos.CurrentCell is not null)
            {
                int rowIndex = dgvListadoCursos.CurrentCell.RowIndex;
                int i = 0;
                if (rowIndex >= 0 && rowIndex < miInstituto.Cursos.Count)
                {
                    foreach (Curso item in miInstituto.Cursos)
                    {
                        if (i == rowIndex)
                        {
                            return ((Curso)dgvListadoCursos.CurrentRow.DataBoundItem);
                        }
                        i++;
                    }
                }
            }
            return null;
        }
        private Alumno obtenerAlumnoSeleccionado()
        {
            if (dgvListadoAlumnos.CurrentCell is not null)
            {
                int rowIndex = dgvListadoAlumnos.CurrentCell.RowIndex;
                int i = 0;
                if (rowIndex >= 0 && rowIndex < miInstituto.Alumnos.Count)
                {
                    foreach (Alumno item in miInstituto.Alumnos)
                    {
                        if (i == rowIndex)
                        {
                            return ((Alumno)dgvListadoAlumnos.CurrentRow.DataBoundItem);
                        }
                        i++;
                    }
                }
            }
            return null;
        }
        #endregion

        private void InscripcionesAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                if (miInstituto.Alumnos.Count > 0)
                {
                    this.RefrescarAlumnos();
                }
                if (miInstituto.Cursos.Count > 0)
                {
                    this.RefrescarCursos();
                }
            }
            catch (Exception ex)
            {

                //ExtencionFormularios.MostrarMensajeError(ex);
                ex.MostrarMensajeError();
            }
        }
        private void btnInscribirAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Curso auxCurso = obtenerCursoSeleccionado();
                Alumno auxAlumno = obtenerAlumnoSeleccionado();
                if (auxAlumno is not null && auxCurso is not null)
                {
                    if (auxCurso != auxAlumno && auxCurso.inscribirAlumno(auxAlumno))
                    {
                        txtResultado.Text = string.Format("Se inscribio al alumno: \n{0} {1} \nDni: {2}\nAl curso:\n",
                        auxAlumno.Apellido, auxAlumno.Nombre, auxAlumno.Dni);
                        AccesoDatos aD = new AccesoDatos();
                        if(!aD.AgregarInscripto(auxCurso.Id,auxAlumno.Id))
                        {
                            throw new InstitutoExcepciones("Error al actualizar la base de datos con la inscripcion del alumno");
                        }
                    }
                    else
                    {
                        txtResultado.Text = string.Format("Ya esta inscripto el alumno: \n{0} {1} \nDni: {2}\nAl curso:\n",
                        auxAlumno.Apellido, auxAlumno.Nombre, auxAlumno.Dni);
                    }
                    txtResultado.Text += auxCurso.MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                //ExtencionFormularios.MostrarMensajeError(ex);
                ex.MostrarMensajeError();
            }
        }
        private void btnBajaAlumnoCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Curso auxCurso = obtenerCursoSeleccionado();
                Alumno auxAlumno = obtenerAlumnoSeleccionado();
                if (auxCurso == auxAlumno && auxCurso - auxAlumno)
                {
                    AccesoDatos aD = new AccesoDatos();          
                    if(!aD.EliminarInscripto(auxCurso.Id,auxAlumno.Id))
                    {
                        throw new InstitutoExcepciones("Error al actualizar la base de datos con la desincripcion del alumno");
                    }
                    else
                    {
                        txtResultado.Text = string.Format("Se dio de baja al  al alumno: \n{0} {1} \nDni: {2} al curso: \n",
                        auxAlumno.Apellido, auxAlumno.Nombre, auxAlumno.Dni);
                    }
                }
                else
                {
                    txtResultado.Text = string.Format("No esta inscripto el alumno: \n{0} {1} \nDni: {2} al curso: \n",
                    auxAlumno.Apellido, auxAlumno.Nombre, auxAlumno.Dni);
                }
                txtResultado.Text += auxCurso.MostrarDatos();
            }
            catch (Exception ex)
            {
                //ExtencionFormularios.MostrarMensajeError(ex);
                ex.MostrarMensajeError();
            }
        }
    }
}
