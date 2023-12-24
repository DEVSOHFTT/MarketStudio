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
    public partial class IDEVStudioUIBasicDateTimePicker : UserControl
    {
        Color backgroundColor;
        Color textColor;
        Font textFont;
        bool showIcon;
        Alignment iconAlignment;
        DateTime date;

        public IDEVStudioUIBasicDateTimePicker()
        {
            this.date = DateTime.Now;
            this.backgroundColor = Color.FromArgb(64, 64, 64);
            this.textColor = Color.White;
            this.textFont = this.Font;
            this.showIcon = true;
            this.iconAlignment = Alignment.Right;
            this.MinimumSize = new Size(170, 32);
            InitializeComponent();
        }

        [Category("IDEV Studio Properties")]
        public DateTime Date { get => date; set { date = value; SetDate(value); } }

        [Category("IDEV Studio Properties")]
        public Color BackgroundColor { get => backgroundColor; set { backgroundColor = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public Font TextFont { get => textFont; set { textFont = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public Color TextColor { get => textColor; set { textColor = value; Renderizar();} }

        [Category("IDEV Studio Properties")]
        public bool ShowIcon { get => showIcon; set { showIcon = value; pnlPic.Visible = value; } }

        [Category("IDEV Studio Properties")]
        public Alignment IconAlignment { get => iconAlignment; set { iconAlignment = value; if (value == Alignment.Right) pnlPic.Dock = DockStyle.Right; else pnlPic.Dock = DockStyle.Left; } }

        void Renderizar()
        {
            //Colores
            this.BackColor = backgroundColor;

            if (backgroundColor.GetBrightness() >= 0.8f)
                picIcono.BackgroundImage = Properties.Resources.calendarB;
            else picIcono.BackgroundImage = Properties.Resources.calendarW;

            pnlDtp.BackColor = backgroundColor;
            txtDia.BackColor = backgroundColor;
            txtMes.BackColor = backgroundColor;
            txtAño.BackColor = backgroundColor;
            txtDia.ForeColor = textColor;
            txtMes.ForeColor = textColor;
            txtAño.ForeColor = textColor;
            pnlPic.BackColor = backgroundColor;

            //Fuentes
            txtDia.Font = textFont;
            txtMes.Font = textFont;
            txtAño.Font = textFont;
        }

        void SetDate(DateTime d)
        {
            txtDia.Text = d.ToString("dd");
            txtMes.Text = d.ToString("MM");
            txtAño.Text = d.ToString("yy");
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Control)sender).Text.Length <= 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                {
                    /*
                    if (e.KeyChar != '0')
                        e.Handled = false;
                    else
                        e.Handled = true;
                    */
                    e.Handled = false;
                }
            }
            else
                e.Handled = true;
        }
        
        string fechaValue = "";

        #region DIA
        private void txtDia_Enter(object sender, EventArgs e)
        {
            fechaValue = txtDia.Text;
            txtDia.Text = "";
        }

        private void txtDia_Leave(object sender, EventArgs e)
        {
            string txt = txtDia.Text;
            if (txt != "")
            {
                int max = DateTime.DaysInMonth(date.Year, date.Month);

                int dia = 1;
                try { dia = Convert.ToInt32(txt); } catch (Exception ex) { Console.WriteLine("Error! " + ex.Message); }

                if (dia > max)
                    dia = max;

                DateTime fecha = new DateTime(date.Year, date.Month, dia);
                date = fecha;
                SetDate(date);
            }
            else
            {
                txtDia.Text = fechaValue;
            }
        }
        #endregion

        #region MES
        private void txtMes_Enter(object sender, EventArgs e)
        {
            fechaValue = txtMes.Text;
            txtMes.Text = "";
        }

        private void txtMes_Leave(object sender, EventArgs e)
        {
            string txt = txtMes.Text;
            if (txt != "")
            {
                int max = 12;

                int mes = 1;
                try { mes = Convert.ToInt32(txt); } catch (Exception ex) { Console.WriteLine("Error! " + ex.Message); }

                if (mes > max)
                    mes = max;

                DateTime fecha = new DateTime(date.Year, mes, date.Day);
                date = fecha;
                SetDate(date);
            }
            else
            {
                txtMes.Text = fechaValue;
            }
        }
        #endregion

        #region AÑO
        private void txtAño_Enter(object sender, EventArgs e)
        {
            fechaValue = txtAño.Text;
            txtAño.Text = "";
        }

        private void txtAño_Leave(object sender, EventArgs e)
        {
            string txt = txtAño.Text;
            if (txt != "")
            {
                int max = 99;

                int año = 1;
                try { año = Convert.ToInt32(txt); } catch (Exception ex) { Console.WriteLine("Error! " + ex.Message); }

                if (año > max)
                    año = max;

                DateTime fecha = new DateTime(año, date.Month, date.Day);
                date = fecha;
                SetDate(date);
            }
            else
            {
                txtAño.Text = fechaValue;
            }
        }
        #endregion

        private void OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
