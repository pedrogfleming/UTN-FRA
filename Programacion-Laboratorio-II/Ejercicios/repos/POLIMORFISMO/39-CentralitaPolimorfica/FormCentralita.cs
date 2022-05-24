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
    
    public partial class FormMenu : Form
    {
        public Centralita miCentralita;
        public FormMenu()
        {
            InitializeComponent();
            miCentralita = new Centralita("Tuentix");
    }

        private void btnGenerarLLamada_Click(object sender, EventArgs e)
        {
            FormLlamador formLlamador = new FormLlamador(miCentralita);
            formLlamador.Show();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FormMostrar formFacturacion = new FormMostrar(miCentralita, Entidades.LLamada.TipoLlamada.Todas);
            formFacturacion.Show();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FormMostrar formFacturacion = new FormMostrar(miCentralita, Entidades.LLamada.TipoLlamada.Local);
            formFacturacion.Show();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FormMostrar formFacturacion = new FormMostrar(miCentralita, Entidades.LLamada.TipoLlamada.Provincial);
            formFacturacion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
