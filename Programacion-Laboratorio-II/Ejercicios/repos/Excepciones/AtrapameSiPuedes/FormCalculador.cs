using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtrapameSiPuedes
{
    public partial class formCalculador : Form
    {
        public formCalculador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtKilometros.Text) ||
                !String.IsNullOrWhiteSpace(txtLitros.Text))
                {
                    int operadorA;
                    int operadorB;
                    if (int.TryParse(txtKilometros.Text, out operadorA) &&
                        int.TryParse(txtLitros.Text, out operadorB))
                    {
                        rcTxtMostrar.Text += "\t"+Calculador.Calcular(operadorA, operadorB);
                    }
                    else
                    {
                        throw new FormatException("No ha ingresado numeros validos para calcular");
                    }
                }
                else
                {
                    throw new ParametrosVaciosException("Faltan valores para calcular");
                }
            }
            catch (FormatException excepcionFormat)
            {

                MessageBox.Show(excepcionFormat.Message);
            }
            catch(ParametrosVaciosException excepcionVacia)
            {
                MessageBox.Show(excepcionVacia.Message);
            }          
            catch(DivideByZeroException excepcionDivisionPorCero)
            {
                MessageBox.Show(excepcionDivisionPorCero.Message);
            }
        }
    }
}
