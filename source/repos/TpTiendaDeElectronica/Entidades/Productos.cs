using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        protected string categoria;
        protected EMarca marca;
        protected double precio;
        protected int cantidad;

        public Productos()
        {
            this.marca = EMarca.SinMarca;
            this.precio = 0;
            this.cantidad = 0;
            this.categoria = "Sin categoria";
        }

        public Productos(EMarca marca,string categoria, double precio,int cantidad) : this()
        {
            this.categoria = categoria;
            this.marca = marca;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public EMarca Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public static explicit operator string(Productos prod)
        {
            return (string)prod.categoria;
        }

        public static bool operator ==(Productos prod1, Productos prod2)
        {
            bool retorno = false;
            
            if(prod1 is not null && prod2 is not null)
            {
                if(prod1.categoria == prod2.categoria)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Productos prod1, Productos prod2)
        {
            return !(prod1 == prod2);
        }


        public virtual string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Categoria : {this.categoria} Marca : {this.marca} Precio : {this.precio}");
            return sb.ToString();

        }

        
        


    }
}
