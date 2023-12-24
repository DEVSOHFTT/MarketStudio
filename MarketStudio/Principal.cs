using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Entidades.Persona;
using Negocios;
using IDEVStudioUI.Controls;
using IDEVStudioUI;
using IDEVStudioUI.Alerts;

namespace MarketStudio
{
    public partial class Principal : Form
    {
        E_Empleado empleado;
        bool admin = false;
        public Principal()
        {
            InitializeComponent();
            SeleccionarPagina("tabInicio");
        }
        public Principal(E_Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            admin = SetEmpleado();
            SeleccionarPagina("tabInicio");
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

        #region Animaciones
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Animador.ExaltarBotonLayout_MouseEnter((Control)sender);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Animador.ExaltarBotonLayout_MouseLeave((Control)sender);
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Control label = (Control)sender;
            Control pic = new Control();
            foreach (Control ctrl in label.Parent.Controls)
            {
                if (ctrl.Controls.Count > 0)
                    pic = ctrl.Controls[0];
            }

            Animador.ExaltarLabelLayout_MouseEnter(label, pic);
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Control label = (Control)sender;
            Control pic = new Control();
            foreach (Control ctrl in label.Parent.Controls)
            {
                if (ctrl.Controls.Count > 0)
                    pic = ctrl.Controls[0];
            }

            Animador.ExaltarLabelLayout_MouseLeave(label, pic);
        }
        #endregion

        #region Botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Inicio).ShowDialog(this);
            SeleccionarPagina("tabInicio");
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Ventas).ShowDialog(this);
            SeleccionarPagina("tabVentas");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Inventario).ShowDialog(this);
            SeleccionarPagina("tabProductos");
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Gastos).ShowDialog(this);
            SeleccionarPagina("tabGastos");
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Proveedores).ShowDialog(this);
            SeleccionarPagina("tabProveedores");
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Balance).ShowDialog(this);
            SeleccionarPagina("tabBalance");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Usuarios).ShowDialog(this);
            SeleccionarPagina("tabUsuarios");
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Empleados).ShowDialog(this);
            SeleccionarPagina("tabEmpleados");
        }

        #endregion

        #region Tabs
        void SeleccionarPagina(string name)
        {
            int index = 0;
            bool exist = false;
            for (int i = 0; i < tabPrincipal.TabPages.Count; i++)
            {
                if (tabPrincipal.TabPages[i].Name == name)
                {
                    index = i;
                    exist = true;
                }
            }

            if (exist)
                tabPrincipal.SelectedIndex = index;
            else
            {
                TabPage tab = new FormTabControl(empleado).GetTab(name);
                tabPrincipal.TabPages.Add(tab);
                tabPrincipal.SelectedTab = tab;
            }

            SetIconHeader();
        }

        void SetIconHeader()
        {
            foreach (Control c in tabPrincipal.SelectedTab.Controls)
            {
                if (c.Tag!= null)
                {
                    if (c.Tag.ToString().Equals("TabIcon"))
                        picTabIcon.BackgroundImage = c.BackgroundImage;
                }
            }

            lblTabName.Text = tabPrincipal.SelectedTab.Text;
            Reproductor.Play(TypeSound.Click);
        }

        void CerrarTab(object button)
        {
            try
            {
                //Busca el parent del boton que tiene que estar en la tab para que detecte al tab como padre.
                TabPage t = ((Control)button).Parent as TabPage;
                tabPrincipal.TabPages.Remove(t);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCerrarProductos_Click(object sender, EventArgs e)
        {
            CerrarTab(sender);
        }
        #endregion

        public bool SetEmpleado()
        {
            lblTipoUsuario.Text = empleado.TipoPuesto.Tipo;
            lblUsuario.Text = empleado.Usuario.Usuario;

            bool permiso = false;
            if (empleado.TipoPuesto.Tipo != "Administrador" || empleado.TipoPuesto.Tipo != "Sistemas")
            {
                permiso = false;
                new AlertForm().ShowAlert("Se han quitado algunos permisos.", TypeMessage.Warning);
            }
            else
            {
                permiso = true;
            }
            return permiso;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Size size = new Size();
            if (pnlDesplegable.Size.Width < 200)
                size = new Size(200, pnlDesplegable.Size.Height);
            else
                size = new Size(40, pnlDesplegable.Size.Height);

            pnlDesplegable.Size = size;
        }
    }
}
