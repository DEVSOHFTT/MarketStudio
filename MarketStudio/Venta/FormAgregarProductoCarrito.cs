using Entidades.Persona;
using Entidades.Producto;
using Entidades.Venta;
using IDEVStudioUI.Alerts;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStudio
{
    public partial class FormAgregarProductoCarrito : Form
    {
        FormAgregarVenta frmVenta;//Formulario padre
        E_DetalleVenta detalle;//Se crea un nuevo detalle de venta con el producto seleccionado del panel anterior
        List<E_TipoPago> tiposPago;//Contiene los Metodos de pago
        E_ProductoProveedor producto;
        bool nuevo = false;
        public FormAgregarProductoCarrito()
        {
            InitializeComponent();
        }

        public FormAgregarProductoCarrito(FormAgregarVenta frmVenta, E_DetalleVenta detalle)
        {
            InitializeComponent();

            nuevo = false;

            tiposPago = new List<E_TipoPago>();

            InsertarEventos();

            this.frmVenta = frmVenta;

            this.detalle = detalle;
            this.detalle.ProductoProveedor.Stock += detalle.Cantidad;

            this.producto = detalle.ProductoProveedor;

            Renderizar();

            txtCantidad.textBox.Text = detalle.Cantidad.ToString();

            TraerTiposPago();
        }

        public FormAgregarProductoCarrito(FormAgregarVenta frmVenta, E_ProductoProveedor producto, int index)
        {
            InitializeComponent();

            nuevo = true;

            tiposPago = new List<E_TipoPago>();

            InsertarEventos();

            this.frmVenta = frmVenta;

            this.detalle = new E_DetalleVenta();
            this.detalle.Id = index;

            this.producto = producto;

            Renderizar();
            TraerTiposPago();
        }

        #region Arrastrar Formulario sin bordes
        //using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void plSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();

            if (producto != null && producto.Id > 0)
                detalle.ProductoProveedor = producto;
            else
                errores.Add("Seleccionar un producto primero.");

            double cant = ConvertirCantidad();

            if (cant > 0)
                detalle.Cantidad = cant;
            else
                errores.Add("Ingresar una cantidad.");

            detalle.Interes = CalcularInteres();
            detalle.Descuento = CalcularDescuento();
            detalle.Monto = CalcularMonto();

            if (TipoPagoSeleccionado().Id > 0)
                detalle.TipoPago = TipoPagoSeleccionado();
            else
                errores.Add("Seleccionar un método de pago.");

            if (errores.Count <= 0)
            {
                new AlertForm().ShowAlert("El producto se cargó correctamente.", TypeMessage.Check);
                frmVenta.CargarProducto(detalle, nuevo);
                Cerrar();
            }
            else
            {
                new AlertForm().ShowAlert("Error al cargar el producto.", TypeMessage.Error);
                foreach (string er in errores)
                    new AlertForm().ShowAlert(er, TypeMessage.Information);
            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        #endregion

        #region Metodos de los Botones
        void Renderizar()
        {
            txtProducto.textBox.Text = producto.Producto.Producto;
            toolTip.SetToolTip(txtProducto.textBox, "El producto seleccionado.");
            txtCodigo.textBox.Text = producto.Producto.Codigo;
            toolTip.SetToolTip(txtCodigo.textBox, "Código del producto.");
            txtStock.textBox.Text = producto.Stock.ToString();
            toolTip.SetToolTip(txtStock.textBox, "Stock disponible.");
            txtPrecioC.textBox.Text = "$ " + producto.PrecioCompra;
            toolTip.SetToolTip(txtPrecioC.textBox, "Precio de compra.");
            txtPrecioV.textBox.Text = "$ " + producto.PrecioVenta;
            toolTip.SetToolTip(txtPrecioV.textBox, "Precio de venta.");
            txtProveedor.textBox.Text = producto.Proveedor.Empresa;
            toolTip.SetToolTip(txtProveedor.textBox, "Proveedor.");
            txtCategoria.textBox.Text = producto.Producto.SubCategoria.SubCategoria;
            toolTip.SetToolTip(txtCategoria.textBox, "Categoría.");
            txtUnidadMedida.textBox.Text = producto.Producto.TipoUnidadMedida.UnidadMedida;
            toolTip.SetToolTip(txtUnidadMedida.textBox, "Unidad de medida.");

            toolTip.SetToolTip(txtCantidad.textBox, "Cantidad requerida.");
            toolTip.SetToolTip(txtInteres.textBox, "% Interés.");
            toolTip.SetToolTip(txtDescuento.textBox, "% Descuento.");
        }

        void Cerrar()
        {
            this.Close();
        }
        #endregion

        #region Consultas
        void TraerTiposPago()
        {
            tiposPago.Clear();
            tiposPago.AddRange(N_TipoPago.SelectTiposPago());

            foreach (E_TipoPago tp in tiposPago)
            {
                cboTiposPago.Items.Add(tp.TipoPago);
            }

            if (tiposPago.Count > 0)
            {
                cboTiposPago.SelectedIndex = 0;
            }
        }
        #endregion

        #region Eventos
        void InsertarEventos()
        {
            txtCantidad.textBox.KeyPress += ValidarNumeros_KeyPress;
            txtCantidad.textBox.TextChanged += ValidarStock_TextChanged;
            txtCantidad.textBox.Enter += ValidarNumeros_Enter;
            txtCantidad.textBox.Leave += ValidarNumeros_Leave;

            txtInteres.textBox.TextChanged += ValidarStock_TextChanged;
            txtInteres.textBox.KeyPress += ValidarNumeros_KeyPress;
            txtInteres.textBox.Enter += ValidarNumeros_Enter;
            txtInteres.textBox.Leave += ValidarNumeros_Leave;

            txtDescuento.textBox.TextChanged += ValidarStock_TextChanged;
            txtDescuento.textBox.KeyPress += ValidarNumeros_KeyPress;
            txtDescuento.textBox.Enter += ValidarNumeros_Enter;
            txtDescuento.textBox.Leave += ValidarNumeros_Leave;
        }
        private void ValidarNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctrl = sender as Control;

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar.Equals('.'))
            {
                if (ctrl != null)
                {
                    if (ctrl.Text.Contains('.'))
                    {
                        if (e.KeyChar.Equals('.'))
                            e.Handled = true;
                        else if (Char.IsDigit(e.KeyChar))
                        {
                            bool b = false;
                            int c = 0;
                            for (int i = 0; i < ctrl.Text.Length; i++)
                            {
                                if (ctrl.Text[i].Equals('.'))
                                    b = true;

                                if (b)
                                    c++;
                            }

                            if (c <= 2)
                                e.Handled = false;
                            else
                                e.Handled = true;
                        }
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
                //notify.ShowBalloonTip(500, "Market Studio", "solo números, para decimales usar punto(.)", ToolTipIcon.Info);
            }
        }
        private void ValidarStock_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl.Text != "")
            {
                if (ValidarStock() <= 0)
                {
                    txtCantidad.textBox.Text = producto.Stock.ToString();
                    txtStock.textBox.Text = "0";
                }
                else
                {
                    txtStock.textBox.Text = ValidarStock().ToString();
                }

                lblTotal.Text = "$ " + Math.Round((CalcularMonto() + CalcularInteres() - CalcularDescuento()), 2);
            }
        }

        string auxtextbox = "";
        private void ValidarNumeros_Enter(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            auxtextbox = ctrl.Text;
            ctrl.Text = "";
        }

        private void ValidarNumeros_Leave(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            string txt = "";
            if (ctrl.Text != "")
            {
                for (int i = 0; i < ctrl.Text.Length; i++)
                {
                    if (Char.IsDigit(ctrl.Text[i]) || Char.IsPunctuation(ctrl.Text[i]))
                    {
                        txt += ctrl.Text[i];
                    }
                }
                txt.Replace('.', ',');
            }
            else
            {
                txt = auxtextbox;
            }

            ctrl.Text = txt;
        }
        #endregion

        #region Metodos de los Eventos
        double ValidarStock()
        {
            double cantidad = 0;
            try
            {
                cantidad = Convert.ToDouble(txtCantidad.textBox.Text.Replace('.', ','));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! :" + e.Message);
            }
            return Math.Round(producto.Stock - cantidad,2);
        }
        double ConvertirCantidad()
        {
            double cant = 0;
            try
            {
                cant = Convert.ToDouble(txtCantidad.textBox.Text.Replace('.', ','));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! :" + e.Message);
            }
            return Math.Round(cant,2);
        }
        double CalcularMonto()
        {
            double cant = ConvertirCantidad();
            double monto = 0;

            switch (producto.Producto.TipoUnidadMedida.UnidadMedida)
            {
                case "unidad":
                    monto = cant * producto.PrecioVenta;
                    break;
                case "decena":
                    monto = cant * producto.PrecioVenta / 10;
                    break;
                case "docena":
                    monto = cant * producto.PrecioVenta / 12;
                    break;
                case "centena":
                    monto = cant * producto.PrecioVenta / 100;
                    break;
                case "litro":
                    monto = cant * producto.PrecioVenta;
                    break;
                case "ml":
                    monto = cant * producto.PrecioVenta / 1000;
                    break;
                case "cc":
                    monto = cant * producto.PrecioVenta;
                    break;
                case "kg":
                    monto = cant * producto.PrecioVenta;
                    break;
                case "gramo":
                    monto = cant * producto.PrecioVenta / 100;
                    break;
                case "mg":
                    monto = cant * producto.PrecioVenta / 1000;
                    break;
                case "metro":
                    monto = cant * producto.PrecioVenta;
                    break;
                case "centimetro":
                    monto = cant * producto.PrecioVenta / 100;
                    break;
                case "mm":
                    monto = cant * producto.PrecioVenta / 1000;
                    break;
                case "m2":
                    monto = cant * producto.PrecioVenta;
                    break;
                case "metro lineal":
                    monto = cant * producto.PrecioVenta;
                    break;
                default:
                    monto = cant * producto.PrecioVenta;
                    break;
            }

            return Math.Round(monto,2);
        }
        double CalcularInteres()
        {
            double interes = 0;
            double monto = CalcularMonto();
            try
            {
                interes = Convert.ToDouble(txtInteres.textBox.Text.Replace('.', ','));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! :" + e.Message);
            }
            interes = interes > 0 ? (monto * (interes / 100)) : 0;
            lblInteres.Text = "$ " + interes;
            return interes;
        }
        double CalcularDescuento()
        {
            double descuento = 0;
            double monto = CalcularMonto();
            try
            {
                descuento = Convert.ToDouble(txtDescuento.textBox.Text.Replace('.', ','));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! :" + e.Message);
            }
            descuento = descuento > 0 ? (monto * (descuento / 100)) : 0;
            lblDescuento.Text = "$ " + descuento;
            return descuento;
        }
        E_TipoPago TipoPagoSeleccionado()
        {
            E_TipoPago t = new E_TipoPago();
            if (cboTiposPago.SelectedItem != null)
            {
                foreach (E_TipoPago tp in tiposPago)
                {
                    if (cboTiposPago.SelectedItem.Equals(tp.TipoPago))
                        t = tp;
                }
            }
            return t;
        }
        #endregion
    }
}
