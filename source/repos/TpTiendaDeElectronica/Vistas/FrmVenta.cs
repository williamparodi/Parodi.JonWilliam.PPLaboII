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
            int n = dtgvListaPorductos.Rows.Add();
            List<Productos> listadeProductos = new List<Productos>();
            Productos listaProductos = new Productos(ECategorias.Microprocesador, "Ryzen 5", 55666, 75);
            listadeProductos.Add(listaProductos);
            Venta nueva = new Venta(listadeProductos);

            /*
            dtgvListaPorductos.Rows[n].Cells[0].Value = cmb_Categorias.Text;
            dtgvListaPorductos.Rows[n].Cells[1].Value = txt_NombreProducto.Text;
            dtgvListaPorductos.Rows[n].Cells[2].Value = txt_PrecioMaximo.Text;
            */
            dtgvListaPorductos.Rows[n].Cells[0].Value = nueva.Categoria.ToString();
            dtgvListaPorductos.Rows[n].Cells[1].Value = nueva.Nombre;
            dtgvListaPorductos.Rows[n].Cells[2].Value = nueva.Cantidad;
            dtgvListaPorductos.Rows[n].Cells[3].Value = $"{nueva.Precio}";


            //Limpio txt
            cmb_Categorias.Text = string.Empty;
            txt_NombreProducto.Text = string.Empty;
            txt_PrecioMaximo.Text = string.Empty;
        }
    }
}
