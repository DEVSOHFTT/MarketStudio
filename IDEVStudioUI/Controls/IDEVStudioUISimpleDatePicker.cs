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
    public partial class IDEVStudioUISimpleDatePicker : UserControl
    {

        #region PROPIEDADES
        DateTime dateTime;
        bool showIcon;
        Color backgroundColor;
        Color textColor;
        string divider;
        Font textFont;
        MonthCalendar mc;
        bool showCalendar;
        Control headParent;
        Alignment alignment;
        #endregion

        public IDEVStudioUISimpleDatePicker()
        {
            this.dateTime = DateTime.Now;
            this.showIcon = true;
            this.backgroundColor = Color.FromArgb(64, 64, 64);
            this.textColor = Color.White;
            this.divider = "/";
            this.textFont = this.Font;
            this.headParent = this.Parent;
            this.alignment = Alignment.Left;
            InitializeComponent();
            mc = new MonthCalendar();
            mc.Leave += Calendar_Leave;
            mc.DateSelected += Calendar_DateSelected;
            Renderizar();
        }

        [Category("IDEV Studio Properties")]
        public DateTime DateTime { get => dateTime; set { dateTime = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public bool ShowIcon { get => showIcon; set { showIcon = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public Color BackgroundColor { get => backgroundColor; set { backgroundColor = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public string Divider { get => divider; set { divider = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public Font TextFont { get => textFont; set { textFont = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public Color TextColor { get => textColor; set { textColor = value; Renderizar(); } }

        [Category("IDEV Studio Properties")]
        public Control HeadParent { get => headParent; set => headParent = value; }

        [Category("IDEV Studio Properties")]
        public Alignment Alignment { get => alignment; set => alignment = value; }

        private void MostrarCalendario_Click(object sender, EventArgs e)
        {
            if (showCalendar)
            {
                mc.Hide();
                showCalendar = false;
            }
            else
            {
                if (headParent != null)
                {
                    Point p = alignment == Alignment.Left ? new Point(this.Location.X + this.Size.Height - 12, 10 + this.Location.Y + this.Size.Height * 2) :
                                                            new Point(this.Location.X + this.Size.Height - 12, 10 + this.Location.Y + this.Size.Height * 2); ;
                    mc.Location = p;
                    mc.Parent = headParent;
                }
                else
                {
                    mc.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height);
                    mc.Parent = this.Parent;
                }

                mc.Show();
                mc.BringToFront();
                showCalendar = true;
            }
        }

        void Renderizar()
        {
            pnlDatePicker.BackColor = backgroundColor;
            pnlIcon.Visible = showIcon;

            if (backgroundColor.GetBrightness() >= 0.8f)
                btnIcono.BackgroundImage = Properties.Resources.calendarB;
            else btnIcono.BackgroundImage = Properties.Resources.calendarW;

            pnlIcon.BackColor = backgroundColor;
            btnIcono.BackColor = backgroundColor;
            btnIcono.FlatAppearance.MouseDownBackColor = backgroundColor;
            btnIcono.FlatAppearance.MouseOverBackColor = backgroundColor;

            btnDia.BackColor = backgroundColor;
            btnDia.FlatAppearance.MouseDownBackColor = backgroundColor;
            btnDia.FlatAppearance.MouseOverBackColor = backgroundColor;
            btnDia.ForeColor = textColor;
            btnDia.Font = textFont;
            btnDia.Text = dateTime.ToString("dd");

            btnBarra1.BackColor = backgroundColor;
            btnBarra1.FlatAppearance.MouseDownBackColor = backgroundColor;
            btnBarra1.FlatAppearance.MouseOverBackColor = backgroundColor;
            btnBarra1.ForeColor = textColor;
            btnBarra1.Font = textFont;
            btnBarra1.Text = divider;

            btnMes.BackColor = backgroundColor;
            btnMes.FlatAppearance.MouseDownBackColor = backgroundColor;
            btnMes.FlatAppearance.MouseOverBackColor = backgroundColor;
            btnMes.ForeColor = textColor;
            btnMes.Font = textFont;
            btnMes.Text = dateTime.ToString("MM");

            btnBarra2.BackColor = backgroundColor;
            btnBarra2.FlatAppearance.MouseDownBackColor = backgroundColor;
            btnBarra2.FlatAppearance.MouseOverBackColor = backgroundColor;
            btnBarra2.ForeColor = textColor;
            btnBarra2.Font = textFont;
            btnBarra2.Text = divider;

            btnYear.BackColor = backgroundColor;
            btnYear.FlatAppearance.MouseDownBackColor = backgroundColor;
            btnYear.FlatAppearance.MouseOverBackColor = backgroundColor;
            btnYear.ForeColor = textColor;
            btnYear.Font = textFont;
            btnYear.Text = dateTime.ToString("yy");
        }

        private void Calendar_Leave(object sender, EventArgs e)
        {
            mc.Hide();
            showCalendar = false;
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTime = mc.SelectionEnd;
            mc.Hide();
            showCalendar = false;
            Renderizar();
        }
    }
}
