using System.Collections.Generic;

namespace Entidades
{
    public class AdminitradorStock : Venta
    {
        public AdminitradorStock(List<Productos> listaProductos) : base(listaProductos)
        {

        }

        public Productos AgregarNombre(string nombre)
        {
            Productos producto = new Productos();

            if (!string.IsNullOrEmpty(nombre))
            {
                producto.Nombre = nombre;
            }
            return producto;
        }

        public List<Productos> ListaDeProductos
        {
            get { return this.listaProductos; }
            set { this.listaProductos = value; }
        }

        public Productos AgregarCantidad(string cantidad)
        {
            Productos producto = new Productos();
            int cantidadASumar;

            if (!string.IsNullOrEmpty(nombre))
            {
                if (int.TryParse(cantidad, out cantidadASumar))
                {
                    producto.Cantidad += cantidadASumar;
                }
            }
            return producto;
        }

        public Productos AgregarPrecio(string precio)
        {
            Productos producto = new Productos();
            int precioASumar;

            if (!string.IsNullOrEmpty(nombre))
            {
                if (int.TryParse(precio, out precioASumar))
                {
                    producto.Precio = precioASumar;
                }
            }
            return producto;
        }

        public Productos AgregarDatosAProducto(string nombre, string cantidad, string precio)
        {
            Productos producto = new Productos();

            producto = AgregarNombre(nombre);
            producto = AgregarCantidad(cantidad);
            producto = AgregarPrecio(precio);

            return producto;
        }

        public void AgregarProductoAStock(Productos producto)
        {
            List<Productos> listaStock = new List<Productos>();

            if (producto is not null)
            {
                listaStock.Add(producto);

                if (listaStock is not null)
                {
                    this.listaProductos = listaStock;
                }
            }
        }


        


    }
}
