using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formPrincipal
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegate(string nombre);
        private ActualizarNombreDelegate actualizarNombreDelegate;

        public FrmTestDelegados(ActualizarNombreDelegate actualizarNombreDelegate)
        {
            InitializeComponent();
            this.actualizarNombreDelegate = actualizarNombreDelegate;
        }
        /// <summary>
        /// Se pide que el usuario ingrese un nombre por el TextBox de FrmTestDelegados y
        /// que al pulsar el botón btnActualizar,
        /// se cambie el valor del Label de la instancia de FrmMostrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarNombreDelegate.Invoke(txtNombre.Text);
        }
    }
}
