using Entidades.Persona;
using Entidades.Producto;
using IDEVStudioUI;
using IDEVStudioUI.Alerts;
using IDEVStudioUI.Controls;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStudio
{
    public partial class FormABMProducto : Form
    {
        List<E_Proveedor> proveedores = new List<E_Proveedor>();
        List<E_SubCategoria> subCategorias = new List<E_SubCategoria>();
        List<E_TipoUnidadMedia> tiposUnidadesMedia = new List<E_TipoUnidadMedia>();
        FormTabControl tabControl;
        E_ProductoProveedor productoProveedor;
        bool modificar = false;
        public FormABMProducto(FormTabControl tabControl, E_ProductoProveedor productoProveedor)
        {
            InitializeComponent();
            this.tabControl = tabControl;
            this.productoProveedor = productoProveedor;
            Inicializar();
            RenderizarConValores();
            lblTitulo.Text = "Modificar producto";
            modificar = true;
        }
        public FormABMProducto(FormTabControl tabControl)
        {
            InitializeComponent();
            this.tabControl = tabControl;
            this.productoProveedor = new E_ProductoProveedor();
            Inicializar();
            RenderizarSinValores();
            lblTitulo.Text = "Agregar producto";
            modificar = false;
        }

        void Inicializar()
        {
            this.proveedores.AddRange(N_Proveedor.GetProveedores());
            this.subCategorias.AddRange(N_SubCategoria.GetSubCategorias());
            this.tiposUnidadesMedia.AddRange(N_TipoUnidadMedida.GetTiposUnidadesMedida());

            txtStock.textBox.KeyPress += ValidarNumeros_KeyPress;
            txtPrecioC.textBox.KeyPress += ValidarNumeros_KeyPress;
            txtPrecioV.textBox.KeyPress += ValidarNumeros_KeyPress;

            txtStock.textBox.Enter += ValidarNumeros_Enter;
            txtPrecioC.textBox.Enter += ValidarNumeros_Enter;
            txtPrecioV.textBox.Enter += ValidarNumeros_Enter;

            txtStock.textBox.Leave += ValidarNumeros_Leave;
            txtPrecioC.textBox.Leave += ValidarNumeros_Leave;
            txtPrecioV.textBox.Leave += ValidarNumeros_Leave;

            toolTip.SetToolTip(txtNombre.textBox, "Nombre del producto.");
            toolTip.SetToolTip(txtCodigo.textBox, "Código del producto.");
            toolTip.SetToolTip(txtStock.textBox, "Stock disponible.");
            toolTip.SetToolTip(txtPrecioC.textBox, "Precio de compra");
            toolTip.SetToolTip(txtPrecioV.textBox, "Precio de venta");

            Reproductor.Play(TypeSound.Click);
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

        void RenderizarConValores()
        {
            txtNombre.textBox.Text = productoProveedor.Producto.Producto;
            txtCodigo.textBox.Text = productoProveedor.Producto.Codigo;
            txtStock.textBox.Text = productoProveedor.Stock.ToString();
            txtPrecioC.textBox.Text = productoProveedor.PrecioCompra.ToString();
            txtPrecioV.textBox.Text = productoProveedor.PrecioVenta.ToString();

            cboProveedores.Items.Clear();
            cboCategorias.Items.Clear();
            cboUnidadMedida.Items.Clear();

            if (proveedores.Count > 0)
            {
                foreach (var pro in proveedores)
                    cboProveedores.Items.Add(pro.Empresa);

                cboProveedores.SelectedItem = productoProveedor.Proveedor.Empresa;
            }
            if (subCategorias.Count > 0)
            {
                foreach (var cat in subCategorias)
                    cboCategorias.Items.Add(cat.SubCategoria);

                cboCategorias.SelectedItem = productoProveedor.Producto.SubCategoria.SubCategoria;
            }
            if (tiposUnidadesMedia.Count > 0)
            {
                foreach (var t in tiposUnidadesMedia)
                    cboUnidadMedida.Items.Add(t.UnidadMedida);

                cboUnidadMedida.SelectedItem = productoProveedor.Producto.TipoUnidadMedida.UnidadMedida;
            }
        }
        void RenderizarSinValores()
        {
            txtNombre.textBox.Text = "";
            txtCodigo.textBox.Text = "00000000";
            txtStock.textBox.Text = "0";
            txtPrecioC.textBox.Text = "$ 0,00";
            txtPrecioV.textBox.Text = "$ 0,00";

            cboProveedores.Items.Clear();
            cboCategorias.Items.Clear();
            cboUnidadMedida.Items.Clear();

            if (proveedores.Count > 0)
            {
                foreach (var pro in proveedores)
                    cboProveedores.Items.Add(pro.Empresa);
                cboProveedores.SelectedIndex = 0;
            }
            if (subCategorias.Count > 0)
            {
                foreach (var cat in subCategorias)
                    cboCategorias.Items.Add(cat.SubCategoria);
                cboCategorias.SelectedIndex = 0;
            }
            if (tiposUnidadesMedia.Count > 0)
            {
                foreach (var t in tiposUnidadesMedia)
                    cboUnidadMedida.Items.Add(t.UnidadMedida);
                cboUnidadMedida.SelectedIndex = 0;
            }
        }

        bool ValidarDatos()
        {
            bool ok = true;
            List<string> errores = new List<string>();

            if (txtNombre.textBox.Text == "")
            {
                ok = false;
                errores.Add("Colocar un nombre!");
            }
            if (txtCodigo.textBox.Text != "")
            {
                if (modificar)
                {
                    if (txtCodigo.textBox.Text != productoProveedor.Producto.Codigo)
                    {
                        foreach (var pp in N_ProductoProveedor.GetProductosProveedores())
                        {
                            if (pp.Producto.Codigo == txtCodigo.textBox.Text)
                            {
                                ok = false;
                                errores.Add("El código ingresado ya existe!");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (var pp in N_ProductoProveedor.GetProductosProveedores())
                    {
                        if (pp.Producto.Codigo == txtCodigo.textBox.Text)
                        {
                            ok = false;
                            errores.Add("El código ingresado ya existe.");
                            break;
                        }
                    }
                }
            }
            else
            {
                ok = false;
                errores.Add("Colocar un código!");
            }
            if (txtStock.textBox.Text != "")
            {
                ConvertirCantidad(txtStock);
            }
            if(txtPrecioC.textBox.Text != "")
            {
                if(ConvertirCantidad(txtPrecioC) <= 0)
                {
                    ok = false;
                    errores.Add("Precio de compra menor/igual a 0!");
                }
            }
            if (txtPrecioV.textBox.Text != "")
            {
                if (ConvertirCantidad(txtPrecioV) <= 0)
                {
                    ok = false;
                    errores.Add("Precio de venta menor/igual a 0!");
                }
            }
            if(cboProveedores.SelectedIndex < 0)
            {
                ok = false;
                errores.Add("Seleccionar un proveedor!");
            }
            if (cboCategorias.SelectedIndex < 0)
            {
                ok = false;
                errores.Add("Seleccionar una categoría!");
            }
            if (cboUnidadMedida.SelectedIndex < 0)
            {
                ok = false;
                errores.Add("Seleccionar una unidad de medida!");
            }

            for (int i = 0; i < errores.Count; i++)
                new AlertForm().ShowAlert(errores[i], TypeMessage.Warning);

            return ok;
        }
        bool Guardar()
        {
            bool ok = false;
            //1_ Validar que estén todos los datos necesarios.
            if (ValidarDatos())
            {
                //2_ Detectar que proveedor esta seleccionado
                E_Proveedor proveedor = new E_Proveedor();
                foreach (var p in proveedores)
                {
                    if (p.Empresa == cboProveedores.SelectedItem.ToString())
                        proveedor = p;
                }
                //3_ Detectar que categoría esta seleccionada
                E_SubCategoria subCategoria = new E_SubCategoria();
                foreach (var s in subCategorias)
                {
                    if (s.SubCategoria == cboCategorias.SelectedItem.ToString())
                        subCategoria = s;
                }
                //4_ Determinar el tipo de unidad de medida
                E_TipoUnidadMedia tipoUnidadMedia = new E_TipoUnidadMedia();
                foreach (var t in tiposUnidadesMedia)
                {
                    if (t.UnidadMedida == cboUnidadMedida.SelectedItem.ToString())
                        tipoUnidadMedia = t;
                }

                //5_ Determinar los montos a ingresar
                double stock = ConvertirCantidad(txtStock);
                double precioC = ConvertirCantidad(txtPrecioC);
                double precioV = ConvertirCantidad(txtPrecioV);

                if (modificar)
                {
                    E_Producto producto = new E_Producto(productoProveedor.Producto.Id, txtCodigo.textBox.Text, txtNombre.textBox.Text, subCategoria, tipoUnidadMedia);
                    if (N_ProductoProveedor.ActualizarProductoProveedor(new E_ProductoProveedor(productoProveedor.Id, producto, proveedor, stock, precioC, precioV)))
                        new AlertForm().ShowAlert("Se guardó correctamente.", TypeMessage.Check);
                    else
                    {
                        new AlertForm().ShowAlert("No se pudo guardar los cambios.", TypeMessage.Error);
                        new AlertForm().ShowAlert("Se generó un informe.", TypeMessage.Null);
                    }
                }
                else
                {
                    E_Producto producto = new E_Producto(0, txtCodigo.textBox.Text, txtNombre.textBox.Text, subCategoria, tipoUnidadMedia);
                    if (N_ProductoProveedor.InsertarProductoProveedor(new E_ProductoProveedor(0, producto, proveedor, stock, precioC, precioV)))
                    {
                        ok = true;
                        new AlertForm().ShowAlert("Se guardó correctamente.", TypeMessage.Check);
                    }
                    else
                    {
                        new AlertForm().ShowAlert("No se pudo guardar los cambios.", TypeMessage.Error);
                        new AlertForm().ShowAlert("Se generó un informe.", TypeMessage.Null);
                    }
                }

            }

            return ok;
        }
        void Salir()
        {
            if (IDEVStudioUIMessageBox.Show("¿Descartar cambios?", "Cancelar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IDEVStudioUIMessageBox.Show("¿Guardar cambios?", "Guardar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Guardar())
                {
                    tabControl.MostrarTabProductos();
                    this.Close();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        #region Eventos
        double ConvertirCantidad(IDEVStudioUITextBox textBox)
        {
            double cant = 0;
            try
            {
                cant = Convert.ToDouble(textBox.textBox.Text.Replace('.', ','));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! :" + e.Message);
            }
            return cant;
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
    }
}
