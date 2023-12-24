namespace MarketStudio
{
    partial class FormLoadingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBack = new IDEVStudioUI.Controls.IDEVStudioUIPictureBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.barProgress = new XanderUI.XUICircleProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.White;
            this.picBack.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.picBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.picBack.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.picBack.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picBack.BorderSize = 5;
            this.picBack.GradientAngle = 50F;
            this.picBack.Location = new System.Drawing.Point(75, 75);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(200, 200);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 1;
            this.picBack.TabStop = false;
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.White;
            this.picLoading.Location = new System.Drawing.Point(115, 115);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(120, 120);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 2;
            this.picLoading.TabStop = false;
            // 
            // barProgress
            // 
            this.barProgress.AnimationSpeed = 8;
            this.barProgress.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.barProgress.FilledColorAlpha = 255;
            this.barProgress.FilledThickness = 50;
            this.barProgress.IsAnimated = true;
            this.barProgress.Location = new System.Drawing.Point(67, 67);
            this.barProgress.Name = "barProgress";
            this.barProgress.Percentage = 35;
            this.barProgress.ShowText = false;
            this.barProgress.Size = new System.Drawing.Size(216, 216);
            this.barProgress.TabIndex = 3;
            this.barProgress.TabStop = false;
            this.barProgress.TextColor = System.Drawing.Color.Red;
            this.barProgress.TextSize = 25;
            this.barProgress.UnFilledColor = System.Drawing.Color.Red;
            this.barProgress.UnfilledThickness = 24;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.White;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.ForeColor = System.Drawing.Color.Black;
            this.txtArea.Location = new System.Drawing.Point(130, 236);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(90, 15);
            this.txtArea.TabIndex = 4;
            this.txtArea.TabStop = false;
            this.txtArea.Text = "PROVEEDORES";
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormLoadingPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.ControlBox = false;
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.barProgress);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoadingPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLoadingPage";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IDEVStudioUI.Controls.IDEVStudioUIPictureBox picBack;
        private System.Windows.Forms.PictureBox picLoading;
        private XanderUI.XUICircleProgressBar barProgress;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtArea;
    }
}