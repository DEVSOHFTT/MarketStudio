using Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Producto
{
    public class E_ProductoProveedor
    {
        int id;
        E_Producto producto;
        E_Proveedor proveedor;
        double stock;
        double precioCompra;
        double precioVenta;

        public E_ProductoProveedor(int id, E_Producto producto, E_Proveedor proveedor, double stock, double precioCompra, double precioVenta)
        {
            this.id = id;
            this.producto = producto;
            this.proveedor = proveedor;
            this.stock = stock;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
        }

        public E_ProductoProveedor()
        {
            this.id = 0;
            this.producto = new E_Producto();
            this.proveedor = new E_Proveedor();
            this.stock = 0;
            this.precioCompra = 0;
            this.precioVenta = 0;
        }

        public int Id { get => id; set => id = value; }
        public E_Producto Producto { get => producto; set => producto = value; }
        public E_Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public double Stock { get => stock; set => stock = value; }

        public override string ToString()
        {
            string pp = proveedor.Empresa + "/ " + producto.Producto + ": " + producto.Codigo + " [ ";
            return pp;
        }
    }
}
