using Entidades.Producto;
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
    public partial class IDEVStudioUIProducto : UserControl
    {
        E_ProductoProveedor productoProveedor;
        bool focus;
        public E_ProductoProveedor ProductoProveedor { get => productoProveedor; set => productoProveedor = value; }

        public IDEVStudioUIProducto(E_ProductoProveedor productoProveedor)
        {
            InitializeComponent();
            this.productoProveedor = productoProveedor;
            RenderizarValores();
        }
        public IDEVStudioUIProducto()
        {
            InitializeComponent();
            RenderizarSinValores();
        }

        void RenderizarValores()
        {
            focus = true;
            txtNombre.Text = productoProveedor.Producto.Producto;
            txtCodigo.Text = productoProveedor.Producto.Codigo;
            txtProveedor.Text = productoProveedor.Proveedor.Empresa;
            txtStock.Text = productoProveedor.Stock.ToString();
            txtPrecioC.Text = "$ " + productoProveedor.PrecioCompra;
            txtPrecioV.Text = "$ " + productoProveedor.PrecioVenta;
            txtCategoria.Text = productoProveedor.Producto.SubCategoria.SubCategoria;

            btnModificar.MouseEnter += _MouseEnter;
            btnModificar.MouseLeave += _MouseLeave;           
            btnEliminar.MouseEnter += _MouseEnter;
            btnEliminar.MouseLeave += _MouseLeave;
        }
        void RenderizarSinValores()
        {
            focus = false;
            txtNombre.Text = "Producto";
            txtCodigo.Text = "Código";
            txtProveedor.Text = "Proveeedor";
            txtStock.Text = "Stock";
            txtPrecioC.Text = "Precio C";
            txtPrecioV.Text = "Precio V";
            txtCategoria.Text = "Categoría";

            txtNombre.ForeColor = Color.FromArgb(90, 215, 255);
            txtCodigo.ForeColor = Color.FromArgb(90, 215, 255);
            txtProveedor.ForeColor = Color.FromArgb(90, 215, 255);
            txtStock.ForeColor = Color.FromArgb(90, 215, 255);
            txtPrecioC.ForeColor = Color.FromArgb(90, 215, 255);
            txtPrecioV.ForeColor = Color.FromArgb(90, 215, 255);
            txtCategoria.ForeColor = Color.FromArgb(90, 215, 255);

            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control parent = ((Control)sender).Parent;
            parent.Padding = new Padding(0, 0, 0, 0);
            Reproductor.Play(TypeSound.Enter);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control parent = ((Control)sender).Parent;
            parent.Padding = new Padding(2, 2, 2, 2);
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

        private void IDEVStudioUIProducto_Enter(object sender, EventArgs e)
        {
            Reproductor.Play(TypeSound.Enter);
        }
    }
}
