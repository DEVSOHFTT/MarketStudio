using Entidades.Persona;
using IDEVStudioUI.Alerts;
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

namespace MarketStudio
{
    public partial class Login : Form
    {
        Principal principal;
        bool cambiousuario = false;
        FormAgregarVenta venta;
        public Login()
        {
            InitializeComponent();
            cambiousuario = false;

            txtUsuario.textBox.KeyPress += IngresarEnter_KeyPress;
            txtClave.textBox.KeyPress += IngresarEnter_KeyPress;
        }

        public Login(FormAgregarVenta venta)
        {
            InitializeComponent();
            this.venta = venta;
            cambiousuario = true;

            txtUsuario.textBox.KeyPress += IngresarEnter_KeyPress;
            txtClave.textBox.KeyPress += IngresarEnter_KeyPress;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (cambiousuario)
                this.Close();
            else
                Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        void Ingresar()
        {
            if (txtUsuario.textBox.Text != "" && txtClave.textBox.Text != "")
            {
                E_Empleado e = N_Empleado.SelectEmpleado(txtUsuario.textBox.Text);
                if (e != null)
                {
                    if (e.Usuario.Contraseña == txtClave.textBox.Text)
                    {
                        if (cambiousuario)
                        {
                            venta.GetUsuario(e);
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            principal = new Principal(e);
                            principal.Show();
                        }
                    }
                    else
                    {
                        new AlertForm().ShowAlert("Usuario/contraseña incorrectos.", TypeMessage.Error);
                    }
                }
            }
            else
            {
                new AlertForm().ShowAlert("El Usuario/contraseña no puede quedar vacío.", TypeMessage.Warning);
            }
        }

        private void IngresarEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Ingresar();
            }
        }
    }
}
