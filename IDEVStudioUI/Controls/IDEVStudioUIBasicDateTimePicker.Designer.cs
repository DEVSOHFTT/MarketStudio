
namespace IDEVStudioUI.Controls
{
    partial class IDEVStudioUIBasicDateTimePicker
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDtp = new System.Windows.Forms.TableLayoutPanel();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.pnlPic = new System.Windows.Forms.Panel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.pnlDtp.SuspendLayout();
            this.pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDtp
            // 
            this.pnlDtp.ColumnCount = 3;
            this.pnlDtp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlDtp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlDtp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlDtp.Controls.Add(this.txtAño, 2, 0);
            this.pnlDtp.Controls.Add(this.txtMes, 1, 0);
            this.pnlDtp.Controls.Add(this.txtDia, 0, 0);
            this.pnlDtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDtp.Location = new System.Drawing.Point(0, 0);
            this.pnlDtp.Name = "pnlDtp";
            this.pnlDtp.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pnlDtp.RowCount = 1;
            this.pnlDtp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDtp.Size = new System.Drawing.Size(140, 32);
            this.pnlDtp.TabIndex = 0;
            // 
            // txtAño
            // 
            this.txtAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAño.ForeColor = System.Drawing.Color.White;
            this.txtAño.Location = new System.Drawing.Point(96, 6);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(38, 19);
            this.txtAño.TabIndex = 2;
            this.txtAño.Text = "22";
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAño.TextChanged += new System.EventHandler(this.OnValueChanged);
            this.txtAño.Enter += new System.EventHandler(this.txtAño_Enter);
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtAño.Leave += new System.EventHandler(this.txtAño_Leave);
            // 
            // txtMes
            // 
            this.txtMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMes.ForeColor = System.Drawing.Color.White;
            this.txtMes.Location = new System.Drawing.Point(51, 6);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(38, 19);
            this.txtMes.TabIndex = 1;
            this.txtMes.Text = "01";
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.TextChanged += new System.EventHandler(this.OnValueChanged);
            this.txtMes.Enter += new System.EventHandler(this.txtMes_Enter);
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtMes.Leave += new System.EventHandler(this.txtMes_Leave);
            // 
            // txtDia
            // 
            this.txtDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDia.ForeColor = System.Drawing.Color.White;
            this.txtDia.Location = new System.Drawing.Point(6, 6);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(39, 19);
            this.txtDia.TabIndex = 0;
            this.txtDia.Text = "01";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia.TextChanged += new System.EventHandler(this.OnValueChanged);
            this.txtDia.Enter += new System.EventHandler(this.txtDia_Enter);
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtDia.Leave += new System.EventHandler(this.txtDia_Leave);
            // 
            // pnlPic
            // 
            this.pnlPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPic.Controls.Add(this.picIcono);
            this.pnlPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPic.Location = new System.Drawing.Point(140, 0);
            this.pnlPic.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Padding = new System.Windows.Forms.Padding(6);
            this.pnlPic.Size = new System.Drawing.Size(30, 32);
            this.pnlPic.TabIndex = 1;
            // 
            // picIcono
            // 
            this.picIcono.BackgroundImage = global::IDEVStudioUI.Properties.Resources.calendarW;
            this.picIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcono.Location = new System.Drawing.Point(6, 6);
            this.picIcono.Margin = new System.Windows.Forms.Padding(5);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(18, 20);
            this.picIcono.TabIndex = 2;
            this.picIcono.TabStop = false;
            // 
            // IDEVStudioUIBasicDateTimePicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnlDtp);
            this.Controls.Add(this.pnlPic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "IDEVStudioUIBasicDateTimePicker";
            this.Size = new System.Drawing.Size(170, 32);
            this.pnlDtp.ResumeLayout(false);
            this.pnlDtp.PerformLayout();
            this.pnlPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlDtp;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
    }
}
