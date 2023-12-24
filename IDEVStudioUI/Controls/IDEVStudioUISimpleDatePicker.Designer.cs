
namespace IDEVStudioUI.Controls
{
    partial class IDEVStudioUISimpleDatePicker
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
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.btnIcono = new System.Windows.Forms.Button();
            this.pnlDatePicker = new System.Windows.Forms.TableLayoutPanel();
            this.btnBarra2 = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnBarra1 = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.pnlIcon.SuspendLayout();
            this.pnlDatePicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.btnIcono);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIcon.Location = new System.Drawing.Point(168, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Padding = new System.Windows.Forms.Padding(8);
            this.pnlIcon.Size = new System.Drawing.Size(32, 32);
            this.pnlIcon.TabIndex = 12;
            // 
            // btnIcono
            // 
            this.btnIcono.BackgroundImage = global::IDEVStudioUI.Properties.Resources.calendarW;
            this.btnIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIcono.FlatAppearance.BorderSize = 0;
            this.btnIcono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIcono.ForeColor = System.Drawing.Color.White;
            this.btnIcono.Location = new System.Drawing.Point(8, 8);
            this.btnIcono.Name = "btnIcono";
            this.btnIcono.Size = new System.Drawing.Size(16, 16);
            this.btnIcono.TabIndex = 12;
            this.btnIcono.TabStop = false;
            this.btnIcono.UseVisualStyleBackColor = true;
            this.btnIcono.Click += new System.EventHandler(this.MostrarCalendario_Click);
            // 
            // pnlDatePicker
            // 
            this.pnlDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDatePicker.ColumnCount = 5;
            this.pnlDatePicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.pnlDatePicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlDatePicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.pnlDatePicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlDatePicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.pnlDatePicker.Controls.Add(this.btnBarra2, 3, 0);
            this.pnlDatePicker.Controls.Add(this.btnMes, 2, 0);
            this.pnlDatePicker.Controls.Add(this.btnBarra1, 1, 0);
            this.pnlDatePicker.Controls.Add(this.btnDia, 0, 0);
            this.pnlDatePicker.Controls.Add(this.btnYear, 4, 0);
            this.pnlDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatePicker.Location = new System.Drawing.Point(0, 0);
            this.pnlDatePicker.Name = "pnlDatePicker";
            this.pnlDatePicker.RowCount = 1;
            this.pnlDatePicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDatePicker.Size = new System.Drawing.Size(168, 32);
            this.pnlDatePicker.TabIndex = 13;
            // 
            // btnBarra2
            // 
            this.btnBarra2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBarra2.FlatAppearance.BorderSize = 0;
            this.btnBarra2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarra2.ForeColor = System.Drawing.Color.White;
            this.btnBarra2.Location = new System.Drawing.Point(106, 3);
            this.btnBarra2.Name = "btnBarra2";
            this.btnBarra2.Size = new System.Drawing.Size(17, 26);
            this.btnBarra2.TabIndex = 10;
            this.btnBarra2.TabStop = false;
            this.btnBarra2.Text = "/";
            this.btnBarra2.UseVisualStyleBackColor = true;
            this.btnBarra2.Click += new System.EventHandler(this.MostrarCalendario_Click);
            // 
            // btnMes
            // 
            this.btnMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(66, 3);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(34, 26);
            this.btnMes.TabIndex = 9;
            this.btnMes.TabStop = false;
            this.btnMes.Text = "08";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.MostrarCalendario_Click);
            // 
            // btnBarra1
            // 
            this.btnBarra1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBarra1.FlatAppearance.BorderSize = 0;
            this.btnBarra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarra1.ForeColor = System.Drawing.Color.White;
            this.btnBarra1.Location = new System.Drawing.Point(43, 3);
            this.btnBarra1.Name = "btnBarra1";
            this.btnBarra1.Size = new System.Drawing.Size(17, 26);
            this.btnBarra1.TabIndex = 8;
            this.btnBarra1.TabStop = false;
            this.btnBarra1.Text = "/";
            this.btnBarra1.UseVisualStyleBackColor = true;
            this.btnBarra1.Click += new System.EventHandler(this.MostrarCalendario_Click);
            // 
            // btnDia
            // 
            this.btnDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDia.FlatAppearance.BorderSize = 0;
            this.btnDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDia.ForeColor = System.Drawing.Color.White;
            this.btnDia.Location = new System.Drawing.Point(3, 3);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(34, 26);
            this.btnDia.TabIndex = 7;
            this.btnDia.TabStop = false;
            this.btnDia.Text = "31";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.MostrarCalendario_Click);
            // 
            // btnYear
            // 
            this.btnYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYear.FlatAppearance.BorderSize = 0;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(129, 3);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(36, 26);
            this.btnYear.TabIndex = 6;
            this.btnYear.TabStop = false;
            this.btnYear.Text = "22";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.MostrarCalendario_Click);
            // 
            // IDEVStudioUISimpleDatePicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnlDatePicker);
            this.Controls.Add(this.pnlIcon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "IDEVStudioUISimpleDatePicker";
            this.Size = new System.Drawing.Size(200, 32);
            this.pnlIcon.ResumeLayout(false);
            this.pnlDatePicker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Button btnIcono;
        private System.Windows.Forms.TableLayoutPanel pnlDatePicker;
        private System.Windows.Forms.Button btnBarra2;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnBarra1;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnYear;
    }
}
