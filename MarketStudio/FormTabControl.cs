using Entidades.Persona;
using Entidades.Producto;
using Entidades.Venta;
using IDEVStudioUI.Alerts;
using IDEVStudioUI.Controls;
using IDEVStudioUI.Models;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarketStudio
{
    public partial class FormTabControl : Form
    {
        #region Properties
        List<E_ProductoProveedor> productos;
        List<E_Proveedor> proveedores;
        List<E_SubCategoria> subCategorias;
        List<E_DetalleVenta> detalleVentas;

        E_Empleado empleado;
        #endregion

        public FormTabControl()
        {
            InitializeComponent();

            productos = new List<E_ProductoProveedor>();
            proveedores = new List<E_Proveedor>();
            subCategorias = new List<E_SubCategoria>();
            detalleVentas = new List<E_DetalleVenta>();

            txtBuscarProducto.textBox.KeyDown += BuscarProducto_KeyDown;

            SetTime();
        }

        public FormTabControl(E_Empleado empleado)
        {
            InitializeComponent();

            this.empleado = empleado;

            productos = new List<E_ProductoProveedor>();
            proveedores = new List<E_Proveedor>();
            subCategorias = new List<E_SubCategoria>();
            detalleVentas = new List<E_DetalleVenta>();

            txtBuscarProducto.textBox.KeyDown += BuscarProducto_KeyDown;

            SetTime();
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

        #region Metodos Publicos
        public TabPage GetTab(string name)
        {
            TabPage tab = new TabPage();
            foreach (TabPage t in tabPrincipal.TabPages)
            {
                if (t.Name == name)
                    tab = t;  
            }

            switch (tab.Name)
            {
                case "tabProductos":
                    MostrarTabProductos();
                    break;
                case "tabVentas":
                    MostrarTabVentas();
                    break;
            }

            return tab;
        }
        public TabPage GetTab(int index)
        {
            TabPage tab = new TabPage();
            if (index >= 0 && index < tabPrincipal.TabPages.Count)
                tab = tabPrincipal.TabPages[index];

            return tab;
        }
        #endregion

        #region ScrollBars
        private void pnlVentas_ControlAdded(object sender, ControlEventArgs e)
        {
            /*
            scrollbarVentas.MaximumValue = pnlVentas.VerticalScroll.Maximum;
            pnlVentas.HorizontalScroll.Visible = false;
            pnlVentas.VerticalScroll.Visible = false;
            */
        }

        private void pnlVentas_ControlRemoved(object sender, ControlEventArgs e)
        {
            /*
            scrollbarVentas.MaximumValue = pnlVentas.VerticalScroll.Maximum;
            pnlVentas.HorizontalScroll.Visible = false;
            pnlVentas.VerticalScroll.Visible = false;
            */
        }

        private void scrollbarVentas_ValueChanged(object sender, EventArgs e)
        {
            //pnlVentas.VerticalScroll.Value = scrollbarVentas.Value;
        }

        private void pnlVentas_Scroll(object sender, ScrollEventArgs e)
        {
            /*
             pnlVentas.HorizontalScroll.Visible = false;
             pnlVentas.VerticalScroll.Visible = false;

             */
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //new Client.Email().SendedEmail("Direcciones mac: " + new Client.MacAddress().GetMacAddress());
        }
        #endregion

        #region Inicio

        #region Metodos
        void SetTime()
        {
            lblHora.Text = DateTime.Now.ToString("t");
            lblFecha.Text = DateTime.Now.ToString("D");
        }
        #endregion
        #region Eventos
        private void timer_Tick(object sender, EventArgs e)
        {
            SetTime();
        }
        #endregion
        #endregion

        #region Ventas

        #region Metodos
        void MostrarTabVentas()
        {
            SelectUsuariosVentas();
            SelectVentas();
        }
        void RenderizarVentas()
        {
            pnlListaVentas.Controls.Clear();
            int i = 0;

            double totalEfectivo = 0;
            int cantEfectivo = 0;
            double totalTarjetas = 0;
            int cantTarjetas = 0;
            double totalTransferencias = 0;
            int cantTransferencias = 0;
            double totalOtros = 0;
            int cantOtros = 0;

            foreach (E_DetalleVenta v in detalleVentas)
            {
                IDEVStudioUIRegVenta rv= new IDEVStudioUIRegVenta(v);
                rv.btnVer.Click += VerDetalleVenta_Click;
                rv.btnVer.Name = "btnVer" + i;
                rv.Dock = DockStyle.Top;
                pnlListaVentas.Controls.Add(rv);
                i++;

                switch (v.TipoPago.Id)
                {
                    case 1:
                        totalEfectivo += v.MontoTotal();
                        cantEfectivo++;
                        break;
                    case 2:
                        totalTransferencias += v.MontoTotal();
                        cantTransferencias++;
                        break;
                    case 4:
                        totalTarjetas += v.MontoTotal();
                        cantTarjetas++;
                        break;
                    case 5:
                        totalTarjetas += v.MontoTotal();
                        cantTarjetas++;
                        break;
                    default:
                        totalOtros += v.MontoTotal();
                        cantOtros++;
                        break;
                }
            }

            IDEVStudioUIRegVenta header = new IDEVStudioUIRegVenta();
            header.Dock = DockStyle.Top;
            pnlListaVentas.Controls.Add(header);

            barEfectivo.Value = Convert.ToInt32(totalEfectivo);
            txtCantEfectivo.Text = cantEfectivo + "/" + detalleVentas.Count;
            barTarjetas.Value = Convert.ToInt32(totalTarjetas);
            txtCantTarjeta.Text = cantTarjetas + "/" + detalleVentas.Count;
            barTransferencias.Value = Convert.ToInt32(totalTransferencias);
            txtCantTransferencias.Text = cantTransferencias + "/" + detalleVentas.Count;
            barOtrosMedios.Value = Convert.ToInt32(totalOtros);
            txtCantOtros.Text = cantOtros + "/" + detalleVentas.Count;

            lblTotalVentas.Text = "$ " + (totalEfectivo + totalTarjetas + totalTransferencias + totalOtros);
            lblEfectivo.Text = "$ " + totalEfectivo;
            lblTarjeta.Text = "$ " + totalTarjetas;
            lblTranferencias.Text = "$ " + totalTransferencias;
            lblOtrosMedios.Text = "$ " + totalOtros;
        }
        #endregion

        #region Consultas
        void SelectUsuariosVentas()
        {
            cboEmpleados.Items.Clear();
            foreach (var u in N_Usuario.SelectUsuarios())
            {
                cboEmpleados.Items.Add(u.Usuario);
            }
            if(cboEmpleados.Items.Count > 0)
                cboEmpleados.SelectedIndex = 0;
        }
        public void SelectVentas()
        {
            detalleVentas.Clear();
            detalleVentas.AddRange(N_DetalleVenta.SelectTotalVentas());
            foreach (var d in N_DetalleVenta.SelectDetalleVentas())
            {
                foreach (var dv in detalleVentas)
                {
                    if (d.Venta.Id == dv.Venta.Id)
                    {
                        dv.TipoPago.Id = d.TipoPago.Id;
                        dv.TipoPago.TipoPago = d.TipoPago.TipoPago;
                    }      
                }
            }

            if (detalleVentas.Count > 0)
                RenderizarVentas();
            else
                new AlertForm().ShowAlert("No hay registros.", TypeMessage.Error);
        }
        void SelectVentas(DateTime inicio, DateTime fin)
        {

        }
        #endregion

        #region Eventos
        private void VerDetalleVenta_Click(object sender, EventArgs e)
        {
            int idVenta = 0;
            Control ctrl = sender as Control;

            foreach (IDEVStudioUIRegVenta r in pnlListaVentas.Controls)
            {
                if (r.btnVer.Name == ctrl.Name)
                    idVenta = r.DetalleVenta.Venta.Id;
            }

            if (idVenta > 0)
                new FormDetalleVenta(N_DetalleVenta.SelectDetalleVentas("WHERE v.id = " + idVenta)).ShowDialog();
            else
            {
                new AlertForm().ShowAlert("No se pudo abrir el detalle.", TypeMessage.Error);
                new AlertForm().ShowAlert("Generando informe.", TypeMessage.Information);
            }
        }
        private void btnRecargarVentas_Click(object sender, EventArgs e)
        {
            SelectVentas();
        }
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            new FormAgregarVenta(empleado, this).ShowDialog();
        }
        #endregion

        #endregion

        #region Productos

        #region Consultas
        void SelectProductos()
        {
            productos.Clear();
            productos.AddRange(N_ProductoProveedor.SelectProductosProveedores());
            if (productos.Count > 0)
                RenderizarProductos();
            else
                new AlertForm().ShowAlert("No hay registros.", TypeMessage.Error);
        }
        void SelectProductos(string txt)
        {
            string sql = "WHERE pts.codigo LIKE '%" + txt + "%' OR pts.producto LIKE '%" + txt + "%' OR prs.empresa LIKE '%" + txt + "%' OR sc.subCategoria LIKE '%" + txt + "%'";
            productos.Clear();
            productos.AddRange(N_ProductoProveedor.SelectProductosProveedores(sql));
            if (productos.Count > 0)
                RenderizarProductos();
            else
                new AlertForm().ShowAlert("No hay registros.", TypeMessage.Error);
        }
        void SelectProductos(E_Proveedor proveedor, E_SubCategoria subCategoria)
        {
            productos.Clear();
            productos.AddRange(N_ProductoProveedor.SelectProductosProveedores(proveedor, subCategoria));
            if (productos.Count > 0)
                RenderizarProductos();
            else
                new AlertForm().ShowAlert("No se encontraron coincidencias.", TypeMessage.Warning);
        }
        void SelectProductos(E_Proveedor proveedor)
        {
            productos.Clear();
            productos.AddRange(N_ProductoProveedor.SelectProductosProveedores(proveedor));
            if (productos.Count > 0)
                RenderizarProductos();
            else
                new AlertForm().ShowAlert("No se encontraron coincidencias.", TypeMessage.Warning);
        }
        void SelectProductos(E_SubCategoria subCategoria)
        {
            productos.Clear();
            productos.AddRange(N_ProductoProveedor.SelectProductosProveedores(subCategoria));
            if (productos.Count > 0)
                RenderizarProductos();
            else
                new AlertForm().ShowAlert("No se encontraron coincidencias.", TypeMessage.Warning);
        }
        #endregion

        #region Metodos
        public void MostrarTabProductos()
        {
            SelectProductos();
            RenderizarCombosBoxProductos();
        }
        void RenderizarCombosBoxProductos()
        {
            cboProductoProveedores.Items.Clear();
            cboProductoCategorias.Items.Clear();

            proveedores.Clear();
            proveedores.AddRange(N_Proveedor.SelectProveedores());

            subCategorias.Clear();
            subCategorias.AddRange(N_SubCategoria.SelectSubCategorias());

            foreach (E_Proveedor p in proveedores)
            {
                cboProductoProveedores.Items.Add(p.Empresa);
            }

            foreach (E_SubCategoria s in subCategorias)
            {
                cboProductoCategorias.Items.Add(s.SubCategoria);
            }
        }
        void RenderizarProductos()
        {
            pnlListaProductos.Controls.Clear();

            foreach (E_ProductoProveedor p in productos)
            {
                IDEVStudioUIProducto pp = new IDEVStudioUIProducto(p);
                pp.btnModificar.Click += ModificarProducto_Click;
                pp.btnEliminar.Click += EliminarProducto_Click;
                pp.Dock = DockStyle.Top;
                pnlListaProductos.Controls.Add(pp);
            }

            IDEVStudioUIProducto header = new IDEVStudioUIProducto();
            header.Dock = DockStyle.Top;
            pnlListaProductos.Controls.Add(header);
        }
        void FiltarProductos()
        {
            E_Proveedor proveedor = new E_Proveedor();
            E_SubCategoria subCategoria = new E_SubCategoria();
            if (cboProductoProveedores.SelectedIndex >= 0)
                proveedor = proveedores.Find(x => x.Empresa == cboProductoProveedores.SelectedItem.ToString());
            if (cboProductoCategorias.SelectedIndex >= 0)
                subCategoria = subCategorias.Find(x => x.SubCategoria == cboProductoCategorias.SelectedItem.ToString());

            if (proveedor.Id > 0 && subCategoria.Id > 0)
            {
                SelectProductos(proveedor, subCategoria);
            }
            else if (proveedor.Id > 0 && subCategoria.Id <= 0)
            {
                SelectProductos(proveedor);
            }
            else if (proveedor.Id <= 0 && subCategoria.Id > 0)
            {
                SelectProductos(subCategoria);
            }
        }
        #endregion

        #region Eventos
        private void BuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectProductos(txtBuscarProducto.textBox.Text);
            }
        }
        private void ModificarProducto_Click(object sender, EventArgs e)
        {
            IDEVStudioUIProducto producto = ((Control)sender).Parent.Parent.Parent.Parent as IDEVStudioUIProducto;
            new FormABMProducto(this, producto.ProductoProveedor).ShowDialog();
        }
        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            IDEVStudioUIProducto producto = ((Control)sender).Parent.Parent.Parent.Parent as IDEVStudioUIProducto;
            if (IDEVStudioUIMessageBox.Show("¿Desea eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IDEVStudioUIMessageBox.Show("El producto se eliminará permanentemente" + "\n" +
                                                "con todas las ventas relacionadas a el" + "\n" + 
                                                "¿Continuar?", "Cancelar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (N_ProductoProveedor.EliminarProductoProveedor(producto.ProductoProveedor))
                    {
                        new AlertForm().ShowAlert("Se eliminó correctamente", TypeMessage.Check);
                        SelectProductos();
                    }
                    else
                        new AlertForm().ShowAlert("No se pudo eliminar", TypeMessage.Error);
                }
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FormABMProducto(this).ShowDialog();
        }
        private void btnRecargarProductos_Click(object sender, EventArgs e)
        {
            SelectProductos();
        }
        private void cboProductoProveedores_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltarProductos();
        }
        private void cboProductoCategorias_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltarProductos();
        }
        #endregion

        #endregion
    }
}
