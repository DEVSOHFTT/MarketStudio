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

namespace IDEVStudioUI.Controls
{
    public partial class IDEVStudioUIRegVenta : UserControl
    {
        E_DetalleVenta detalleVenta;
        bool focus;
        public IDEVStudioUIRegVenta(E_DetalleVenta detalleVenta)
        {
            InitializeComponent();
            this.detalleVenta = detalleVenta;
            RenderizarConValores();
        }

        public IDEVStudioUIRegVenta()
        {
            InitializeComponent();
            this.detalleVenta = new E_DetalleVenta();
            RenderizarSinValores();
        }

        public E_DetalleVenta DetalleVenta { get => detalleVenta; set => detalleVenta = value; }

        void RenderizarConValores()
        {
            focus = true;
            txtFecha.Text = detalleVenta.Venta.Fecha.ToShortDateString();
            txtInteres.Text = "$ " + detalleVenta.Interes;
            txtDescuento.Text = "$ " + detalleVenta.Descuento;
            txtMonto.Text = "$ " + detalleVenta.MontoTotal();
            txtUsuario.Text = detalleVenta.Venta.Empleado.Usuario.Usuario;

            btnVer.MouseEnter += _MouseEnter;
            btnVer.MouseLeave += _MouseLeave;
        }        
        void RenderizarSinValores()
        {
            focus = false;
            txtFecha.Text = "FECHA";
            txtInteres.Text = "INTERES";
            txtDescuento.Text = "DESCUENTO";
            txtMonto.Text = "TOTAL";
            txtUsuario.Text = "USUARIO";
            pnlBtnVer.Visible = false;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control parent = ((Control)sender).Parent;
            parent.Padding = new Padding(4, 4, 4, 4);
            Reproductor.Play(TypeSound.Enter);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control parent = ((Control)sender).Parent;
            parent.Padding = new Padding(6, 6, 6, 6);
        }

        private void _MouseEnter(object sender, EventArgs e)
        {
            if (focus)
            {
                foreach (Control c in this.Controls)
                {
                    c.BackColor = Color.FromArgb(35, 135, 195);
                    foreach (Control cc in c.Controls)
                    {
                        cc.BackColor = Color.FromArgb(35, 135, 195);
                        foreach (Control ccc in cc.Controls)
                        {
                            ccc.BackColor = Color.FromArgb(35, 135, 195);
                        }
                    }
                }
            }
        }
        private void _MouseLeave(object sender, EventArgs e)
        {
            if (focus)
            {
                foreach (Control c in this.Controls)
                {
                    c.BackColor = Color.FromArgb(85, 90, 110);
                    foreach (Control cc in c.Controls)
                    {
                        cc.BackColor = Color.FromArgb(85, 90, 110);
                        foreach (Control ccc in cc.Controls)
                        {
                            ccc.BackColor = Color.FromArgb(85, 90, 110);
                        }
                    }
                }
            }
        }

        private void IDEVStudioUIRegVenta_Enter(object sender, EventArgs e)
        {
            Reproductor.Play(TypeSound.Enter);
        }
    }
}
