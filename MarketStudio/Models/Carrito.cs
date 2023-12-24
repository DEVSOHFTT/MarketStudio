using Entidades.Producto;
using Entidades.Venta;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MarketStudio
{
    public class Carrito
    {
        List<E_DetalleVenta> listaProductos;

        public List<E_DetalleVenta> ListaProductos { get => listaProductos;}

        public Carrito()
        {
            listaProductos = new List<E_DetalleVenta>();
        }
        public void AgregarProducto(E_DetalleVenta detalle)
        {
            if (detalle.Id > 0)
            {
                bool existe = false;

                foreach (E_DetalleVenta d in listaProductos)
                {
                    if (d.Id == detalle.Id)
                    {
                        d.TipoPago = detalle.TipoPago;
                        d.Cantidad += detalle.Cantidad;
                        d.Interes += detalle.Interes;
                        d.Descuento += detalle.Descuento;
                        d.Monto += detalle.Monto;
                        existe = true;
                    }
                }

                if (!existe)
                {
                    listaProductos.Add(detalle);
                }
            }
        }

        public void ActualizarProducto(E_DetalleVenta detalle)
        {
            if (detalle.Id > 0)
            {
                foreach (E_DetalleVenta d in listaProductos)
                {
                    if (d.Id == detalle.Id)
                    {
                        d.TipoPago = detalle.TipoPago;
                        d.Cantidad = detalle.Cantidad;
                        d.Interes = detalle.Interes;
                        d.Descuento = detalle.Descuento;
                        d.Monto = detalle.Monto;
                    }
                }
            }
        }

        public bool QuitarProducto(int idDetalle)
        {
            bool ok = true;
            if (idDetalle > 0)
            {
                listaProductos.Remove(listaProductos.Find(x => x.Id == idDetalle));
                foreach (var d in listaProductos)
                {
                    if (d.Id == idDetalle)
                    {
                        ok = false;
                    }
                }
            }
            else
            {
                ok = false;
            }

            return ok;
        }

        public int Index(int idProducto)
        {
            int index = 0;
            bool found = false;
            foreach (var d in listaProductos)
            {
                if (d.ProductoProveedor.Id == idProducto)
                {
                    index = d.Id;
                    found = true;
                }
            }

            if (!found)
            {
                index = listaProductos.Count + 1;
            }

            return index;
        }

        public double CalcularMontoTotal()
        {
            double monto = 0;

            foreach (E_DetalleVenta d in listaProductos)
            {
                monto += d.MontoTotal();
            }

            return monto;
        }

        public double CalcularMontoPorTipo(int idTipo)
        {
            double monto = 0;

            foreach (E_DetalleVenta d in listaProductos)
            {
                if (d.TipoPago.Id == idTipo)
                {
                    monto += d.MontoTotal();
                }
            }

            return monto;
        }

        public int CalcularCantidadDetallesPorTipo(int idTipo)
        {
            int cant = 0;

            foreach (E_DetalleVenta d in listaProductos)
            {
                if (d.TipoPago.Id == idTipo)
                {
                    cant++;
                }
            }

            return cant;
        }
    }
}
