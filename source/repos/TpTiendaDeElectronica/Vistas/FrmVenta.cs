using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmVenta : Form
    {
        private List<Productos> listaDeProductos = new List<Productos>();
        private List<Productos> listaFiltrada = new List<Productos>();
        private Venta ventaFiltrada = new Venta();
        private AdminitradorStock adminitradorStock = new AdminitradorStock();
        private int fila = 0;

        public FrmVenta()
        {
            InitializeComponent();
            this.txt_Fecha.Text = DateTime.Now.ToString();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.listaDeProductos = adminitradorStock.HarcodearLista();
            this.dtgvListaPorductos.DataSource = null;
            this.cmb_FormaDePago.SelectedIndex = 0;
        }

        private void cmb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminitradorStock adminitrador = new AdminitradorStock(listaDeProductos);
            this.adminitradorStock.ListaDeProductos = adminitrador.FiltrarCategoria(cmb_Categorias.Text);
            this.dtgvListaPorductos.DataSource = adminitradorStock.ListaDeProductos;
        }

        private void dtgvListaPorductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.fila = e.RowIndex;
            if (fila != -1)
            {
                this.listaFiltrada.Add(adminitradorStock.ListaDeProductos[fila]);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.dtgv_CarroDeCompras.DataSource = null;
            this.dtgv_CarroDeCompras.DataSource = listaFiltrada;
            this.txt_PrecioTotal.Text = ventaFiltrada.CalcularPago(cmb_FormaDePago.Text, listaFiltrada).ToString();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            dtgv_CarroDeCompras.Columns.Clear();
            this.listaFiltrada.Clear();
            this.txt_PrecioTotal.Text = string.Empty;
        }

        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("No hay stock suficiente");

            if (ventaFiltrada.ConfirmaVenta(listaFiltrada) && listaFiltrada is not null)
            {
                FrmDetalleCompra frmDetalleCompra = new FrmDetalleCompra(listaFiltrada, this.txt_PrecioTotal.Text);
                frmDetalleCompra.ShowDialog();
                if (frmDetalleCompra.confirma)
                {
                    ventaFiltrada.DescontarUnidad(listaDeProductos, listaFiltrada);
                    this.Show();
                    this.dtgv_CarroDeCompras.Columns.Clear();
                    this.listaFiltrada.Clear();
                    this.txt_PrecioTotal.Text = string.Empty;
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_BuscarNombre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_NombreProducto.Text))
            {
                AdminitradorStock adminitrador = new AdminitradorStock(listaDeProductos);

                this.adminitradorStock.ListaDeProductos = adminitrador.FiltrarPorNombre(txt_NombreProducto.Text);

                if (this.adminitradorStock.ListaDeProductos.Count > 0)
                {
                    this.dtgvListaPorductos.DataSource = adminitradorStock.ListaDeProductos;
                }
            }
        }

        private void cmb_FormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_PrecioTotal.Text = ventaFiltrada.CalcularPago(cmb_FormaDePago.Text, listaFiltrada).ToString();
        }
    }
}
