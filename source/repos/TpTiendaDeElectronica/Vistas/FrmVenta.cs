using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Vistas
{
    public partial class FrmVenta : Form
    {
        private List<Productos> listaDeProductos = new List<Productos>();
        private List<Productos> listaFiltrada = new List<Productos>();
        private Venta ventaFiltrada = new Venta();
        private int fila = 0;
        
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

            Productos listaProductos = new Productos(ECategorias.Microprocesador, "Ryzen 5", 55666, 75);
            Productos listaProductos1 = new Productos(ECategorias.Mother, "Asus", 2323, 75);
            Productos listaProductos2 = new Productos(ECategorias.Gabinete, "Terma", 65652, 75);
            Productos listaProductos3 = new Productos(ECategorias.Microprocesador, "Ryzen 5", 9874, 95);

            this.listaDeProductos.Add(listaProductos);
            this.listaDeProductos.Add(listaProductos1);
            this.listaDeProductos.Add(listaProductos2);
            this.listaDeProductos.Add(listaProductos3);

            this.dtgvListaPorductos.DataSource = null;
            this.dtgvListaPorductos.DataSource = listaDeProductos;
            this.cmb_Categorias.SelectedIndex = 0;
            this.cmb_FormaDePago.SelectedIndex = 0;
            this.txt_Fecha.Text = DateTime.Now.ToString();

        }

        private void cmb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venta venta = new Venta(listaDeProductos);
            
            this.ventaFiltrada = venta.FiltraPorCategoria(cmb_Categorias.Text, venta);
            this.dtgvListaPorductos.DataSource = ventaFiltrada.ListaProductos;

            //Limpio txt
            /*
            cmb_Categorias.Text = string.Empty;
            txt_NombreProducto.Text = string.Empty;
            txt_PrecioMaximo.Text = string.Empty;
            */
        }

        private void dtgvListaPorductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.fila = e.RowIndex;
            if (fila != -1)
            {
                this.listaFiltrada.Add(ventaFiltrada.ListaProductos[fila]);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.dtgv_CarroDeCompras.DataSource = null;
            this.dtgv_CarroDeCompras.DataSource = listaFiltrada;
            this.txt_PrecioTotal.Text = ventaFiltrada.CalcularPago(cmb_FormaDePago.Text,listaFiltrada).ToString();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            dtgv_CarroDeCompras.Columns.Clear();
            this.listaFiltrada.Clear();
        }
        
       
        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("No hay stock suficiente");

            if(ventaFiltrada.ConfirmaVenta(listaFiltrada) && listaFiltrada is not null)
            {
                FrmDetalleCompra frmDetalleCompra = new FrmDetalleCompra(listaFiltrada,this.txt_PrecioTotal.Text);
                if(frmDetalleCompra.confirma)
                {
                    ventaFiltrada.DescontarUnidad(listaDeProductos, listaFiltrada);
                }
                frmDetalleCompra.ShowDialog();
            }
            else
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
      
    }
}
