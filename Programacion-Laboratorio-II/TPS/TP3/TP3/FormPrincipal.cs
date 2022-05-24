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
    public partial class FormPrincipal : Form
    {
        private static Instituto miInstituto;
        private Random gen = new Random();
        public FormPrincipal()
        {
            InitializeComponent();
            miInstituto = new Instituto("Instituto Derek Zoolander");
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Name = miInstituto.Nombre;
            //Deserealizacion Alumnos
            string ruta = SerializacionArchivo.CrearRuta("Alumnos.json");
            miInstituto.Alumnos = SerializacionArchivo.DeserealizarDesdeJson<List<Alumno>>(ruta);
            //Desearalizacion Cursos
            ruta = SerializacionArchivo.CrearRuta("Curso.json");
            miInstituto.Cursos = SerializacionArchivo.DeserealizarDesdeJson<List<Curso>>(ruta);
            miInstituto.chequearIdCursosCargados();
            miInstituto.chequearIdAlumnosCargados();
            try
            {
                Instituto.ChequearIdRepetidos(miInstituto.Cursos);
            }
            catch (Exception ex)
            {
                ExtencionFormularios.MostrarMensajeError(ex);
            }
            try
            {
                Instituto.ChequearIdRepetidos(miInstituto.Alumnos);
            }
            catch (Exception ex)
            {
                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos ventanaAlumnos = new FormAlumnos(miInstituto);
            ventanaAlumnos.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCursos ventanaCursos = new FormCursos(miInstituto);
            ventanaCursos.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {            
            FormInformes ventanaInformes = new FormInformes(miInstituto);
            ventanaInformes.ShowDialog();
        }
    }
}
