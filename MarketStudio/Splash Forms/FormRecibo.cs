using Entidades.Venta;
using IDEVStudioUI;
using IDEVStudioUI.Models;
using Negocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MarketStudio
{
    public partial class FormRecibo : Form
    {
        Bitmap map;
        List<E_DetalleVenta> detalleVentas;
        public FormRecibo(List<E_DetalleVenta> detalleVentas)
        {
            InitializeComponent();
            this.detalleVentas = detalleVentas;
            Renderizar();
        }

        void Renderizar()
        {
            string idventa = "";
            double interes = 0;
            double descuento = 0;
            double subTotal = 0;
            string fecha = "";
            string usuario = "";

            pnlDetalles.Controls.Clear();

            foreach (var d in detalleVentas)
            {
                interes += d.Interes;
                descuento += d.Descuento;
                subTotal += d.MontoTotal();
                if (fecha == "")
                    fecha = d.Venta.Fecha.ToShortDateString();
                if (usuario == "")
                    usuario = d.Venta.Empleado.Usuario.Usuario;
                if (idventa == "")
                    idventa = d.Venta.Id.ToString();
                IDEVStudioUIRecibo r = new IDEVStudioUIRecibo(d);
                r.Dock = DockStyle.Top;
                pnlDetalles.Controls.Add(r);
            }

            lblFecha.Text = fecha;
            txtUsuario.Text = usuario;
            txtInteres.textBox.Text = "+$ " + interes;
            txtDescuento.textBox.Text = "-$ " + descuento;
            txtSubTotal.textBox.Text = "$ " + subTotal;
            txtTotal.textBox.Text = "$ " + (subTotal + interes - descuento);
            cboIvas.SelectedIndex= 0;
            lblHoraFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


            switch (idventa.Length)
            {
                case 1:
                    lblNroFactura.Text = "0000000" + idventa;
                    break;
                case 2:
                    lblNroFactura.Text = "000000" + idventa;
                    break;
                case 3:
                    lblNroFactura.Text = "00000" + idventa;
                    break;
                case 4:
                    lblNroFactura.Text = "0000" + idventa;
                    break;
                case 5:
                    lblNroFactura.Text = "000" + idventa;
                    break;
                case 6:
                    lblNroFactura.Text = "00" + idventa;
                    break;
                case 7:
                    lblNroFactura.Text = "0" + idventa;
                    break;
                default:
                    lblNroFactura.Text = idventa;
                    break;
            }


            IDEVStudioUIRecibo re = new IDEVStudioUIRecibo();
            re.Dock = DockStyle.Top;
            pnlDetalles.Controls.Add(re);

            Reproductor.Play(TypeSound.Click);
        }

        public void Imprimir()
        {
            btnCerrar.Visible = false;
            btnImprimir.Visible = false;
            cboIvas.Visible = false;

            Graphics graphics = this.CreateGraphics();
            map = new Bitmap(this.Size.Width, this.Size.Height, graphics);
            Graphics image = Graphics.FromImage(map);
            image.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog.ShowDialog();
            this.Close();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PrinterSettings.PrintFileName = "Recibo 00000001";
            e.Graphics.DrawImage(map, 0, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Close();
        }

        private void cboIvas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboIvas.SelectedIndex >= 0)
            {
                lblCondicion.Text = cboIvas.SelectedItem.ToString();
            }
        }
    }
}
