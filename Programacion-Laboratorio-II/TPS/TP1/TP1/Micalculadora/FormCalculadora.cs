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
namespace Micalculadora
{
    public partial class FormCalculadora : Form
    {
        private bool resultadoEsBinario = false;
        private bool esNegativoOperando1 = false;
        private bool esNegativoOperando2 = false;
        public FormCalculadora()
        {
            InitializeComponent();
        }
        #region Limpiar operadores y operador
        /// <summary>
        /// Al presionar el boton limpiar, se llamara al metodo Limpiar() para dejar en blanco
        /// Los operandos, el operador y el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Al cargar el formulario, se llamara al metodo Limpiar() para dejar en blanco
        /// Los operandos, el operador y el resultado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Deja en blanco Los operandos, el operador y el resultado 
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";
            cmbOperador.SelectedIndex = 0;
            resultadoEsBinario = true;
        }

        #endregion
        #region Conversores Binario/Decimal
        /// <summary>
        /// Al presionar el boton "Convertir a Binario" se convertira el resultado en decimal a Binario sólo sí es un número decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(resultadoEsBinario == false && lblResultado.Text != "")//Para evitar que el usuario convierta un binario a binario nuevamente
            {
                Operando auxBinario = new Operando();
                lblResultado.Text = auxBinario.DecimalBinario(lblResultado.Text);
                resultadoEsBinario = true;
            }           

        }
        /// <summary>
        /// Al presionar el boton "Convertir a Decimal" se convertira el resultado binario a decimal sólo sí es un número binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (resultadoEsBinario == true && lblResultado.Text != "")
            {
                Operando auxDecimal = new Operando();
                lblResultado.Text = auxDecimal.BinarioDecimal(lblResultado.Text);
                resultadoEsBinario = false;
            }
        }
        #endregion
        #region Operar
        /// <summary>
        /// Al tocar el boton Operar, se realizara la operacion entre los operadores ingresados por el usuario
        /// En función del operador seleccionado por el usuario y se mostrara el resultado y guardará en el historial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string auxOperador = cmbOperador.Text;
            string auxOperando1 = "0";                              //Si el usuario no ingresa operandos, se asigna por default "0"
            string auxOperando2 = "0";
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, auxOperador);
            if(cmbOperador.SelectedItem.ToString() == "")
            {
                auxOperador = "+";
            }
            if(txtNumero1.Text != "")                               //Se pisa el "0" con el numero ingresado por el usuario
            {
                auxOperando1 = txtNumero1.Text;
            }
            if(txtNumero2.Text != "")
            {
                auxOperando2 = txtNumero2.Text;
            }
            lstOperaciones.Items.Add(auxOperando1 + auxOperador + auxOperando2 + "="+resultado.ToString());
            resultadoEsBinario = false;
            lblResultado.Text = resultado.ToString();            
        }       
        /// <summary>
        /// Realiza la operacion correspondiente entre dos numeros pasados por parametros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando auxOperador1 = new Operando(numero1);
            Operando auxOperador2 = new Operando(numero2);
            char auxOperador;
            char.TryParse(operador, out auxOperador);
            return Calculadora.Operar(auxOperador1, auxOperador2, auxOperador);
        }
        #endregion
        #region Cerrar Form
        /// <summary>
        /// Al presionar el boton Cerrar, se cerrará el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Cuando se este cerrando el formulario, se le mostrará una ventana emergente confirmando la salida del programa
        /// Si el usuario selecciona Yes, saldrá, si no, se abortara la salida del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("¿Está seguro  de  querer  salir?");
            DialogResult result = MessageBox.Show("¿Está seguro  de  querer  salir?", "Confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ha confirmado la salida del programa");
            }
            else
            {
                MessageBox.Show("Ha cancelado la salida del programa");
                e.Cancel = true;
            }
        }

        #endregion
        #region Validaciones de entrada de datos
        /// <summary>
        /// Impide que el usuario ingrese datos no numericos en los text de los operandos,
        /// exceptuando el backspace para que pueda borrar y el - en la primera posicion para poder ingresar numeros negativos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNumero1.Text == "")                              //Si el text2 esta vacio, puede volver a ingresar el '-'
            {
                esNegativoOperando1 = false;
            }
            if (esNegativoOperando1 == true && e.KeyChar == '-')   //Si quiere ingresar '-' y ya hay un '-', se le cancela el input
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '-')                //Si ingresa por primera vez un '-', se le permite el input y cambio la bandera 
            {
                esNegativoOperando1 = true;
            }
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')         //8 es el codigo ascii del backspace
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Impide que el usuario ingrese datos no numericos en los text de los operandos,
        /// exceptuando el backspace para que pueda borrar y el - en la primera posicion para poder ingresar numeros negativos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNumero2.Text == "")                              //Si el text1 esta vacio, puede volver a ingresar el '-'
            {
                esNegativoOperando2 = false;
            }
            if (esNegativoOperando2 == true && e.KeyChar == '-')   //Si quiere ingresar '-' y ya hay un '-', se le cancela el input
            {
                e.Handled = true;
            }
            else if(e.KeyChar == '-')                //Si ingresa por primera vez un '-', se le permite el input y cambio la bandera 
            {
                esNegativoOperando2 = true;
            }
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')        //8 es el codigo ascii del backspace
            {
                e.Handled = true;
            }
        }
        #endregion
    }

    
}
