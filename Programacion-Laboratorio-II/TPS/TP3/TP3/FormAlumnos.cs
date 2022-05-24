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
    public partial class FormAlumnos : Form
    {
        private Instituto miInstituto;
        public FormAlumnos(Instituto AuxInstituto)
        {
            InitializeComponent();
            miInstituto = AuxInstituto;
        }
        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            if (miInstituto.Alumnos.Count > 0)
            {
                RefrescarAlumnos();
            }
        }
        private void RefrescarAlumnos()
        {
            try
            {
                cmbSeleccionarAlumno.DataSource = null;
                if(miInstituto.Alumnos.Count > 0)
                {
                    cmbSeleccionarAlumno.DataSource = miInstituto.Alumnos;
                    if(miInstituto.Cursos.Count > 0)
                    {
                        btnInscripcion.Visible = true;
                    }
                }            

            }
            catch (Exception ex)
            {
                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }
        private void CambiarVisibilidadBotonesModificarAlumno()
        {
            try
            {
                cmbSeleccionarAlumno.Enabled = !cmbSeleccionarAlumno.Enabled;
                btnGuardarCambios.Visible = !btnGuardarCambios.Visible;
                btnCancelarCambios.Visible = !btnCancelarCambios.Visible;        
                if(miInstituto.Alumnos.Count == 0 || miInstituto.Cursos.Count == 0)
                {
                    btnInscripcion.Enabled = false;
                }
                else
                {
                    btnInscripcion.Enabled = !btnInscripcion.Enabled;
                }            

            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }
        private void LimpiarDatos()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDni.Text) && txtDni.Text.Length == 8)
                {
                    int auxDni;
                    if(int.TryParse(txtDni.Text.Trim(), out auxDni))
                    {
                        Alumno alumno = new Alumno(miInstituto.IdAlumnos, txtApellido.Text.Trim(), txtNombre.Text.Trim(), auxDni);
                        if (miInstituto + alumno)
                        {
                            rchbResultado.Text = "Se agrego el siguiente alumno:\n";
                            RefrescarAlumnos();
                            LimpiarDatos();
                        }
                        else
                        {
                            rchbResultado.Text = "No se pudo agregar al siguiente alumno\n";
                        }
                        rchbResultado.Text += alumno.MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Dni invalido", "El dni debe ser solo 8 numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                
                }
                else
                {
                    rchbResultado.Text = "Datos inválidos";
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
                if (miInstituto.Alumnos.Count > 0 && cmbSeleccionarAlumno.SelectedItem is not null)
                {
                    if (miInstituto - ((Alumno)cmbSeleccionarAlumno.SelectedItem))
                    {
                        List<Curso> auxCursosTomados = new List<Curso>();
                        auxCursosTomados = miInstituto.Cursos;
                        if (miInstituto.DesinscribirAlumnoBaja(((Alumno)cmbSeleccionarAlumno.SelectedItem)))
                        {
                            rchbResultado.Text = "Se ha eliminado al siguiente alumno y dado de baja de todos los cursos donde estaba inscripto:\n";
                            rchbResultado.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).MostrarDatos();
                            RefrescarAlumnos();
                        }
                        else
                        {
                            MessageBox.Show("Error al intentar desinscribir al alumno de los cursos tomados", "Se ha cancelado la baja del alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (miInstituto + ((Alumno)cmbSeleccionarAlumno.SelectedItem))
                            {
                                rchbResultado.Text = "Se ha cancelado la baja del siguiente alumno:\n";
                                rchbResultado.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).MostrarDatos();
                                miInstituto.Cursos = auxCursosTomados;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }

        }      
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (miInstituto.Alumnos.Count > 0 && cmbSeleccionarAlumno.SelectedItem is not null)
                {
                    CambiarVisibilidadBotonesModificarAlumno();
                    txtApellido.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).Apellido;
                    txtNombre.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).Nombre;
                    txtDni.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).Dni.ToString();
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }

        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtApellido.Text) &&
                    !string.IsNullOrWhiteSpace(txtNombre.Text) && 
                    !string.IsNullOrWhiteSpace(txtDni.Text) &&
                    txtDni.Text.Length == 8)
                {
                    int auxDni;
                    if (int.TryParse(txtDni.Text.Trim(), out auxDni))
                    {
                        ((Alumno)cmbSeleccionarAlumno.SelectedItem).Dni = auxDni;
                        ((Alumno)cmbSeleccionarAlumno.SelectedItem).Apellido = txtApellido.Text;
                        ((Alumno)cmbSeleccionarAlumno.SelectedItem).Nombre = txtNombre.Text;
                        miInstituto.Alumnos = Instituto.modificar<Alumno>(((Alumno)cmbSeleccionarAlumno.SelectedItem).Id,
                            ((Alumno)cmbSeleccionarAlumno.SelectedItem),
                            miInstituto.Alumnos);
                        LimpiarDatos();
                    }
                    else
                    {
                       MessageBox.Show("Dni invalido", "El dni debe ser solo 8 numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefrescarAlumnos();
                CambiarVisibilidadBotonesModificarAlumno();
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }
        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarVisibilidadBotonesModificarAlumno();
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
            
        }
        private void btnInscripcion_Click(object sender, EventArgs e)
        {            
            FormInscripcionesAlumnos formInscripciones = new FormInscripcionesAlumnos(miInstituto);
            formInscripciones.ShowDialog();
        }
    }
}
