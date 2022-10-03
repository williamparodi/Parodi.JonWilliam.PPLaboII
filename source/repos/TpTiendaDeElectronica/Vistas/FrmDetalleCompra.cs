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
        private Venta venta = new Venta();
        public FrmDetalleCompra()
        {
            InitializeComponent();
        }

        private void FrmDetalleCompra_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            FrmVenta frmVenta = new FrmVenta();

            sb.AppendLine(frmVenta.MostrarListaProductos());

            //this.lbl_ListaProductos.Text = sb.ToString();
            MessageBox.Show(sb.ToString());
        }
    }
}
