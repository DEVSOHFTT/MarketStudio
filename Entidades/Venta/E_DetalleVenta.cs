using Entidades.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Venta
{
    public class E_DetalleVenta
    {
        int id;
        E_Venta venta;
        E_ProductoProveedor productoProveedor;
        double cantidad;
        E_TipoPago tipoPago;
        double interes;
        double descuento;
        double monto;

        public E_DetalleVenta(int id, E_Venta venta, E_ProductoProveedor productoProveedor, double cantidad, E_TipoPago tipoPago, double interes, double descuento, double monto)
        {
            this.id = id;
            this.venta = venta;
            this.productoProveedor = productoProveedor;
            this.cantidad = cantidad;
            this.tipoPago = tipoPago;
            this.interes = interes;
            this.descuento = descuento;
            this.monto = monto;
        }
        public E_DetalleVenta()
        {
            this.id = 0;
            this.venta = new E_Venta();
            this.productoProveedor = new E_ProductoProveedor();
            this.cantidad = 0;
            this.tipoPago = new E_TipoPago();
            this.interes = 0;
            this.descuento = 0;
            this.monto = 0;
        }

        public int Id { get => id; set => id = value; }
        public E_Venta Venta { get => venta; set => venta = value; }
        public E_ProductoProveedor ProductoProveedor { get => productoProveedor; set => productoProveedor = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public E_TipoPago TipoPago { get => tipoPago; set => tipoPago = value; }
        public double Interes { get => interes; set => interes = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Monto { get => monto; set => monto = value; }

        public override string ToString()
        {
            string sql = "INSERT INTO DetalleVentas (idVenta, idProductoProveedor, cantidad, idTipoPago, interes, descuento, monto) " +
                         "VALUES (" + venta.Id + ", " + productoProveedor.Id + ", " + cantidad.ToString().Replace(',','.') + ", " + 
                         tipoPago.Id + ", " + interes.ToString().Replace(',', '.') + ", " + descuento.ToString().Replace(',', '.') +
                         ", " + monto.ToString().Replace(',', '.') + ");";

            return sql;
        }
        public double MontoTotal()
        {
            return monto + interes - descuento;
        }
    }
}
