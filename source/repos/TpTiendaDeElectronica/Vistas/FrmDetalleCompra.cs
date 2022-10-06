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

namespace Vistas
{
    public partial class FrmDetalleCompra : Form
    {
        public bool confirma;
        public FrmDetalleCompra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crea un string con los datos del producto de la lista con el detalle de compra
        /// </summary>
        /// <param name="listaFiltrada"></param>
        /// <param name="precio"></param>
        public FrmDetalleCompra(List<Productos> listaFiltrada,string precio) : this()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listado de Productos : ");
            foreach(Productos p in listaFiltrada)
            {
                sb.AppendLine(p.MostrarProducto());
            }
            sb.AppendLine($"Precio Total :{precio}");
            
            this.lbl_ListaProductos.Text = sb.ToString();
        }
        
        /// <summary>
        /// Al apretar el boton aceptar genera un mensaje de venta exitosa y esconde la visibilidad del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("Venta exitosa!");
            sb.AppendLine("Factura guardada");
            MessageBox.Show(sb.ToString(), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.confirma = true;
            this.Hide();
        }

        /// <summary>
        /// Al apretar el boton cancelar muestra un mensaje de venta cancelada y esconde la visibilidad del form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("Venta cancelada");
            MessageBox.Show(sb.ToString(), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.confirma = false;
            this.Hide();
        }
    }
}
