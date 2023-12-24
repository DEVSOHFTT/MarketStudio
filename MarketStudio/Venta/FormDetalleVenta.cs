using Entidades.Venta;
using IDEVStudioUI;
using IDEVStudioUI.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MarketStudio
{
    public partial class FormDetalleVenta : Form
    {
        List<E_DetalleVenta> detalleVentas;
        public FormDetalleVenta(List<E_DetalleVenta> detalleVentas)
        {
            InitializeComponent();
            this.detalleVentas = detalleVentas;
            Renderizar();
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
        void Renderizar()
        {
            if (detalleVentas.Count > 0)
            {
                double interes = 0;
                double descuento = 0;
                double subTotal = 0;
                string fecha = "";
                string usuario = "";

                lstProductos.Items.Clear();

                foreach (var d in detalleVentas) 
                {
                    interes += d.Interes;
                    descuento += d.Descuento;
                    subTotal += d.MontoTotal();
                    if (fecha == "")
                        fecha = d.Venta.Fecha.ToShortDateString();
                    if (usuario == "")
                        usuario = d.Venta.Empleado.Usuario.Usuario;
                    lstProductos.Items.Add(" ▸ " + d.ProductoProveedor.Producto.Producto + " (" + d.ProductoProveedor.Producto.Codigo + ")");
                }

                txtFecha.Text = fecha;
                txtUsuario.Text = usuario;
                txtInteresTotal.Text = "▴ $ " + interes;
                txtDescuentoTotal.Text = "▾ $ " + descuento;
                txtSubTotal.Text = "$ " + subTotal;
                txtTotalTotal.Text = "$ " + (subTotal + interes - descuento);

                lstProductos.SelectedIndex = 0;
            }

            Reproductor.Play(TypeSound.Click);
        }

        #region Animaciones
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Animador.ExaltarBotonLayout_MouseEnter((Control)sender);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Animador.ExaltarBotonLayout_MouseLeave((Control)sender);
        }
        #endregion

        private void lstProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex >= 0)
            {
                MostrarValores(detalleVentas.ToArray()[lstProductos.SelectedIndex]);
            }
        }

        void MostrarValores(E_DetalleVenta detalle)
        {
            txtNombre.Text = detalle.ProductoProveedor.Producto.Producto;
            txtCodigo.Text = detalle.ProductoProveedor.Producto.Codigo;
            txtCantidad.Text = detalle.Cantidad.ToString();
            txtTipoPago.Text = detalle.TipoPago.TipoPago;
            txtInteres.Text = "▴ $ " + detalle.Interes;
            txtDescuento.Text = "▾ $ " + detalle.Descuento;
            txtMonto.Text = "$ " + detalle.Monto;
            txtTotal.Text = "$ " + detalle.MontoTotal();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Imprimir).ShowDialog(this);
            new FormRecibo(detalleVentas).ShowDialog();
            if (IDEVStudioUIMessageBox.Show("¿Compartir documento?", "Compartir Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = "";
                openFileDialog.ShowDialog();
                path = openFileDialog.FileName;
                new FormEmail(path).ShowDialog();
            }
        }
    }
}
