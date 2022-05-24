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
namespace WinformTestSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ProductoDAO dao = new ProductoDAO();
            try
            {
                List<Producto> prods = dao.GetProductos();
                foreach (Producto item in prods)
                {
                    rtbProductos.Text += item.ToString() + '\n';
                }
            }
            catch (Exception excepcion)
            {

                MessageBox.Show(excepcion.Message);
            }

        }
    }
}
