using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades.Persona;
using Negocios;
using Entidades.Producto;
using IDEVStudioUI.Models;
using System.Threading;
using Entidades.Venta;
using IDEVStudioUI.Alerts;

namespace MarketStudio
{
    public partial class FormAgregarVenta : Form
    {
        //TABLA DE PRODUCTOS
        FormTabControl principal;
        List<E_ProductoProveedor> productosProveedores;
        E_Venta venta;
        E_Empleado empleado;
        public Carrito carrito;
        double MontoTotal = 0;
        public FormAgregarVenta(E_Empleado empleado, FormTabControl principal)
        {
            InitializeComponent();
            this.principal = principal;
            this.empleado = empleado;

            txtBuscar.textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscar.textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscar.textBox.KeyDown += BuscarProducto_KeyDown;
            txtCodigo.textBox.KeyDown += BuscarCodigo_KeyDown;

            //MostrarTotal();

            NuevaVenta();
            BuscarProductos();
        }

        public FormAgregarVenta(FormTabControl principal)
        {
            InitializeComponent();
            this.principal = principal;
            this.empleado = new E_Empleado();
            this.empleado.Id = 1;

            txtBuscar.textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscar.textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscar.textBox.KeyDown += BuscarProducto_KeyDown;
            txtCodigo.textBox.KeyDown += BuscarCodigo_KeyDown;

            //Cancelar();
            //MostrarTotal();

            NuevaVenta();
            BuscarProductos();
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

        #region ControlBox
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new AlertForm().ShowAlert("Generando nueva venta.", TypeMessage.Information);
            NuevaVenta();
            BuscarProductos();
            MostrarTotal();
        }

        void NuevaVenta()
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " hs";

            MontoTotal = 0;

            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;

            venta = new E_Venta(N_Venta.UltimaVenta(), DateTime.Now, empleado);

            lblUsuario.Text = "Usuario: " + empleado.Usuario.Usuario;

            productosProveedores = new List<E_ProductoProveedor>();
            carrito = new Carrito();

            btnFinalizar.BackColor = Color.FromArgb(35, 135, 195);
        }

        void Cancelar()
        {
            MontoTotal = 0;

            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;

            venta = new E_Venta();

            productosProveedores = new List<E_ProductoProveedor>();
            carrito = new Carrito();

            dgvProductos.Rows.Clear();
            pnlProductos.Controls.Clear();

            btnFinalizar.BackColor = Color.FromArgb(230, 65, 120);
        }

