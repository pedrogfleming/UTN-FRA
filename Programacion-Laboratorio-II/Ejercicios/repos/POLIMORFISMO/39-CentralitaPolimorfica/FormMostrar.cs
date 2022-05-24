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
namespace _41_CentralitaExcepciones
{
    public partial class FormMostrar : Form
    {
        private LLamada.TipoLlamada criterioFacturacion;
        private Centralita centralita;
        public FormMostrar(Centralita auxCentralita, LLamada.TipoLlamada criterioTipoLlamada)
        {
            InitializeComponent();            
            //centralita = new Centralita();
            this.Centralita = auxCentralita;
            this.CriterioFacturacion = criterioTipoLlamada;
        }
        #region Propiedades
        public Centralita Centralita
        {
            set 
            {
                this.centralita = value;
            }
        }
        public LLamada.TipoLlamada CriterioFacturacion 
        {
            set
            {
                if(value.GetType() == typeof(LLamada.TipoLlamada))
                {
                    this.criterioFacturacion = value;
                }
                //rtxtbFacturacion.Text = (centralita.GananciasPorProvincial).ToString();
                //rtxtbFacturacion.AppendText("provincial");
            }
        }
        #endregion
        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            foreach (LLamada item in this.centralita.Llamadas)
            {
                if (item is Local && this.criterioFacturacion == LLamada.TipoLlamada.Local)
                {
                    rtxtbFacturacion.Text += item.ToString();
                }
                else if (item is Provincial && this.criterioFacturacion == LLamada.TipoLlamada.Provincial)
                {
                    rtxtbFacturacion.Text += item.ToString();
                }
                else if (this.criterioFacturacion == LLamada.TipoLlamada.Todas)
                {
                    rtxtbFacturacion.Text += item.ToString();
                }
            }

            if (this.criterioFacturacion == LLamada.TipoLlamada.Todas)
            {
                rtxtbFacturacion.Text += $"*******************************************************************";
                rtxtbFacturacion.Text += $"Ganancia por todas las llamadas {this.centralita.GananciasPorTotal}";
            }
            else if (this.criterioFacturacion == LLamada.TipoLlamada.Local)
            {
                rtxtbFacturacion.Text += $"*******************************************************************";
                rtxtbFacturacion.Text += $"Ganancia por llamadas Locales {this.centralita.GananciasPorLocal}";
            }
            else
            {
                rtxtbFacturacion.Text += $"*******************************************************************";
                rtxtbFacturacion.Text += $"Ganancia por llamadas Provinciales {this.centralita.GananciasPorProvincial}";
            }


        }

    }
}
