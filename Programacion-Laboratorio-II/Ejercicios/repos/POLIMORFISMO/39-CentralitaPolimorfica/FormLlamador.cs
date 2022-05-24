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
    public partial class FormLlamador : Form
    {

        
        private Centralita centralita;
        public FormLlamador(Centralita auxCentralita)
        {
            InitializeComponent();
            this.centralita = auxCentralita;
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            try
            {
                Random auxRandom = new Random();
                float auxDuracion = auxRandom.Next(1, 50);
                LLamada auxLlamada;
                //Si la llamada comienza con #, es Provincial.
                Provincial.Franja auxFranja;
                if (!String.IsNullOrWhiteSpace(txtNroDestino.Text))
                {
                    if (txtNroDestino.Text.First() == '#')
                    {
                        auxLlamada = new Provincial(this.txtNroOrigen.Text,
                            (Provincial.Franja)cmbFranja.SelectedItem,
                            auxDuracion, this.txtNroDestino.Text);
                    }
                    else
                    {
                        //Es local
                        float costo = auxRandom.Next(5, 56);
                        costo /= 100;
                        cmbFranja.Enabled = false;
                        auxLlamada = new Local(this.txtNroOrigen.Text, auxDuracion, this.txtNroDestino.Text, costo);
                    }
                    throw new CentralitaExcepcion("aaa","FormLlamada","btnLlamarClick",new Exception("Hola juan carlos"));
                    centralita += auxLlamada;                    
                }
            }
            catch (CentralitaExcepcion errorLlamadaRepetida)
            {                
                StringBuilder aux = new StringBuilder();
                aux.AppendLine(errorLlamadaRepetida.Message);
                aux.AppendLine(errorLlamadaRepetida.NombreClase);
                aux.AppendLine(errorLlamadaRepetida.NombreMetodo);
                Exception exInner = errorLlamadaRepetida.InnerException;
                while (exInner != null)
                {
                    aux.AppendLine(exInner.Message);
                    exInner = exInner.InnerException;
                }
                MessageBox.Show(aux.ToString());
            }
            catch (Exception eGeneral)
            {
                StringBuilder aux = new StringBuilder();
                Exception exInner = eGeneral.InnerException;
                while (exInner != null)
                {
                    aux.AppendLine(exInner.Message);
                    exInner = exInner.InnerException;
                }
                MessageBox.Show(aux.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Clear();
            this.txtNroOrigen.Clear();
            this.cmbFranja.SelectedItem = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