        private void AgregarProductoCarrito_Click(object sender, EventArgs e)
        {
            IDEVStudioUIRegProducto producto = ((Control)sender).Parent.Parent as IDEVStudioUIRegProducto;
            new FormAgregarProductoCarrito(this, producto.ProductoProveedor, carrito.Index(producto.ProductoProveedor.Id)).ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IDEVStudioUIMessageBox.Show("¿Cancelar la venta?", "Cancelar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cancelar();
                MostrarTotal();
                new AlertForm().ShowAlert("La venta se ha cancelado.", TypeMessage.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IDEVStudioUIRegProducto producto = ((Control)sender).Parent.Parent as IDEVStudioUIRegProducto;
            E_DetalleVenta detalle = new E_DetalleVenta();

            if (dgvProductos.SelectedCells.Count > 0)
            {
                int idDetalle = 0;

                if (dgvProductos.CurrentRow != null)
                {
                    if (dgvProductos.CurrentRow.Cells[0].Value != null)
                        idDetalle = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                    foreach (E_DetalleVenta d in carrito.ListaProductos)
                    {
                        if (d.Id == idDetalle)
                        {
                            detalle = d;
                        }
                    }
                }
            }

            if(detalle.Id > 0)
                new FormAgregarProductoCarrito(this, detalle).ShowDialog();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedCells.Count > 0)
            {
                int idDetalle = 0;
                double cantidad = 0;
                int idProducto = 0;

                if (dgvProductos.CurrentRow != null)
                {
                    if (dgvProductos.CurrentRow.Cells[0].Value != null)
                        idDetalle = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);                    
                    if (dgvProductos.CurrentRow.Cells[1].Value != null)
                        idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[1].Value);
                    if (dgvProductos.CurrentRow.Cells[5].Value != null)
                        cantidad = Convert.ToDouble(dgvProductos.CurrentRow.Cells[5].Value);

                    if (carrito.QuitarProducto(idDetalle))
                    {
                        dgvProductos.Rows.Clear();

                        foreach (E_ProductoProveedor p in productosProveedores)
                        {
                            if (p.Id == idProducto)
                            {
                                p.Stock += cantidad;

                                foreach (Control c in pnlProductos.Controls)
                                {
                                    IDEVStudioUIRegProducto pr = c as IDEVStudioUIRegProducto;
                                    if (pr != null)
                                    {
                                        if (pr.ProductoProveedor.Id == p.Id)
                                        {
                                            pr.ProductoProveedor.Stock = p.Stock;
                                            pr.Renderizar();
                                        }
                                    }
                                }
                            }
                        }

                        foreach (E_DetalleVenta d in carrito.ListaProductos)
                        {
                            dgvProductos.Rows.Add(new object[] { d.Id, d.ProductoProveedor.Id, d.ProductoProveedor.Proveedor.Empresa, d.ProductoProveedor.Producto.Producto, d.ProductoProveedor.Producto.Codigo, d.Cantidad, d.Monto + d.Interes - d.Descuento });
                        }
                    } 
                }

                MostrarTotal();
            }
        }

        public void CargarProducto(E_DetalleVenta detalle, bool nuevo)
        {
            if(nuevo)
                carrito.AgregarProducto(detalle);
            else
                carrito.ActualizarProducto(detalle);

            dgvProductos.Rows.Clear();

            foreach (E_DetalleVenta d in carrito.ListaProductos) 
            {
                dgvProductos.Rows.Add(new object[] { d.Id, d.ProductoProveedor.Id, d.ProductoProveedor.Proveedor.Empresa, d.ProductoProveedor.Producto.Producto, d.ProductoProveedor.Producto.Codigo, d.Cantidad, d.Monto + d.Interes - d.Descuento });
            }

            foreach (E_ProductoProveedor p in productosProveedores)
            {
                if (p.Id == detalle.ProductoProveedor.Id)
                {
                    p.Stock -= detalle.Cantidad;

                    foreach (Control c in pnlProductos.Controls)
                    {
                        IDEVStudioUIRegProducto pr = c as IDEVStudioUIRegProducto;
                        if(pr != null)
                        {
                            if (pr.ProductoProveedor.Id == p.Id)
                            {
                                pr.ProductoProveedor.Stock = p.Stock;
                                pr.Renderizar();
                            }
                        }
                    }
                }
            }

            MostrarTotal();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (IDEVStudioUIMessageBox.Show("¿Guardar la venta?", "Guardar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (carrito.ListaProductos.Count > 0)
                {
                    venta.Fecha = DateTime.Now;
                    venta.Empleado = empleado;
                    if (N_Venta.InsertVenta(venta))
                    {
                        Thread.Sleep(500);
                        //Sacar el id de la ultima venta
                        int id = 0;
                        id = N_Venta.UltimaVenta();

                        if (id > 0)
                        {
                            venta.Id = id;
                            //Se le asigna la venta encontrada
                            foreach (E_DetalleVenta d in carrito.ListaProductos)
                                d.Venta = venta;

                            if (N_DetalleVenta.InsertDetalles(carrito.ListaProductos))
                            {
                                new AlertForm().ShowAlert("La venta se guardó correctamente.", TypeMessage.Check);
                                NuevaVenta();
                                BuscarProductos();
                                MostrarTotal();
                                principal.SelectVentas();
                            }
                            else
                                new AlertForm().ShowAlert("La venta no se pudo guardar.", TypeMessage.Error);
                        }
                        else
                        {
                            new AlertForm().ShowAlert("La venta no se pudo guardar.", TypeMessage.Error);
                        }
                    }
                }
                else
                {
                    new AlertForm().ShowAlert("El carrito está vacío.", TypeMessage.Error);
                }
            }
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            if (IDEVStudioUIMessageBox.Show("¿Cambiar empleado?", "Cambiar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login(this);
                login.ShowDialog();
            }
        }
        public void GetUsuario(E_Empleado empleado)
        {
            if (empleado != null)
            {
                this.empleado = empleado;
                lblUsuario.Text = "Usuario: " + empleado.Usuario.Usuario;
                new AlertForm().ShowAlert("Nuevo logueo de empleado.", TypeMessage.Warning);
            }
        }
        void MostrarTotal()
        {
            MontoTotal = carrito.CalcularMontoTotal();
            lblMonto.Text = "$ " + MontoTotal;

            int tDet = carrito.ListaProductos.Count();
            int cE = carrito.CalcularCantidadDetallesPorTipo(1);
            int cTr = carrito.CalcularCantidadDetallesPorTipo(2);
            int cTa = carrito.CalcularCantidadDetallesPorTipo(4) + carrito.CalcularCantidadDetallesPorTipo(5);
            int cO = tDet - (cE + cTr + cTa);            
            
            double mE = carrito.CalcularMontoPorTipo(1);
            double mTr = carrito.CalcularMontoPorTipo(2);
            double mTa = carrito.CalcularMontoPorTipo(4) + carrito.CalcularMontoPorTipo(5);
            double mO = MontoTotal - (mE + mTr + mTa);

            prbEfect.MaxValue = MontoTotal > 0 ? (int)MontoTotal : 1;
            prbTrans.MaxValue = MontoTotal > 0 ? (int)MontoTotal : 1;
            prbTarj.MaxValue = MontoTotal > 0 ? (int)MontoTotal : 1;
            prbOtros.MaxValue = MontoTotal > 0 ? (int)MontoTotal : 1;

            txtCantDetEfec.Text = "" + cE + "/" + tDet;
            lblMontoEfect.Text = "$" + mE;
            prbEfect.Value = (int)mE;

            txtCantDetTrans.Text = "" + cTr + "/" + tDet;
            lblMontoTrans.Text = "$" + mTr;
            prbTrans.Value = (int)mTr;

            txtCantDetTarj.Text = "" + cTa + "/" + tDet;
            lblMontoTarj.Text = "$" + mTa;
            prbTarj.Value = (int)mTa;

            txtCantDetOtros.Text = "" + cO + "/" + tDet;
            lblMontoOtros.Text = "$" + mO;
            prbOtros.Value = (int)mO;
        }

        #endregion
        #endregion

        #region Consultas
        private void BuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProductos(txtBuscar.textBox.Text, false);
                txtBuscar.Focus();
            }
        }
        private void BuscarCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.textBox.Text != "")
                    BuscarProductos(txtCodigo.textBox.Text, true);
            }
        }
        void BuscarProductos()
        {
            productosProveedores.Clear();
            productosProveedores.AddRange(N_ProductoProveedor.SelectProductosProveedores().ToArray());
            dgvProductos.Rows.Clear();
            pnlProductos.Controls.Clear();

            foreach (E_ProductoProveedor p in productosProveedores)
            {
                IDEVStudioUIRegProducto pr = new IDEVStudioUIRegProducto(p);
                pr.Dock = DockStyle.Top;
                pr.btnAgregarProducto.Click += AgregarProductoCarrito_Click;
                pnlProductos.Controls.Add(pr);
            }

            IDEVStudioUIRegProducto a = new IDEVStudioUIRegProducto();
            a.Dock = DockStyle.Top;
            pnlProductos.Controls.Add(a);
        }
        void BuscarProductos(string text, bool esCodigo)
        {
            string sql = esCodigo ? "WHERE codigo LIKE '%" + text + "%'" : "WHERE producto LIKE '%" + text + "%'";

            productosProveedores.Clear();
            productosProveedores.AddRange(N_ProductoProveedor.SelectProductosProveedores(sql).ToArray());
            pnlProductos.Controls.Clear();


            foreach (E_ProductoProveedor p in productosProveedores)
            {
                IDEVStudioUIRegProducto pr = new IDEVStudioUIRegProducto(p);
                pr.Dock = DockStyle.Top;
                pr.btnAgregarProducto.Click += AgregarProductoCarrito_Click;
                pnlProductos.Controls.Add(pr);
            }

            IDEVStudioUIRegProducto a = new IDEVStudioUIRegProducto();
            a.Dock = DockStyle.Top;
            pnlProductos.Controls.Add(a);
        }
        #endregion


    }
}
