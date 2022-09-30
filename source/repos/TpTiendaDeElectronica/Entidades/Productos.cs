using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        protected ECategorias categoria;
        protected string nombre;
        protected double precio;
        protected int cantidad;

        public Productos()
        {
            this.nombre = "Sin nombre";
            this.precio = 0;
            this.cantidad = 0;
            this.categoria = ECategorias.SinCategoria;
        }

        public Productos(ECategorias categoria,string nombre, double precio,int cantidad) : this()
        {
            this.categoria = categoria;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public ECategorias Categoria
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
            sb.Append($"Categoria : {this.categoria} Nombre : {this.nombre} Precio : {this.precio}");
            return sb.ToString();

        }

        
        


    }
}
