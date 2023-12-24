using Dominio;
using Entidades.Producto;
using Entidades.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_DetalleVenta
    {
        internal static List<E_DetalleVenta> detalleVentas = new List<E_DetalleVenta>();

        public static List<E_DetalleVenta> SelectDetalleVentas(string sql)
        {
            D_DetalleVenta dominio = new D_DetalleVenta();
            detalleVentas.Clear();
            dominio.Select(sql != "" ? "SELECT * FROM SelectAllDetalleVentas " + sql : "SELECT * FROM SelectAllDetalleVentas");
            while (dominio.Reader.Read())
            {
                E_DetalleVenta dv = new E_DetalleVenta();
                if (!dominio.Reader.IsDBNull(0))
                {
                    dv.Id = dominio.Reader.GetInt32(0);
                }
                //Sector Ventas
                if (!dominio.Reader.IsDBNull(1))
                {
                    dv.Venta.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    dv.Venta.Fecha = dominio.Reader.GetDateTime(2);
                }
                //Sector Empleados y Usuarios
                if (!dominio.Reader.IsDBNull(3))
                {
                    dv.Venta.Empleado.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    dv.Venta.Empleado.Usuario.Id = dominio.Reader.GetInt32(4);
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    dv.Venta.Empleado.Usuario.Usuario = dominio.Reader.GetString(5);
                }
                //Sector Productos Proveedores
                if (!dominio.Reader.IsDBNull(6))
                {
                    dv.ProductoProveedor.Id = dominio.Reader.GetInt32(6);
                }
                if (!dominio.Reader.IsDBNull(7))
                {
                    dv.ProductoProveedor.Producto.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    dv.ProductoProveedor.Producto.Producto = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    dv.ProductoProveedor.Producto.Codigo = dominio.Reader.GetString(9);
                }
                if (!dominio.Reader.IsDBNull(10))
                {
                    dv.ProductoProveedor.Proveedor.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    dv.ProductoProveedor.Proveedor.Empresa = dominio.Reader.GetString(11);
                }
                //Sector Tipo de Pago
                if (!dominio.Reader.IsDBNull(12))
                {
                    dv.TipoPago.Id = dominio.Reader.GetInt32(12);
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    dv.TipoPago.TipoPago = dominio.Reader.GetString(13);
                }
                //Sector Detalle Venta
                if (!dominio.Reader.IsDBNull(14))
                {
                    dv.Cantidad = Convert.ToDouble(dominio.Reader.GetDecimal(14));
                }
                if (!dominio.Reader.IsDBNull(15))
                {
                    dv.Interes = Convert.ToDouble(dominio.Reader.GetDecimal(15));
                }
                if (!dominio.Reader.IsDBNull(16))
                {
                    dv.Descuento = Convert.ToDouble(dominio.Reader.GetDecimal(16));
                }
                if (!dominio.Reader.IsDBNull(17))
                {
                    dv.Monto = Convert.ToDouble(dominio.Reader.GetDecimal(17));
                }

                detalleVentas.Add(dv);
            }
            dominio.Close();
            return detalleVentas;
        }
        public static List<E_DetalleVenta> SelectDetalleVentas()
        {
            D_DetalleVenta dominio = new D_DetalleVenta();
            detalleVentas.Clear();
            dominio.Select("SELECT * FROM SelectAllDetalleVentas");
            while (dominio.Reader.Read())
            {
                E_DetalleVenta dv = new E_DetalleVenta();

                if (!dominio.Reader.IsDBNull(0))
                {
                    dv.Id = dominio.Reader.GetInt32(0);
                }
                //Sector Ventas
                if (!dominio.Reader.IsDBNull(1))
                {
                    dv.Venta.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    dv.Venta.Fecha = dominio.Reader.GetDateTime(2);
                }
                //Sector Empleados y Usuarios
                if (!dominio.Reader.IsDBNull(3))
                {
                    dv.Venta.Empleado.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    dv.Venta.Empleado.Usuario.Id = dominio.Reader.GetInt32(4);
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    dv.Venta.Empleado.Usuario.Usuario = dominio.Reader.GetString(5);
                }
                //Sector Productos Proveedores
                if (!dominio.Reader.IsDBNull(6))
                {
                    dv.ProductoProveedor.Id = dominio.Reader.GetInt32(6);
                }
                if (!dominio.Reader.IsDBNull(7))
                {
                    dv.ProductoProveedor.Producto.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    dv.ProductoProveedor.Producto.Producto = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    dv.ProductoProveedor.Producto.Codigo = dominio.Reader.GetString(9);
                }
                if (!dominio.Reader.IsDBNull(10))
                {
                    dv.ProductoProveedor.Proveedor.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    dv.ProductoProveedor.Proveedor.Empresa = dominio.Reader.GetString(11);
                }
                //Sector Tipo de Pago
                if (!dominio.Reader.IsDBNull(12))
                {
                    dv.TipoPago.Id = dominio.Reader.GetInt32(12);
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    dv.TipoPago.TipoPago = dominio.Reader.GetString(13);
                }
                //Sector Detalle Venta
                if (!dominio.Reader.IsDBNull(14))
                {
                    dv.Cantidad = Convert.ToDouble(dominio.Reader.GetDecimal(14));
                }
                if (!dominio.Reader.IsDBNull(15))
                {
                    dv.Interes = Convert.ToDouble(dominio.Reader.GetDecimal(15));
                }
                if (!dominio.Reader.IsDBNull(16))
                {
                    dv.Descuento = Convert.ToDouble(dominio.Reader.GetDecimal(16));
                }
                if (!dominio.Reader.IsDBNull(17))
                {
                    dv.Monto = Convert.ToDouble(dominio.Reader.GetDecimal(17));
                }

                detalleVentas.Add(dv);
            }
            dominio.Close();
            return detalleVentas;
        }
        public static List<E_DetalleVenta> SelectTotalVentas()
        {
            D_DetalleVenta dominio = new D_DetalleVenta();
            detalleVentas.Clear();
            dominio.Select("SELECT * FROM SelectTotalVentas");
            while (dominio.Reader.Read())
            {
                E_DetalleVenta dv = new E_DetalleVenta();

                if (!dominio.Reader.IsDBNull(0))
                {
                    dv.Venta.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    dv.Venta.Fecha = dominio.Reader.GetDateTime(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    dv.Interes = Convert.ToDouble(dominio.Reader.GetDecimal(2));
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    dv.Descuento = Convert.ToDouble(dominio.Reader.GetDecimal(3));
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    dv.Monto = Convert.ToDouble(dominio.Reader.GetDecimal(4));
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    dv.Venta.Empleado.Usuario.Usuario = dominio.Reader.GetString(5);
                }

                detalleVentas.Add(dv);
            }
            dominio.Close();
            return detalleVentas;
        }
        public static E_DetalleVenta GetDetalleVenta(int idVenta)
        {
            if (detalleVentas.Count <= 0)
                SelectDetalleVentas();

            E_DetalleVenta detalleVenta = detalleVentas.Find(x => x.Venta.Id == idVenta);
            return detalleVenta;
        }

        public static bool InsertDetalles(List<E_DetalleVenta> registros)
        {
            bool ok = false;

            foreach (E_DetalleVenta d in registros)
            {
                D_DetalleVenta dominio = new D_DetalleVenta();

                if (dominio.Insert(d.ToString()))
                {
                    dominio = new D_DetalleVenta();
                    double stock = d.ProductoProveedor.Stock <= 0 ? 0 : d.ProductoProveedor.Stock;
                    ok = dominio.Update("UPDATE ProductosProveedores SET stock = " + stock.ToString().Replace(',', '.') + " WHERE id = " + d.ProductoProveedor.Id);
                }
                else
                {
                    ok = false;
                }
                Thread.Sleep(100);
            }

            return ok;
        }
    }
}
