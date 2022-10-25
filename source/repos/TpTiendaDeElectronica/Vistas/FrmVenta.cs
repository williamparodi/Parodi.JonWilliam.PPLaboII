using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmVenta : Form
    {
        private List<Productos> listaDeProductos = new List<Productos>();
        private List<Productos> listaFiltrada = new List<Productos>();
        static List<Productos> listaCompleta = new List<Productos>();
        static List<Productos> listaActualizada = new List<Productos>();
        public List<Productos> listaDeCarro = new List<Productos>();
        static List<string> listaFacturas = new List<string>();
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
                //AgregarAlCarro(adminitradorStock.ListaDeProductos[fila]);
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
           
            if (ventaFiltrada.ConfirmaVenta(listaFiltrada) && listaFiltrada is not null && listaFiltrada.Count > 0)// aca agregar agrgar count >0
            {
                FrmDetalleCompra frmDetalleCompra = new FrmDetalleCompra(listaFiltrada, this.txt_PrecioTotal.Text,listaFacturas);
                Cliente cliente = new Cliente();
                frmDetalleCompra.ShowDialog();

                if (frmDetalleCompra.confirma)
                {
                    ventaFiltrada.DescontarUnidad(listaDeProductos, listaFiltrada);
                    this.gananciaTotal += double.Parse(this.txt_PrecioTotal.Text);
                    cantidadVentas++;
                    AgregaAListaCompleta(listaFiltrada);
                    listaActualizada = listaDeProductos;
                    if(cliente.ValidaDatosCliente(txt_NombreCliente.Text,txt_Apellido.Text,txt_Dni.Text,txt_Telefono.Text))
                    {
                        listaFacturas.Add(Factura.CrearFactura(listaFiltrada, cliente, DateTime.Parse(txt_Fecha.Text)));
                    }
                    else
                    {
                        MessageBox.Show("Datos cliente erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    FrmEstadisticas frmEstadisticas = new FrmEstadisticas(listaCompleta, cantidadVentas, gananciaTotal);
                    this.Show();
                    this.dtgv_CarroDeCompras.Columns.Clear();
                    this.listaFiltrada.Clear();
                    this.txt_PrecioTotal.Text = string.Empty;
                    this.txt_Fecha.Text = DateTime.Now.ToString(); 
                }
                else
                {
                    this.Show();
                    this.dtgv_CarroDeCompras.Columns.Clear();
                    this.listaFiltrada.Clear();
                    this.txt_PrecioTotal.Text = string.Empty;
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
                    listaCompleta.Add(prod);
                }
            }
        }

        private void btn_SalirAlLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(listaCompleta, cantidadVentas, gananciaTotal,listaActualizada);
            this.Close();
            frmLogin.Show();
        }
        
        private void AgregarAlCarro(Productos producto)
        {
            if (this.listaDeCarro.Contains(producto))
            {
                foreach(Productos p in this.listaDeCarro)
                {
                    if(p.Nombre == producto.Nombre)
                    {
                        p.Cantidad++;
                        p.Precio += producto.Precio;
                    }
                    
                }
            }
            else
            {
                producto.Cantidad = 1;
                this.listaDeCarro.Add(producto);
            }

        }
       
       


    }
}

       
