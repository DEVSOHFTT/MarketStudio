namespace IDEVStudioUI.Controls
{
    partial class IDEVStudioUITextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.icon = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = global::IDEVStudioUI.Properties.Resources.searchBlack;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Dock = System.Windows.Forms.DockStyle.Right;
            this.icon.Location = new System.Drawing.Point(224, 7);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(16, 16);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(10, 7);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(214, 15);
            this.textBox.TabIndex = 2;
            this.textBox.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // IDEVStudioUITextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.icon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IDEVStudioUITextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(250, 30);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox icon;
        public System.Windows.Forms.TextBox textBox;
    }
}
