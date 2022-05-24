using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
namespace PrincipalFormComiqueria
{
    public partial class FormPrincipal : Form
    {
        private Comiqueria comiqueria;
        private Dictionary<Guid, string> listaProductos;
        //Utilice este campo para acceder al producto seleccionado actualmente. 
        private Producto productoSeleccionado;
        /// <summary>
        /// Constructor. No modificar el código. 
        /// </summary>
        /// <param name="comiqueria"></param>
        public FormPrincipal()
        {
            InitializeComponent();
            this.comiqueria = new Comiqueria();
            //Productos
            Producto producto1 = new Comic("AMAZING SPIDER-MAN 01: SUERTE DE ESTAR VIVO", 5, 560.00, "Dan Slott", Comic.TipoComic.Occidental);
            Producto producto2 = new Figura("DC FIGURAS 29: STARFIRE", 2, 650.00, 29.00);
            Producto producto3 = new Figura(1, 349.58, 20);
            producto3.Stock = -2; //No debería cambiar el stock. 
            Producto producto4 = new Comic("AKIRA 01 (EDICION CON SOBRECUBIERTA)", 10, 800.00, "KATSUHIRO OTOMO", Comic.TipoComic.Oriental);
            producto4.Stock = 5; //El stock debería ser 5. 
            Producto producto5 = new Figura(3, 649.58, 20);

            this.comiqueria += producto1;
            this.comiqueria += producto2;
            this.comiqueria += producto3;
            this.comiqueria += producto4;

            //No debería agregar
            this.comiqueria += producto5;

            //Sobrecargas de vender. 
            this.comiqueria.Vender(producto1);
            this.comiqueria.Vender(producto4, 2);

            this.listaProductos = this.comiqueria.ListarProductos();
            this.lbxListaVentas.Text = this.comiqueria.ListarVentas();
        }

        private void InitializeComponent()
        {
            this.lbxListaProductos = new System.Windows.Forms.ListBox();
            this.lbxProducto = new System.Windows.Forms.ListBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.lbxListaVentas = new System.Windows.Forms.ListBox();
            this.lbListaDeVentas = new System.Windows.Forms.Label();
            this.lbListaProductos = new System.Windows.Forms.Label();
            this.gbxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxListaProductos
            // 
            this.lbxListaProductos.FormattingEnabled = true;
            this.lbxListaProductos.ItemHeight = 15;
            this.lbxListaProductos.Location = new System.Drawing.Point(26, 30);
            this.lbxListaProductos.Name = "lbxListaProductos";
            this.lbxListaProductos.Size = new System.Drawing.Size(347, 334);
            this.lbxListaProductos.TabIndex = 0;
            // 
            // lbxProducto
            // 
            this.lbxProducto.FormattingEnabled = true;
            this.lbxProducto.ItemHeight = 15;
            this.lbxProducto.Location = new System.Drawing.Point(485, 193);
            this.lbxProducto.Name = "lbxProducto";
            this.lbxProducto.Size = new System.Drawing.Size(440, 169);
            this.lbxProducto.TabIndex = 1;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(55, 56);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnVender);
            this.gbxAcciones.Location = new System.Drawing.Point(485, 26);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(440, 149);
            this.gbxAcciones.TabIndex = 3;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // lbxListaVentas
            // 
            this.lbxListaVentas.FormattingEnabled = true;
            this.lbxListaVentas.ItemHeight = 15;
            this.lbxListaVentas.Location = new System.Drawing.Point(26, 408);
            this.lbxListaVentas.Name = "lbxListaVentas";
            this.lbxListaVentas.Size = new System.Drawing.Size(899, 289);
            this.lbxListaVentas.TabIndex = 4;
            // 
            // lbListaDeVentas
            // 
            this.lbListaDeVentas.AutoSize = true;
            this.lbListaDeVentas.Location = new System.Drawing.Point(26, 381);
            this.lbListaDeVentas.Name = "lbListaDeVentas";
            this.lbListaDeVentas.Size = new System.Drawing.Size(84, 15);
            this.lbListaDeVentas.TabIndex = 5;
            this.lbListaDeVentas.Text = "Lista de Ventas";
            // 
            // lbListaProductos
            // 
            this.lbListaProductos.AutoSize = true;
            this.lbListaProductos.Location = new System.Drawing.Point(26, 13);
            this.lbListaProductos.Name = "lbListaProductos";
            this.lbListaProductos.Size = new System.Drawing.Size(104, 15);
            this.lbListaProductos.TabIndex = 6;
            this.lbListaProductos.Text = "Lista de Productos";
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(969, 718);
            this.Controls.Add(this.lbListaProductos);
            this.Controls.Add(this.lbListaDeVentas);
            this.Controls.Add(this.lbxListaVentas);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.lbxProducto);
            this.Controls.Add(this.lbxListaProductos);
            this.Name = "FormPrincipal";
            this.Text = "La Comiqueria";
            this.gbxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Manejador del evento Load del formulario. Inicializará el list box de productos. NO MODIFICAR.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.lbxListaProductos.DataSource = new BindingSource(this.lbxListaProductos, null);
            this.lbxListaProductos.DisplayMember = "Value";
            this.lbxListaProductos.ValueMember = "Key";
        }
        /// <summary>
        /// Manejador del evento SelectedIndexChanged del ListBox de productos. NO MODIFICAR EL CÓDIGO. 
        /// Mantendrá el campo "productoSeleccionado" actualizado con el producto seleccionado actualmente por el usuario.
        /// Y actualizará el texto del richTextBox de detalle. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid codigoProducto = ((KeyValuePair<Guid, string>)this.lbxListaProductos.SelectedItem).Key;
            this.productoSeleccionado = this.comiqueria[codigoProducto];
            this.lbxProducto.Text = this.productoSeleccionado.ToString();
        }

        /// <summary>
        /// Manejador del evento click del botón vender. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVenderClick(object sender, EventArgs e)
        {
            //Si el constructor tiene parámetros de entrada proporcionarle los argumentos que correspondan.
            //El campo "productoSeleccionado" contiene el producto actualmente seleccionado en el listBox de productos. 
            //El campo "comiqueria" contiene la instancia de la comiqueria que se está utilizando. 
            Form ventasForm = new VentasForm();
            DialogResult result = ; //Agregar código para abrir ventasForm de forma MODAL
            if (result == DialogResult.OK)
            {
                this.lbxListaVentas.Text = this.comiqueria.ListarVentas();
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
        }
    }
}
