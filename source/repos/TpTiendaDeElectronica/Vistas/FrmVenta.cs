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
        private List<Productos> listaCompleta = new List<Productos>();
        private Venta ventaFiltrada = new Venta();
        private AdminitradorStock adminitradorStock = new AdminitradorStock();
        static int cantidadVentas;
        private double gananciaTotal;
        private int fila = 0;

        /// <summary>
        /// Constructor por defecto y setea la hora al horario actual
        /// </summary>
        public FrmVenta(List<Productos> listaDeProductos)
        {
            InitializeComponent();
            this.txt_Fecha.Text = DateTime.Now.ToString();
            this.listaDeProductos = listaDeProductos;
            this.gananciaTotal = 0;
        }

        /// <summary>
        /// Setea valores al cargar el form y carga la lista harcodeada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.dtgvListaPorductos.DataSource = null;
            this.cmb_FormaDePago.SelectedIndex = 0;
        }

        /// <summary>
        /// Al seleccionar una categoria filtra y muestra en el datagrid la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminitradorStock adminitrador = new AdminitradorStock(listaDeProductos);
            this.adminitradorStock.ListaDeProductos = adminitrador.FiltrarCategoria(cmb_Categorias.Text);
            this.dtgvListaPorductos.DataSource = adminitradorStock.ListaDeProductos;
        }

        /// <summary>
        /// Al hacer click en una celda agrega ese producto a la lista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvListaPorductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.fila = e.RowIndex;
            if (fila != -1)
            {
                this.listaFiltrada.Add(adminitradorStock.ListaDeProductos[fila]);
            }
        }

        /// <summary>
        /// Al tocar el boton aceptar muestra en el datagrid de compras los items seleccionados y calcula y muestra el precio total
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.dtgv_CarroDeCompras.DataSource = null;
            this.dtgv_CarroDeCompras.DataSource = listaFiltrada;
            this.txt_PrecioTotal.Text = ventaFiltrada.CalcularPago(cmb_FormaDePago.Text, listaFiltrada).ToString();
        }

        /// <summary>
        /// Al tocar el boton borrar limpia los campos del datagrid del carro, la lista y el precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            dtgv_CarroDeCompras.Columns.Clear();
            this.listaFiltrada.Clear();
            this.txt_PrecioTotal.Text = string.Empty;
        }

        /// <summary>
        /// Al tocar aceptar la venta se fija si se cumplen las condiciones  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    this.gananciaTotal += double.Parse(this.txt_PrecioTotal.Text);
                    cantidadVentas++;
                    AgregaAListaCompleta(listaFiltrada);
                    FrmEstadisticas frmEstadisticas = new FrmEstadisticas(listaCompleta, cantidadVentas, gananciaTotal);
                    frmEstadisticas.Show();
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

        /// <summary>
        /// Al tocar el boton nombre filtra y busca si esta ese nombre en la lista y lo muestra en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Al elegir una forma de pago en el combobox de forma de pago setea el valor en el textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_FormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_PrecioTotal.Text = ventaFiltrada.CalcularPago(cmb_FormaDePago.Text, listaFiltrada).ToString();
        }

        public void AgregaAListaCompleta(List<Productos> listaProductos)
        {
            if(listaProductos is not null)
            {
                foreach(Productos prod in listaProductos)
                {
                    this.listaCompleta.Add(prod);
                }
            }
        }
      


    }
}

       
