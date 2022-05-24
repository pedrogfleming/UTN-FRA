using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace TP4
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
                        this.dgvInformes.RefrescarDGV(auxListaCursos);
                        btnExportarCursos.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se han encontrado valores segun el criterio establecido");
                        btnExportarCursos.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
        //private static List<T> prepararInforme<T>(List<T> listadoOriginal, string criterio)
        //    where T : IIdentifier
        //{
        //    if (listadoOriginal is not null && listadoOriginal.Count > 0)
        //    {
        //        //List<T> auxLista = new List<T>();
        //        PropertyInfo[] listaAtributos = typeof(T).GetProperties();
        //        List<PropertyInfo> aux = new List<PropertyInfo>();
        //        foreach (PropertyInfo item in listaAtributos)
        //        {
        //            if (item.Name == criterio)
        //            {
        //                //criterio puede ser curso(id,fecha,descripcion) o alumno(id,apellido,dni,etc)
        //                foreach (T JItem in listadoOriginal)
        //                {
        //                    foreach (PropertyInfo KItem in JItem.)
        //                    {

        //                    }
        //                }
        //            }
        //            aux.Add(item);
        //        }
        //        auxLista = ExtencionFormularios.ObtenerAtributosClases<T>(listadoOriginal.First<T>());
        //    }
        //}
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
                btnInformesGenerales.Visible = true;
                lbCursosInscripto.Text = "Cursos en los que está inscripto el alumno";
                lbCursosInscripto.Visible = true;
                #endregion
                this.vistaCursos = false;
                dgvInformes.Visible = true;
                dgvCursosTomados.Visible = true;
                this.dgvInformes.RefrescarDGV(miInstituto.Alumnos);
                if (((List<Alumno>)dgvInformes.DataSource).Count > 0)
                {
                    btnExportarAlumnos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
                btnInformesGenerales.Visible = true;
                lbCursosInscripto.Text = "Alumnos inscriptos al curso";
                lbCursosInscripto.Visible = true;
                #endregion
                this.vistaCursos = true;
                dgvInformes.Visible = true;
                dgvCursosTomados.Visible = false;
                this.dgvInformes.RefrescarDGV(miInstituto.Cursos);
                if (((List<Curso>)dgvInformes.DataSource).Count > 0)
                {
                    btnExportarCursos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
                string ruta = SerializacionArchivo.CrearRuta("Datos_Alumnos.json");
                SerializacionArchivo.SerializarAJason<List<Alumno>>(ruta, (List<Alumno>)dgvInformes.DataSource);
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }            
        }

        private void btnExportarCursos_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = SerializacionArchivo.CrearRuta("Datos_Cursos.json");
                SerializacionArchivo.SerializarAJason<List<Curso>>(ruta, (List<Curso>)dgvInformes.DataSource);
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
                        this.dgvInformes.RefrescarDGV(listaConElMayor);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
                        this.dgvInformes.RefrescarDGV(listaConElMayor);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
                        this.dgvCursosTomados.RefrescarDGV(cursoSeleccionado.Inscriptos);
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
                        this.dgvCursosTomados.RefrescarDGV(auxCursosTomados);
                    }
                }
            }
            catch (System.InvalidCastException)
            {
            }
            catch (Exception exGen)
            {
                exGen.MostrarMensajeError();
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
                        this.dgvInformes.RefrescarDGV(listaConElMayor);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
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
                        this.dgvInformes.RefrescarDGV(listaConElMasJoven);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }

        private void btnInformesGenerales_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(this.miInstituto.InformeEdades() + this.miInstituto.InformeGenero());
                Curso cursoAux = this.miInstituto.CursoMasElegidoPorGenero(Alumno.EGenero.femenino);
                if(cursoAux is not null)
                {
                    sb.AppendFormat("\nEl curso mas elegido por personas de genero femenino es: \n{0}", cursoAux.Descripcion);
                }
                cursoAux = this.miInstituto.CursoMasElegidoPorGenero(Alumno.EGenero.masculino);
                if (cursoAux is not null)
                {
                    sb.AppendFormat("\nEl curso mas elegido por personas de genero masculino es: \n{0}", cursoAux.Descripcion);
                }
                cursoAux = this.miInstituto.CursoMasElegidoPorGenero(Alumno.EGenero.noBinario);
                if (cursoAux is not null)
                {
                    sb.AppendFormat("\nEl curso mas elegido por personas de genero no binario es: \n{0}", cursoAux.Descripcion);
                }
                cursoAux = this.miInstituto.CursoMasElegidoPorGenero(Alumno.EGenero.otro);
                if (cursoAux is not null)
                {
                    sb.AppendFormat("\nEl curso mas elegido por personas de genero otro es: \n{0}", cursoAux.Descripcion);
                }
                string ruta = SerializacionArchivo.CrearRuta("Informes_Instituto.txt");
                MessageBox.Show($"Informe instituto guardado en {ruta}\n:sb.ToString()");
                SerializacionArchivo.GuardarTxt(ruta, sb.ToString());
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
