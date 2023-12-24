using Client;
using IDEVStudioUI.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStudio
{
    public partial class FormEmail : Form
    {
        List<string> paths = new List<string>();
        public FormEmail()
        {
            InitializeComponent();
        }

        public FormEmail(string path)
        {
            InitializeComponent();
            txtAsunto.textBox.Text = "Recibo de la compra el dia " + DateTime.Now.ToShortDateString();
            txtBody.textBox.Text = "Estimado, muchas gracias por la compra. A continuación le adjunto el recibo de la compra en el dia de la fecha.";
            paths.Add(path);
            CargarArchivos();
        }

        void CargarArchivos()
        {
            lstPaths.Items.Clear();
            foreach (string p in paths)
             lstPaths.Items.Add(p);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string p = openFileDialog.FileName;
            if (p != null && p != "")
            {
                paths.Add(p);
                CargarArchivos();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstPaths.SelectedIndex >= 0)
            {
                paths.Remove(lstPaths.SelectedItem.ToString());
                lstPaths.Items.Remove(lstPaths.SelectedItem);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            new FormLoadingPage(TypePage.Compartir).ShowDialog(this);
            //Validar datos
            if (txtDestino.textBox.Text != "")
            {
                //Validar que ingrese un correo
                Email email = new Email(txtDestino.textBox.Text, txtAsunto.textBox.Text, txtBody.textBox.Text, paths);
                if (email.Error != "")
                    IDEVStudioUIMessageBox.Show(email.Error, "Error al enviar el Documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    new AlertForm().ShowAlert("El documento se envió correctamente.", TypeMessage.Check);
                    this.Close();
                }
            }
            else
            {
                new AlertForm().ShowAlert("Ingresar un correo destinatario.", TypeMessage.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
