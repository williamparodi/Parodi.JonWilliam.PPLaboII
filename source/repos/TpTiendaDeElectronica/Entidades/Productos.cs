using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        protected string marca;
        protected ECategorias categorias;
        protected double precio;

        public Productos()
        {
            this.marca = "Sin marca";
            this.categorias = ECategorias.SinCategoria;
            this.precio = 0;
        }

        public Productos(string marca, ECategorias categorias, double precio) : this()
        {
            this.marca = marca;
            this.categorias = categorias;
            this.precio = precio;
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public ECategorias Categorias
        {
            get { return this.categorias; }
            set { this.categorias = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

    }
}
