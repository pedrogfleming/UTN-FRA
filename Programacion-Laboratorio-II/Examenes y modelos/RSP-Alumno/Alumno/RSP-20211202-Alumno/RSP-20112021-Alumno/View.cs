using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Files;
using Excepciones;

namespace Final_20112021_Alumno
{

    public partial class View : Form
    {
        CentroDeAtencion centroDeAtencion;



        public View()
        {
            InitializeComponent();
            centroDeAtencion = new CentroDeAtencion("El chorizo loco");


            //agregar manejador para mostrar la lista de clientes en la caja.

            this.btnAtenderPrioEsp.Click += btnAtenderPrioMax_Click;


        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!centroDeAtencion.AbrirNegocio)
            {
                this.centroDeAtencion.AbrirNegocio = true;
                this.btnAbrir.Text = "Cerrar Negocio";
            }
            else
            {
                this.centroDeAtencion.AbrirNegocio = false;
                this.btnAbrir.Text = "Abrir Negocio";
                //Guardar centro de atencion

            }
        }


        //Manejador
        private void ActualizarPuestoDeAtencion()
        {

            if (puestoDeAtencion is PuestoPrioritario)
            {
                if (((PuestoPrioritario)puestoDeAtencion).Tipo == PuestoPrioritario.ETipo.ATN_ESPECIAL)
                {
                    this.lstPrioEsp.DataSource = (puestoDeAtencion.FilaClientes.ToList());
                }
                else
                {
                    this.lstPrioMax.DataSource = (puestoDeAtencion.FilaClientes.ToList());
                }
            }
            else
            {
                this.lstNoPrio.DataSource = (puestoDeAtencion.FilaClientes.ToList());
            }
        }
    }

    private void btnAtenderPrioMax_Click(object sender, EventArgs e)
    {

        MessageBox.Show(centroDeAtencion.PuestoPrioritario.AtenderClientes(), "Atendiendo Caja Max Unidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ActualizarPuestoDeAtencion(centroDeAtencion.PuestoPrioritario);


    }

    private void btnAtenderClasica_Click(object sender, EventArgs e)
    {
        MessageBox.Show(centroDeAtencion.PuestoNoPrioritario.AtenderClientes(), "Atendiendo Caja Max Unidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ActualizarPuestoDeAtencion(centroDeAtencion.PuestoNoPrioritario);
    }
}
}
