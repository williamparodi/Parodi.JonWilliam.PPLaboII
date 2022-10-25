﻿using Entidades;
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
        private Productos productoMasVendidoCatGabinete;
        private Productos productoMasVendidoCatMother;
        private Productos productoMasVendidoCatPerisfericos;
        private Productos productoMasVendidoCatMonitor;

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
            this.productoMasVendidoCatGabinete = new Productos();
            this.productoMasVendidoCatMother = new Productos();
            this.productoMasVendidoCatPerisfericos = new Productos();
            this.productoMasVendidoCatMonitor = new Productos();
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

            MuestraMasVendidosTag(listaDeProductos);
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

        public Productos SacaProdMasVendioCatMirco(List<Productos> listaProducto)
        {
            
            List<Productos> lista2 = new List<Productos>();
            Productos producto = new Productos();

            foreach (Productos p in listaProducto)
            {
                if (p.Categoria == ECategorias.Microprocesador)
                {
                    lista2.Add(p);
                }
            }


            if (lista2.Count > 0)
            {
                lista2.GroupBy(x => x);
                producto = lista2.First();
            }

            return producto;
        }

        public Productos SacaProdMasVendioCatGabinte(List<Productos> listaProducto)
        {
            List<Productos> lista2 = new List<Productos>();
            Productos producto = new Productos();

            foreach (Productos p in listaProducto)
            {
                if (p.Categoria == ECategorias.Gabinete)
                {
                    lista2.Add(p);
                }
            }


            if (lista2.Count > 0)
            {
                lista2.GroupBy(x => x);
                producto = lista2.First();
            }

            return producto;
        }

        public Productos SacaProdMasVendioMother(List<Productos> listaProducto)
        {
            List<Productos> lista2 = new List<Productos>();
            Productos producto = new Productos();

            foreach (Productos p in listaProducto)
            {
                if (p.Categoria == ECategorias.Mother)
                {
                    lista2.Add(p);
                }
            }

            if (lista2.Count > 0)
            {
                lista2.GroupBy(x => x);
                producto = lista2.First();
            }

            return producto;
        }

        public Productos SacaProdMasVendioCatMonitor(List<Productos> listaProducto)
        {

            List<Productos> lista2 = new List<Productos>();
            Productos producto = new Productos();

            foreach (Productos p in listaProducto)
            {
                if (p.Categoria == ECategorias.Monitor)
                {
                    lista2.Add(p);
                }
            }


            if (lista2.Count > 0)
            {
                lista2.GroupBy(x => x);
                producto = lista2.First();
            }

            return producto;
        }

        public Productos SacaProdMasVendioCatPerisfericos(List<Productos> listaProducto)
        {
            List<Productos> lista2 = new List<Productos>();
            Productos producto = new Productos();

            foreach (Productos p in listaProducto)
            {
                if (p.Categoria == ECategorias.Perisfericos)
                {
                    lista2.Add(p);
                }
            }

            if (lista2.Count > 0)
            {
                lista2.GroupBy(x => x);
                producto = lista2.First();
            }

            return producto;
        }

        public void MuestraMasVendidosTag(List<Productos> listaProductos)
        {
            List<Productos> listaMasVendido = new List<Productos>();
            List<Productos> auxLista = new List<Productos>();
            if (listaProductos is not null)
            {
                productoMasVendidoCatMonitor = SacaProdMasVendioCatMonitor(listaProductos);
                productoMasVendidoCatGabinete = SacaProdMasVendioCatGabinte(listaProductos);
                productoMasVendidoCatMirco = SacaProdMasVendioCatMirco(listaProductos);
                productoMasVendidoCatPerisfericos = SacaProdMasVendioCatPerisfericos(listaProductos);
                productoMasVendidoCatMother = SacaProdMasVendioMother(listaProductos);
                auxLista.Add(productoMasVendidoCatMonitor);
                auxLista.Add(productoMasVendidoCatGabinete);
                auxLista.Add(productoMasVendidoCatMirco);
                auxLista.Add(productoMasVendidoCatPerisfericos);
                auxLista.Add(productoMasVendidoCatMother);

                foreach(Productos p in auxLista)
                {
                    if(p.Cantidad >0)
                    {
                        listaMasVendido.Add(p);
                    }
                }

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listaMasVendido;

            }

        }
    }
}




