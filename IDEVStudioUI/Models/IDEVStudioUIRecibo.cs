using Entidades.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEVStudioUI.Models
{
    public partial class IDEVStudioUIRecibo : UserControl
    {
        E_DetalleVenta detalleVenta;
        public IDEVStudioUIRecibo(E_DetalleVenta detalleVenta)
        {
            InitializeComponent();
            this.detalleVenta = detalleVenta;
            RenderizarValores();
        }
        public IDEVStudioUIRecibo()
        {
            InitializeComponent();
            RenderizarDefault();
        }
        void RenderizarValores()
        {
            txtProducto.Text = detalleVenta.ProductoProveedor.Producto.Producto;
            txtCodigo.Text = detalleVenta.ProductoProveedor.Producto.Codigo;
            txtCantidad.Text = detalleVenta.Cantidad.ToString();
            txtTipoPago.Text = detalleVenta.TipoPago.TipoPago;
            txtInteres.Text ="$ " + detalleVenta.Interes;
            txtDescuento.Text = "$ " + detalleVenta.Descuento;
            txtMonto.Text = "$ " + detalleVenta.Monto;
        }

        void RenderizarDefault()
        {
            txtProducto.Text = "PRODUCTO";
            txtCodigo.Text = "CÓDIGO";
            txtCantidad.Text = "CANTIDAD";
            txtTipoPago.Text = "TIPO DE PAGO";
            txtInteres.Text = "INTERÉS";
            txtDescuento.Text = "DESCUENTO";
            txtMonto.Text = "MONTO";
        }
    }
}
