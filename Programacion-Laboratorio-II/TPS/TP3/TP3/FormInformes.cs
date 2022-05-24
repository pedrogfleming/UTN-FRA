using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace TP3
{
    public partial class FormInformes : Form
    {
        private Instituto miInstituto;
        private bool vistaCursos;
        public FormInformes(Instituto auxInstituto)
        {
            InitializeComponent();
            this.miInstituto = auxInstituto;
            vistaCursos = false;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            { 
                if (vistaCursos == true)
                {
                    List<Curso> auxListaCursos = new List<Curso>();
                    auxListaCursos = (List<Curso>)dgvInformes.DataSource;
                    if (chbTotalInscriptos.Checked == true)
                    {
                        auxListaCursos = Curso.FiltrarPorAtributo(auxListaCursos, "inscriptos", nudTotalInscriptos.Value.ToString());
                    }
                    if (cmbFiltroElearning.SelectedIndex >= 0 && cmbFiltroElearning.SelectedItem.ToString() != "Omitir Filtro")
                    {
                        if (cmbFiltroElearning.SelectedItem.ToString() == "Es E-Learning")
                        {
                            auxListaCursos = Curso.FiltrarPorAtributo(auxListaCursos, "eLearning", true.ToString());
                        }
                        else
                        {
                            auxListaCursos = Curso.FiltrarPorAtributo(auxListaCursos, "eLearning", false.ToString());
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        auxListaCursos = Curso.FiltrarPorAtributo(auxListaCursos, "descripcion", txtNombre.Text.Trim());
                    }                    
                    if (auxListaCursos.Count > 0)
                    {
                        ExtencionFormularios.RefrescarDGV<Curso>(dgvInformes, auxListaCursos);
                        btnExportarCursos.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se han encontrado valores segun el criterio establecido");
                        btnExportarCursos.Enabled = false;
                    }

                }
                else
                {
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }            
        }

        #region Metodos en desarrollo

        //private static List<Curso> Informe_ObtenerIntervalo(List<Curso> listaBase, DateTime inicioIntervalo,DateTime finIntervalo)
        //{
        //    if (listaBase is not null && listaBase.Count > 0)
        //    {
        //        return listaBase.FindAll(delegate (Curso c)
        //        {
        //            for (DateTime date = startingDate; date <= endingDate; date = date.AddDays(1)) allDates.Add(date);
        //            return c.ELearning == esElearning;
        //        });
        //    }
        //    return listaBase;
        //}
        //}
        ///// <summary>
        ///// Realiza cualquier tipo de infomrme de cualquier tipo de objeto que implemente la interfaz IIdentifier
        ////  Se chequea los atributos particuales del objeto y se busca la coincidencia
        ////    Despúes se revisa los valores de ese atributo y se busca el match
        ///// </summary>
        ///// <param name="listadoOriginal"></param>
        ///// <param name="criterio"></param>
        ////   <return>La sublista filtrada<return>
        private static List<T> prepararInforme<T>(List<T> listadoOriginal, string campoCriterio,string operador,string keyWord)
            where T : IIdentifier
        {
            if (listadoOriginal is not null && listadoOriginal.Count > 0)
            {

                var at = typeof(T).Attributes;
                List<T> auxLista = new List<T>();
                PropertyInfo[] listaAtributos = typeof(T).GetProperties();
                List<PropertyInfo> aux = new List<PropertyInfo>();
                foreach (PropertyInfo item in listaAtributos)
                {
                    if (item.Name == campoCriterio)
                    {
                        //criterio puede ser curso(id,fecha,descripcion) o alumno(id,apellido,dni,etc)
                        foreach (T JItem in listadoOriginal)
                        {
                            //Recorro los atributos del obj
                            foreach (FieldInfo AttItem in JItem.GetType().GetFields())
                            {
                                if(AttItem.Name == campoCriterio)
                                {

                                    switch (operador)
                                    {
                                        case "==":
                                            auxLista.Add(listadoOriginal.Find(delegate (T c)
                                            {
                                                return c.GetType().GetField(AttItem.Name).GetValue(c) == keyWord;
                                                //return c.Id.ToString() == keyWord;
                                            }));
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                //auxLista = ExtencionFormularios.ObtenerAtributosClases<T>(listadoOriginal.First<T>());
            }
            return null;
        }
        #endregion
        private void FormInformes_Load(object sender, EventArgs e)
        {
            lbTipoInforme.Location = new Point(28, 39);
            lbTipoInforme.Size = new Size(684, 368);
        }
        #region Metodos
        private void estadoBtnMostrar(bool estado)
        {
            if (estado == true)
            {
                btnMostrar.Visible = true;
            }
        }
        private static T ObtenerSeleccionado<T>(DataGridView dgv,List<T> listaData) where T : class, IIdentifier
        {
            if (dgv.CurrentCell is not null)
            {
                int rowIndex = dgv.CurrentCell.RowIndex;
                int i = 0;
                if (rowIndex >= 0 && rowIndex < listaData.Count)
                {
                    foreach (T item in listaData)
                    {
                        if (i == rowIndex)
                        {
                            return (T)dgv.CurrentRow.DataBoundItem;
                        }
                        i++;
                    }
                }
            }
            T nulo = null;
            return nulo;
        }
        private void mostrarCursosDelAlumno()
        {
            Alumno auxAlumno = ObtenerSeleccionado<Alumno>(this.dgvInformes
                , (List<Alumno>)dgvInformes.DataSource);
            if (auxAlumno is not null)
            {
                ExtencionFormularios.RefrescarDGV(dgvCursosTomados,
                    miInstituto.BuscarCursosTomados(auxAlumno));
            }
        }
        #endregion

        private void chbFiltroCursos_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void chbInformesAlumnos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                #region Seteo Visual
                nudTotalInscriptos.Visible = false;
                chbTotalInscriptos.Visible = false;
                lbFiltrarPorElearning.Visible = false;
                cmbFiltroElearning.Visible = false;
                chbNombre.Visible = false;
                txtNombre.Visible = false;
                chbNombre.Visible = false;
                lbTipoInforme.Text = "INFORMES ALUMNOS";
                lbTipoInforme.Location = new Point(454, 37);
                lbTipoInforme.Size = new Size(258, 176);
                btnMostrar.Visible = false;
                btnExportarCursos.Visible = false;
                btnInformeAlumnoMasCursos.Visible = true;
                btnInformeAlumnoConMenosCursos.Visible = true;
                btnInformeAlumnoMasViejo.Visible = true;
                btnInformeMasJoven.Visible = true;
                #endregion
                this.vistaCursos = false;
                dgvInformes.Visible = true;
                dgvCursosTomados.Visible = true;
                ExtencionFormularios.RefrescarDGV(dgvInformes, miInstituto.Alumnos);
                if (((List<Alumno>)dgvInformes.DataSource).Count > 0)
                {
                    btnExportarAlumnos.Visible = true;
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
            
        }
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                #region Seteo Visual
                nudTotalInscriptos.Visible = true;
                chbTotalInscriptos.Visible = true;
                lbFiltrarPorElearning.Visible = true;
                cmbFiltroElearning.Visible = true;
                chbNombre.Visible = true;
                txtNombre.Visible = true;
                lbTipoInforme.Text = "INFORMES CURSOS";
                lbTipoInforme.Location = new Point(454, 37);
                lbTipoInforme.Size = new Size(258, 176);
                btnExportarAlumnos.Visible = false;
                btnInformeAlumnoMasCursos.Visible = false;
                btnInformeAlumnoConMenosCursos.Visible = false;
                btnInformeAlumnoMasViejo.Visible = false;
                btnInformeMasJoven.Visible = false;
                #endregion
                this.vistaCursos = true;
                dgvInformes.Visible = true;
                dgvCursosTomados.Visible = false;
                ExtencionFormularios.RefrescarDGV(dgvInformes, miInstituto.Cursos);
                if (((List<Curso>)dgvInformes.DataSource).Count > 0)
                {
                    btnExportarCursos.Visible = true;
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
            
        }

        #region Checkboxes
        private void chbTotalInscriptos_CheckedChanged(object sender, EventArgs e)
        {
            nudTotalInscriptos.Enabled = chbTotalInscriptos.Checked;
            estadoBtnMostrar(nudTotalInscriptos.Enabled);
        }
        private void chbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = chbNombre.Checked;
            estadoBtnMostrar(txtNombre.Enabled);
        }                
        #endregion
        private void btnExportarAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                string data = Instituto.ObtenerDatos((List<Alumno>)dgvInformes.DataSource);
                string ruta = SerializacionArchivo.CrearRuta("Datos_Alumnos.txt");
                SerializacionArchivo.GuardarTxt(ruta, data);
            }
            catch (Exception ex)
            {
                ExtencionFormularios.MostrarMensajeError(ex);
            }
            
        }

        private void btnExportarCursos_Click(object sender, EventArgs e)
        {
            try
            {
                string data = Instituto.ObtenerDatos((List<Curso>)dgvInformes.DataSource);
                string ruta = SerializacionArchivo.CrearRuta("Datos_Cursos.txt");
                SerializacionArchivo.GuardarTxt(ruta, data);
            }
            catch (Exception ex)
            {
                ExtencionFormularios.MostrarMensajeError(ex);
            }            
        }

        private void dgvInformes_SelectionChanged(object sender, EventArgs e)
        {        
        }

        private void btnInformeAlumnoMasCursos_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaCursos == false && miInstituto.Alumnos.Count > 0)
                {
                    Alumno aMayor = miInstituto.AlumnoConMasCursos();
                    if (aMayor is not null)
                    {
                        List<Alumno> listaConElMayor = new List<Alumno>();
                        listaConElMayor.Add(aMayor);
                        ExtencionFormularios.RefrescarDGV(this.dgvInformes, listaConElMayor);
                    }
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }

        private void btnAlumnoConMenosCursos_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaCursos == false && miInstituto.Alumnos.Count > 0)
                {
                    Alumno aMenor = miInstituto.AlumnoConMenosCursos();
                    if (aMenor is not null)
                    {
                        List<Alumno> listaConElMayor = new List<Alumno>();
                        listaConElMayor.Add(aMenor);
                        ExtencionFormularios.RefrescarDGV(this.dgvInformes, listaConElMayor);
                    }
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }

        private void dgvInformes_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaCursos == true)
                {
                    List<Curso> auxCursos = new List<Curso>();
                    auxCursos = (List<Curso>)dgvInformes.DataSource;
                    Curso cursoSeleccionado = FormInformes.ObtenerSeleccionado(this.dgvInformes, auxCursos);
                    if (cursoSeleccionado.Inscriptos.Count > 0)
                    {
                        ExtencionFormularios.RefrescarDGV(this.dgvCursosTomados, cursoSeleccionado.Inscriptos);
                        this.dgvCursosTomados.Visible = true;
                    }
                }
                else
                {
                    Alumno alumnoSeleccionado = FormInformes.ObtenerSeleccionado(this.dgvInformes, (List<Alumno>)dgvInformes.DataSource);
                    List<Curso> auxCursosTomados = new List<Curso>();
                    auxCursosTomados = miInstituto.BuscarCursosTomados(alumnoSeleccionado);
                    if (auxCursosTomados.Count > 0)
                    {
                        ExtencionFormularios.RefrescarDGV(this.dgvCursosTomados, auxCursosTomados);
                    }
                }
            }
            catch (System.InvalidCastException)
            {
            }
            catch (Exception exGen)
            {

                ExtencionFormularios.MostrarMensajeError(exGen);
            }
        }

        private void btnAlumnoMasViejo_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaCursos == false && miInstituto.Alumnos.Count > 0)
                {
                    Alumno aMayor = miInstituto.AlumnoMasViejo();
                    if (aMayor is not null)
                    {
                        List<Alumno> listaConElMayor = new List<Alumno>();
                        listaConElMayor.Add(aMayor);
                        ExtencionFormularios.RefrescarDGV(this.dgvInformes, listaConElMayor);
                    }
                }
            }
            catch (Exception ex)
            {

                ExtencionFormularios.MostrarMensajeError(ex);
            }
        }

        private void btnInformeMasJoven_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaCursos == false && miInstituto.Alumnos.Count > 0)
                {
                    Alumno aJoven = miInstituto.AlumnoMasJoven();
                    if (aJoven is not null)
                    {
                        List<Alumno> listaConElMasJoven = new List<Alumno>();
                        listaConElMasJoven.Add(aJoven);
                        ExtencionFormularios.RefrescarDGV(this.dgvInformes, listaConElMasJoven);
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
