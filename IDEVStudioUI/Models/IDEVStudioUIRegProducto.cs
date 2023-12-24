using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Producto;

namespace IDEVStudioUI.Models
{
    public partial class IDEVStudioUIRegProducto : UserControl
    {
        E_ProductoProveedor productoProveedor;
         
        public IDEVStudioUIRegProducto(E_ProductoProveedor productoProveedor)
        {
            InitializeComponent();
            this.productoProveedor = productoProveedor;
            Renderizar();
        }

        public IDEVStudioUIRegProducto()
        {
            InitializeComponent();
            this.productoProveedor = new E_ProductoProveedor();
            txtProducto.Text = "Producto";
            txtCodigo.Text = "Código";
            txtStock.Text = "Stock";
            txtPrecioCompra.Text = "Precio C";
            txtPrecioVenta.Text = "Precio V";
            btnAgregarProducto.Visible = false;
        }

        public E_ProductoProveedor ProductoProveedor { get => productoProveedor; set => productoProveedor = value; }

        public void Renderizar()
        {
            txtProducto.Text = productoProveedor.Producto.Producto;
            txtCodigo.Text = productoProveedor.Producto.Codigo;
            txtStock.Text = productoProveedor.Stock.ToString();
            txtPrecioCompra.Text = "$ " + productoProveedor.PrecioCompra;
            txtPrecioVenta.Text = "$ " + productoProveedor.PrecioVenta;

            btnAgregarProducto.MouseEnter += Button_MouseEnter;
        }
        private void _MouseEnter(object sender, EventArgs e)
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
        private void _MouseLeave(object sender, EventArgs e)
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

        private void IDEVStudioUIRegProducto_Enter(object sender, EventArgs e)
        {
            Reproductor.Play(TypeSound.Enter);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Reproductor.Play(TypeSound.Enter);
        }
    }
}
