using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace TP4
{
    public delegate void delForm(string comunicado);
    //public delegate void delAccion();
    //public delegate void delEnvioMails();

    public partial class FormPrincipal : Form
    {
        public event delForm ActivarEnvioMails;
        //public event Action ConectandoServidor;
        private static Instituto miInstituto;
        CancellationTokenSource source;
        CancellationToken token;
        private Task HiloGuardarCopiaSeguridad;
        private AccesoDatos aD;
        FormMails formMails;
        //FormAvisoConexion formServidor;
        //private bool nuevoCurso;
        //private string nombreNuevoCurso;

        public FormPrincipal()
        {
            InitializeComponent();
            aD = new AccesoDatos();
            miInstituto = new Instituto("Instituto Derek Zoolander Para niños que no saben leer y escribir bien");
            this.source = new CancellationTokenSource();
            this.token = source.Token;

            //formMails = new FormMails(miInstituto);
            //delEnvioMails delFormEnviosMails = formMails.IniciarEnvioMails;
            //ActivarEnvioMails += delFormEnviosMails;

            delForm delFormEnviosMails = this.AbrirVentanaMails;
            this.ActivarEnvioMails += delFormEnviosMails;

            //Action delConexionServidor = this.AvisarConexionServidor;
            //this.ConectandoServidor += delConexionServidor;

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Name = miInstituto.Nombre;
            try
            {
                //bool conexion = aD.ProbarConexion();
                ////Serializacion Alumnos
                //string ruta = SerializacionArchivo.CrearRuta("Alumnos.json");
                //SerializacionArchivo.SerializarAJason<List<Alumno>>(ruta, miInstituto.Alumnos);
                //Deserealizacion Alumnos
                //string ruta = SerializacionArchivo.CrearRuta("Alumnos.json");
                //miInstituto.Alumnos = SerializacionArchivo.DeserealizarDesdeJson<List<Alumno>>(ruta);
                #region Harcodeo Base de Datos Alumnos
                //foreach (Alumno item in miInstituto.Alumnos)
                //{
                //    if (!aD.AgregarAlumno(item))
                //    {
                //        MessageBox.Show(item.MostrarDatos(), "Error al agregar alumno");
                //    }
                //}
                #endregion
                #region Hardcodeo Base de Datos Cursos
                //foreach (Curso item in miInstituto.Cursos)
                //{
                //    if (!aD.AgregarCurso(item))
                //    {
                //        MessageBox.Show(item.MostrarDatos(), "Error al agregar Curso");
                //    }
                //}
                #endregion
                //Desearalizacion Cursos
                //ruta = SerializacionArchivo.CrearRuta("Curso.json");
                //miInstituto.Cursos = SerializacionArchivo.DeserealizarDesdeJson<List<Curso>>(ruta);
                miInstituto.Alumnos = aD.ObtenerListaAlumnos();
                miInstituto.Cursos = aD.ObtenerListaCursos();
                //Task.Run(() => this.ChequearCursosNuevos(this.token));
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }            
            miInstituto.chequearIdCursosCargados();
            miInstituto.chequearIdAlumnosCargados();
            try
            {
                Instituto.ChequearIdRepetidos(miInstituto.Cursos);
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
            try
            {
                Instituto.ChequearIdRepetidos(miInstituto.Alumnos);
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
            try
            {
                this.HiloGuardarCopiaSeguridad = new Task(() => this.actualizarArchivoSeguridad(token));
                this.HiloGuardarCopiaSeguridad.Start();                
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
        private void actualizarArchivoSeguridad(CancellationToken cancelToken)
        {
            while(!cancelToken.IsCancellationRequested)
            {
                try
                {
                    string rutaAlumnos = SerializacionArchivo.CrearRuta("Copia_Seguridad_Alumnos_Instituto.json");
                    string rutaCursos = SerializacionArchivo.CrearRuta("Copia_Seguridad_Cursos_Instituto.json");
                    //Evito dejar en blanco los archivos de backup
                    if (miInstituto.Cursos.Count > 0)
                    {
                        SerializacionArchivo.SerializarAJason<List<Curso>>(rutaCursos, miInstituto.Cursos);
                    }
                    if (miInstituto.Alumnos.Count > 0)
                    {
                        SerializacionArchivo.SerializarAJason<List<Alumno>>(rutaAlumnos, miInstituto.Alumnos);
                    }
                    //Se espera 1 minuto para hacer una copia de seguridad
                    Thread.Sleep(60000);
                }
                catch (Exception ex)
                {
                    ex.MostrarMensajeError();
                }
            }
        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos ventanaAlumnos = new FormAlumnos(miInstituto);
            ventanaAlumnos.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCursos ventanaCursos = new FormCursos(miInstituto, ActivarEnvioMails);
            ventanaCursos.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {            
            FormInformes ventanaInformes = new FormInformes(miInstituto);
            ventanaInformes.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.source.Cancel();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            if(miInstituto.Alumnos.Count > 0 || miInstituto.Cursos.Count > 0)
            {                
                Action ACLimpiarDatos= this.LimpiarInstituto;
                FormEliminarDatos ventanaELiminandoInfo = new FormEliminarDatos(ACLimpiarDatos);
                ventanaELiminandoInfo.Show();                         
            }
        }
        private void LimpiarInstituto()
        {  
            miInstituto.Alumnos.Clear();
            miInstituto.Cursos.Clear();
        }

        private void btnRestaurarInstituto_Click(object sender, EventArgs e)
        {
            try
            {
                //Deserealizacion Alumnos
                string ruta = SerializacionArchivo.CrearRuta("Copia_Seguridad_Alumnos_Instituto.json");
                miInstituto.Alumnos = SerializacionArchivo.DeserealizarDesdeJson<List<Alumno>>(ruta);
                //Desearalizacion Cursos
                ruta = SerializacionArchivo.CrearRuta("Copia_Seguridad_Cursos_Instituto.json");
                miInstituto.Cursos = SerializacionArchivo.DeserealizarDesdeJson<List<Curso>>(ruta);
                MessageBox.Show($"Se ha restaurado la copia de seguridad del instituto: \nTotal alumnos:{miInstituto.Alumnos.Count}\nTotal Cursos:{ miInstituto.Cursos.Count}");
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }

        private void btnMails_Click(object sender, EventArgs e)
        {
            this.AbrirVentanaMails("Enviar comunicado email a los alumnos del instituto sobre nuestros cursos");
        }
        private void AbrirVentanaMails(string comunicado)
        {
            if (this.formMails is null || this.formMails.IsDisposed)
            {
                this.formMails = new FormMails(miInstituto, comunicado);
            }
            formMails.ShowDialog();
        }
        #region Futuras implementaciones
        ///// <summary>
        ///// Instanciara un nuevo formulario mostrando el tipo de conexion con el servidor solicitada por el programa
        ///// </summary>
        //private void AvisarConexionServidor()
        //{
        //    if (this.formServidor is null || this.formServidor.IsDisposed)
        //    {
        //        this.formServidor = new FormAvisoConexion();
        //    }
        //    formServidor.ShowDialog();
        //}
        //private void NuevoCursoAgregadoPorUsuario(string nombreCurso)
        //{
        //    this.nuevoCurso = true;
        //}
        ///// <summary>
        ///// Chequeara que haya un nuevo curso. En caso de que si,instanciara un nuevo formulario de envio mails
        ///// </summary>
        //private void ChequearCursosNuevos(CancellationToken token)
        //{
        //    while(!token.IsCancellationRequested)
        //    {
        //        if(this.nuevoCurso == true)
        //        {


        //        }
        //    }
        //}
        #endregion
    }
}
