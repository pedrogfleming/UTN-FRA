using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetin;

namespace _23_AUX
{
    public partial class Form1 : Form
    {
        //public getCotizacion(3 poarametros)
        //txtCotizacion try parse
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDolar_click(object sender, EventArgs e)
        {
            double auxMontoUsuarioDolares;
            double auxCotizacionEuro;
            double auxCotizacionPesos;
            if (!double.TryParse(txtDolarIngresado.Text, out auxMontoUsuarioDolares))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                #region Setter Cotizacion Dolar
                //if (!double.TryParse(txtCotizacionDolar.Text, out auxCotizacion))
                //{
                //    MessageBox.Show("Ingrese solo numeros");
                //}
                //else
                //{
                //    Dolar.SetCotizacion(auxCotizacion);

                //    Dolar montoUsuarioDolar = aux;
                //    Euro montoConvertidoEuro = (Euro)montoUsuarioDolar;
                //    Pesos montoConvertidoPeso = (Pesos)montoUsuarioDolar;
                //    txtDisplayDolar2.Text = montoUsuarioDolar.GetCantidad().ToString();
                //    txtDisplayEuro2.Text = montoConvertidoEuro.GetCantidad().ToString();
                //    txtDisplayPeso2.Text = montoConvertidoPeso.GetCantidad().ToString();
                //}
                #endregion
                if (!double.TryParse(txtCotizacionEuro.Text, out auxCotizacionEuro) ||
                    !double.TryParse(txtCotizacionPeso.Text, out auxCotizacionPesos))
                {
                    MessageBox.Show("Ingrese solo numeros");
                }
                else
                {
                    Euro.SetCotizacion(auxCotizacionEuro);
                    Pesos.SetCotizacion(auxCotizacionPesos);
                    Dolar montoUsuarioDolar = auxMontoUsuarioDolares;
                    Euro montoConvertidoEuro = (Euro)montoUsuarioDolar;
                    Pesos montoConvertidoPeso = (Pesos)montoUsuarioDolar;
                    txtDisplayDolar2.Text = montoUsuarioDolar.GetCantidad().ToString();
                    txtDisplayEuro2.Text = montoConvertidoEuro.GetCantidad().ToString();
                    txtDisplayPeso2.Text = montoConvertidoPeso.GetCantidad().ToString();
                }


            }

        }
        private void btnEuro_Click(object sender, EventArgs e) 
        {
            //al hacer click, hacer las conversiones de euro a pesos/dolar
            double auxEuroIngresado;
            double auxCotizacionEuro;
            double auxCotizacionPesos;
            if (!double.TryParse(txtEuroIngresado.Text, out auxEuroIngresado))
            {
                MessageBox.Show("Ingrese solo numeros en los montos");
            }
            else
            {
                if (!double.TryParse(txtCotizacionEuro.Text, out auxCotizacionEuro) ||
                    !double.TryParse(txtCotizacionPeso.Text, out auxCotizacionPesos))
                {
                    MessageBox.Show("Ingrese solo numeros en la cotizacion");
                }
                else
                {
                    Euro.SetCotizacion(auxCotizacionEuro);
                    Pesos.SetCotizacion(auxCotizacionPesos);
                    Euro montoUsuarioEuro = auxEuroIngresado;
                    Dolar montoUsuarioDolar = (Dolar)montoUsuarioEuro;
                    Pesos montoConvertidoPeso = (Pesos)montoUsuarioDolar;
                    txtDisplayDolar1.Text = montoUsuarioDolar.GetCantidad().ToString();
                    txtDisplayPeso1.Text = montoConvertidoPeso.GetCantidad().ToString();
                    txtDisplayEuro1.Text = montoUsuarioEuro.GetCantidad().ToString();
                }
            }
        }
        private void btnPesoConvertir_Click(object sender, EventArgs e)
        {
            double auxMontoUsuarioPesos;
            double auxCotizacionEuro;
            double auxCotizacionPesos;
            if (!double.TryParse(txtPesoIngresado.Text, out auxMontoUsuarioPesos))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                if (!double.TryParse(txtCotizacionEuro.Text, out auxCotizacionEuro) ||
                    !double.TryParse(txtCotizacionPeso.Text, out auxCotizacionPesos))
                {
                    MessageBox.Show("Ingrese solo numeros");
                }
                else
                {
                    Euro.SetCotizacion(auxCotizacionEuro);
                    Pesos.SetCotizacion(auxCotizacionPesos);
                    Pesos montoUsuarioPeso = auxMontoUsuarioPesos;
                    Euro montoUsuarioEuro = (Euro)montoUsuarioPeso;
                    Dolar montoUsuarioDolar = (Dolar)montoUsuarioEuro;
                    txtDisplayDolar3.Text = montoUsuarioDolar.GetCantidad().ToString();
                    txtDisplayEuro3.Text = montoUsuarioEuro.GetCantidad().ToString();
                    txtDisplayPeso3.Text = montoUsuarioPeso.GetCantidad().ToString();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtEuroIngresado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCandado_click(object sender, EventArgs e)
        {
            if(btnCandado.ImageIndex == 1)      //Si esta abierto el candado
            {
                btnCandado.ImageIndex = 0;          //Cambio la imagen a candado cerrado
                txtCotizacionEuro.Enabled = false;  //inhabilito los txt de cotizaciones
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                btnCandado.ImageIndex = 1;            //El candado esta cerrado, entonces lo abro
                txtCotizacionEuro.Enabled = true;     //Habilito los txt de las cotizaicones
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }
            
        }

        private void txtDisplayDolar1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
