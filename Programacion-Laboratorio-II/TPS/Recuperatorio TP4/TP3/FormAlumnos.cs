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
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Alumno.EGenero));
            if (miInstituto.Alumnos.Count > 0)
            {
                RefrescarAlumnos();
            }
        }
        /// <summary>
        /// Refresca el combobox con los alumnos del instituto y habilita o no el boton de inscripcion a cursos
        /// </summary>
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
                ex.MostrarMensajeError();
            }
        }
        private void CambiarVisibilidadBotonesModificarAlumno()
        {
            try
            {
                cmbSeleccionarAlumno.Enabled = !cmbSeleccionarAlumno.Enabled;
                btnGuardarCambios.Visible = !btnGuardarCambios.Visible;
                btnCancelarCambios.Visible = !btnCancelarCambios.Visible;
                txtDni.Enabled = true;
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
                ex.MostrarMensajeError();
            }
        }
        /// <summary>
        /// Deja enb blanco los textbox y deja por default los valores
        /// </summary>
        private void LimpiarDatos()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
            nudEdad.Value = 18;
            cmbGenero.SelectedItem = Alumno.EGenero.otro;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbGenero.CanSelect && nudEdad.CanSelect && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDni.Text) && txtDni.Text.Length == 8)
                {
                    int auxDni;
                    if(int.TryParse(txtDni.Text.Trim(), out auxDni))
                    {
                        Alumno alumno = new Alumno(miInstituto.IdAlumnos, txtApellido.Text.Trim(),
                            txtNombre.Text.Trim(),
                            auxDni,
                            (short)nudEdad.Value,
                            (Alumno.EGenero)cmbGenero.SelectedItem);
                        if (miInstituto + alumno)
                        {
                            AccesoDatos aD = new AccesoDatos();
                            if (aD.AgregarAlumno(alumno))
                            {
                                rchbResultado.Text = "Se agrego el siguiente alumno:\n";
                                RefrescarAlumnos();
                                LimpiarDatos();
                            }
                            else if (miInstituto - alumno)
                            {
                                //En caso que hubo problemas para actualizar la base de datos, se restaura al estado anterior para evitar diferencias de datos
                                rchbResultado.Text = "No se pudo agregar al siguiente alumno\n";
                                rchbResultado.Text += alumno.MostrarDatos();
                                string mensajeEx = $"No se pudo agregar en la base de datos al siguiente alumno {((Alumno)cmbSeleccionarAlumno.SelectedItem).MostrarDatos()}";
                                throw new InstitutoExcepciones(mensajeEx);
                            }
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
                ex.MostrarMensajeError();
                //ExtencionFormularios.MostrarMensajeError(ex);
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
                            AccesoDatos aD = new AccesoDatos();
                            if(!aD.EliminarAlumno(((Alumno)cmbSeleccionarAlumno.SelectedItem).Dni))
                            {
                                rchbResultado.Text = "Se ha cancelado la baja del siguiente alumno:\n";
                                rchbResultado.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).MostrarDatos();
                                miInstituto.Cursos = auxCursosTomados;
                            }
                            else
                            {
                                rchbResultado.Text = "Se ha eliminado al siguiente alumno y dado de baja de todos los cursos donde estaba inscripto:\n";
                                rchbResultado.Text = ((Alumno)cmbSeleccionarAlumno.SelectedItem).MostrarDatos();

                                RefrescarAlumnos();
                            }
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
                ex.MostrarMensajeError();
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
                    txtDni.Enabled = false;
                    cmbGenero.SelectedItem = ((Alumno)cmbSeleccionarAlumno.SelectedItem).Genero;
                    nudEdad.Value = ((Alumno)cmbSeleccionarAlumno.SelectedItem).Edad;
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }

        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno auxAlumno = ((Alumno)cmbSeleccionarAlumno.SelectedItem);
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
                        ((Alumno)cmbSeleccionarAlumno.SelectedItem).Genero = (Alumno.EGenero)cmbGenero.SelectedItem;
                        ((Alumno)cmbSeleccionarAlumno.SelectedItem).Dni = (short)nudEdad.Value;
                        miInstituto.Alumnos = Instituto.modificar<Alumno>(((Alumno)cmbSeleccionarAlumno.SelectedItem).Id,
                            ((Alumno)cmbSeleccionarAlumno.SelectedItem),
                            miInstituto.Alumnos);
                        AccesoDatos aD = new AccesoDatos();
                        if(!aD.ModificarAlumno(((Alumno)cmbSeleccionarAlumno.SelectedItem)))
                        {
                            //Restauro el alumno a sus datos anteriores para evitar datos distintos entre la base de datos y el programa
                            miInstituto.Alumnos = Instituto.modificar<Alumno>((auxAlumno).Id,
                            (auxAlumno),
                            miInstituto.Alumnos);
                            string mensajeEx = $"No se pudo modificar en la base de datos al siguiente alumno {((Alumno)cmbSeleccionarAlumno.SelectedItem).MostrarDatos()}";
                            throw new InstitutoExcepciones(mensajeEx);
                        }
                        else
                        {
                            LimpiarDatos();
                        }                        
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
                ex.MostrarMensajeError();
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
                ex.MostrarMensajeError();
            }
            
        }
        private void btnInscripcion_Click(object sender, EventArgs e)
        {            
            FormInscripcionesAlumnos formInscripciones = new FormInscripcionesAlumnos(miInstituto);
            formInscripciones.ShowDialog();
        }
    }
}
