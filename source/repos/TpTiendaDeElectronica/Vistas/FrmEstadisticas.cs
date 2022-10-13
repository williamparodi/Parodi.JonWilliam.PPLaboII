using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmEstadisticas : Form
    {
        private List<Productos> listaCompleta; //lista con productos vendidos
        private int cantidadVentas;
        private double gananciaTotal;
        private double promedioMicro;
        private double promedioMonitor;
        private double promedioGabinete;
        private double promedioPerisferico;
        private double promedioMother;
        private Productos productoMasVendidoCatMirco;

        public FrmEstadisticas(List<Productos> listaDeProductos)
        {
            InitializeComponent();
            this.listaCompleta = new List<Productos>();
            this.cantidadVentas = 0;
            this.gananciaTotal = 0;
            this.promedioMicro = 0;
            this.promedioMonitor = 0;
            this.promedioGabinete = 0;
            this.promedioPerisferico = 0;
            this.promedioMother = 0;
            this.productoMasVendidoCatMirco = new Productos();
        }

        public FrmEstadisticas(List<Productos> listaDeProductos, int cantidadVentas, double gananciaTotal) : this(listaDeProductos)
        {
            this.listaCompleta = listaDeProductos;
            this.cantidadVentas = cantidadVentas;
            this.txt_CantidadVentas.Text = cantidadVentas.ToString();
            this.gananciaTotal += gananciaTotal;
            this.txt_GananciasTotales.Text = this.gananciaTotal.ToString();

            this.promedioMicro = PromedioMicroProcesador(listaDeProductos);
            this.promedioGabinete = PromedioGabinete(listaDeProductos);
            this.promedioMonitor = PromedioMonitor(listaDeProductos);
            this.promedioPerisferico = PromedioPerisfericos(listaDeProductos);
            this.promedioMother = PromedioMother(listaDeProductos);

            this.txt_PromedioMirco.Text = this.promedioMicro.ToString();
            this.txt_PromedioGabinete.Text = this.promedioGabinete.ToString();
            this.txt_PromedioMonitor.Text = this.promedioMonitor.ToString();
            this.txt_PromedioPerisferico.Text = this.promedioPerisferico.ToString();
            this.txt_PromedioMother.Text = this.promedioMother.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(listaCompleta, cantidadVentas, gananciaTotal);
            frmLogin.Show();
            this.Close();
        }


        public double PromedioMicroProcesador(List<Productos> listaProductos)
        {
            double acumulador = 0;
            int cantidad = 0;
            double promedio = 0;

            if (listaProductos is not null)
            {
                foreach (Productos producto in listaProductos)
                {
                    if (producto.Categoria == ECategorias.Microprocesador)
                    {
                        cantidad++;
                        acumulador += producto.Precio;
                    }
                }
                if (cantidad > 0)
                {
                    promedio = acumulador / cantidad;
                }

            }

            return promedio;
        }

        public double PromedioGabinete(List<Productos> listaProductos)
        {
            double acumulador = 0;
            int cantidad = 0;
            double promedio = 0;

            if (listaProductos is not null)
            {
                foreach (Productos producto in listaProductos)
                {
                    if (producto.Categoria == ECategorias.Gabinete)
                    {
                        cantidad++;
                        acumulador += producto.Precio;
                    }
                }
                if (cantidad > 0)
                {
                    promedio = acumulador / cantidad;
                }

            }

            return promedio;
        }

        public double PromedioMother(List<Productos> listaProductos)
        {
            double acumulador = 0;
            int cantidad = 0;
            double promedio = 0;

            if (listaProductos is not null)
            {
                foreach (Productos producto in listaProductos)
                {
                    if (producto.Categoria == ECategorias.Mother)
                    {
                        cantidad++;
                        acumulador += producto.Precio;
                    }
                }
                if (cantidad > 0)
                {
                    promedio = acumulador / cantidad;
                }
            }

            return promedio;
        }

        public double PromedioPerisfericos(List<Productos> listaProductos)
        {
            double acumulador = 0;
            int cantidad = 0;
            double promedio = 0;

            if (listaProductos is not null)
            {
                foreach (Productos producto in listaProductos)
                {
                    if (producto.Categoria == ECategorias.Perisfericos)
                    {
                        cantidad++;
                        acumulador += producto.Precio;
                    }
                }
                if (cantidad > 0)
                {
                    promedio = acumulador / cantidad;
                }
            }

            return promedio;
        }

        public double PromedioMonitor(List<Productos> listaProductos)
        {
            double acumulador = 0;
            int cantidad = 0;
            double promedio = 0;

            if (listaProductos is not null)
            {
                foreach (Productos producto in listaProductos)
                {
                    if (producto.Categoria == ECategorias.Monitor)
                    {
                        cantidad++;
                        acumulador += producto.Precio;
                    }
                }
                if (cantidad > 0)
                {
                    promedio = acumulador / cantidad;
                }

            }

            return promedio;
        }

        public void CalcularTodosLosPromedios(List<Productos> listaProductos, double promMicro,
            double promMonitor, double promGabinete, double promPerisferico, double promMother)
        {
            if (listaProductos is not null)
            {
                foreach (Productos producto in listaProductos)
                {
                    switch (producto.Categoria)
                    {
                        case ECategorias.Monitor:
                            promMonitor = PromedioMonitor(listaProductos);
                            break;
                        case ECategorias.Gabinete:
                            promGabinete = PromedioGabinete(listaProductos);
                            break;
                        case ECategorias.Microprocesador:
                            promMicro = PromedioMicroProcesador(listaProductos);
                            break;
                        case ECategorias.Perisfericos:
                            promPerisferico = PromedioPerisfericos(listaProductos);
                            break;
                        case ECategorias.Mother:
                            promMother = PromedioMother(listaProductos);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
    /*
    public int ProductoMasVendidoCatMicro(List<Productos> listaProductos)
    {
        var query = listaProductos.GroupBy(x => x)
                                   .Where(x => x.Count() > 1)
                                   .Select(x => x)
                                   .ToList();

    }
    */


}




