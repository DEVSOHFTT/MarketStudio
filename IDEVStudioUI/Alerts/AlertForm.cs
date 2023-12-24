using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEVStudioUI.Alerts
{
    public enum TypeMessage
    {
        Null = 0,
        Check = 1,
        Information = 2,
        Question = 3,
        Warning = 4,
        Error = 5
    }

    public enum TypeAction
    {
       Wait = 1,
       Start = 2,
       Exit = 3
    }

    public partial class AlertForm : Form
    {
        TypeAction action;
        int x;
        int y;

        public AlertForm()
        {
            InitializeComponent();
        }

        public void ShowAlert(string msg, TypeMessage type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertForm frm = (AlertForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            Renderer(msg, type);

            this.Show();

            action = TypeAction.Start;
            timer.Interval = 1;
            timer.Start();

            switch (type)
            {
                case TypeMessage.Null:
                    break;
                case TypeMessage.Check:
                    Reproductor.Play(TypeSound.Information);
                    break;
                case TypeMessage.Information:
                    Reproductor.Play(TypeSound.Information);
                    break;
                case TypeMessage.Question:
                    Reproductor.Play(TypeSound.Question);
                    break;
                case TypeMessage.Warning:
                    Reproductor.Play(TypeSound.Warning);
                    break;
                case TypeMessage.Error:
                    Reproductor.Play(TypeSound.Error);
                    break;
                default:
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = TypeAction.Exit;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case TypeAction.Wait:
                    Wait();
                    break;
                case TypeAction.Start:
                    Start();
                    break;
                case TypeAction.Exit:
                    Exit();
                    break;
            }
        }

        void Wait()
        {
            timer.Interval = 5000;
            action = TypeAction.Exit;
        }
        void Start()
        {
            this.timer.Interval = 1;
            this.Opacity += 0.1;
            if (this.x < this.Location.X)
            {
                this.Left--;
            }
            else
            {
                if (this.Opacity == 1.0)
                {
                    action = TypeAction.Wait;
                }
            }
        }
        void Exit()
        {
            timer.Interval = 1;
            this.Opacity -= 0.1;

            this.Left -= 3;
            if (base.Opacity == 0.0)
            {
                base.Close();
            }
        }

        void Renderer(string msg, TypeMessage type)
        {
            Color bg = Color.FromArgb(85, 90, 110);
            switch (type)
            {
                case TypeMessage.Null:
                    break;
                case TypeMessage.Check:
                    picIcono.BackgroundImage = imageList.Images[0];
                    bg = Color.ForestGreen;
                    break;
                case TypeMessage.Information:
                    picIcono.BackgroundImage = imageList.Images[1];
                    bg = Color.FromArgb(35, 135, 195);
                    break;
                case TypeMessage.Question:
                    picIcono.BackgroundImage = imageList.Images[2];
                    bg = Color.FromArgb(35, 135, 195);
                    break;
                case TypeMessage.Warning:
                    picIcono.BackgroundImage = imageList.Images[3];
                    bg = Color.DarkOrange;
                    break;
                case TypeMessage.Error:
                    picIcono.BackgroundImage = imageList.Images[4];
                    bg = Color.FromArgb(230, 65, 120);
                    break;
            }
            
            /*
            if (msg.Length >= 30)
            {
                txtBody.Dock = DockStyle.Fill;
                txtBody.ScrollBars = ScrollBars.Vertical;
            }
            */

            this.BackColor = bg;
            txtBody.BackColor = bg;

            txtBody.Text = msg;
        }
    }
}
