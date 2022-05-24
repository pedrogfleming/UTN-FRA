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
    public partial class FrmPrincipal : Form
    {
        FrmMostrar formMostrar;
        FrmTestDelegados formTestDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formMostrar = new FrmMostrar();
            formTestDelegados = new FrmTestDelegados(formMostrar.ActualizarNombre); 
            formMostrar.MdiParent = this;
            formTestDelegados.MdiParent = this;
        }

        /// <summary>
        /// Cuando el usuario pulse el submenú "Test Delegados",
        /// mostrar el FrmTestDelegados de forma no-modal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTestDelegados.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMostrar.Show();
        }
    }
}
