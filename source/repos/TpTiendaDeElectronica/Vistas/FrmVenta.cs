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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void txt_Fecha_TextChanged(object sender, EventArgs e)
        {
            txt_Fecha.Text = DateTime.Now.ToString();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //int n = dtgvListaPorductos.Rows.Add();
            this.dtgvListaPorductos.DataSource = null;
            List<Productos> listadeProductos = new List<Productos>();
            Productos listaProductos = new Productos(ECategorias.Microprocesador, "Ryzen 5", 55666, 75);
            Productos listaProductos1 = new Productos(ECategorias.Mother, "Asus", 2323, 75);
            Productos listaProductos2 = new Productos(ECategorias.Gabinete, "Terma", 65652, 75);
            Productos listaProductos3 = new Productos(ECategorias.Microprocesador, "Ryzen 5", 9874, 95);

            listadeProductos.Add(listaProductos);
            listadeProductos.Add(listaProductos1);
            listadeProductos.Add(listaProductos2);
            listadeProductos.Add(listaProductos3);

            //
            Venta venta = new Venta(listadeProductos);
            Venta ventaFiltrada = new Venta();
            ventaFiltrada = venta.FiltraPorCategoria(cmb_Categorias.Text, venta);

            this.dtgvListaPorductos.DataSource = venta.ListaProductos;
            //this.dtgvListaPorductos.DataSource = ventaFiltrada.ListaProductos;
            int index = this.dtgvListaPorductos.CurrentRow.Index;
            
            

            //Limpio txt
            cmb_Categorias.Text = string.Empty;
            txt_NombreProducto.Text = string.Empty;
            txt_PrecioMaximo.Text = string.Empty;
        }
    }
}
