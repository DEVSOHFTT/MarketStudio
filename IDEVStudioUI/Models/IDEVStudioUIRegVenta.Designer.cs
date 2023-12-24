
namespace IDEVStudioUI.Controls
{
    partial class IDEVStudioUIRegVenta
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
            this.pnlVenta = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDescuento = new System.Windows.Forms.Panel();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.pnlInteres = new System.Windows.Forms.Panel();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.pnlMonto = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.pnlEmpleado = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlBtnVer = new System.Windows.Forms.Panel();
            this.btnVer = new System.Windows.Forms.PictureBox();
            this.pnlVenta.SuspendLayout();
            this.pnlDescuento.SuspendLayout();
            this.pnlInteres.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlMonto.SuspendLayout();
            this.pnlEmpleado.SuspendLayout();
            this.pnlBtnVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenta
            // 
            this.pnlVenta.ColumnCount = 6;
            this.pnlVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.pnlVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.pnlVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.pnlVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.pnlVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.pnlVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlVenta.Controls.Add(this.pnlDescuento, 2, 0);
            this.pnlVenta.Controls.Add(this.pnlInteres, 1, 0);
            this.pnlVenta.Controls.Add(this.pnlFecha, 0, 0);
            this.pnlVenta.Controls.Add(this.pnlMonto, 3, 0);
            this.pnlVenta.Controls.Add(this.pnlEmpleado, 4, 0);
            this.pnlVenta.Controls.Add(this.pnlBtnVer, 5, 0);
            this.pnlVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVenta.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.pnlVenta.Location = new System.Drawing.Point(0, 0);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.RowCount = 1;
            this.pnlVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVenta.Size = new System.Drawing.Size(580, 34);
            this.pnlVenta.TabIndex = 6;
            this.pnlVenta.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlVenta.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlDescuento
            // 
            this.pnlDescuento.Controls.Add(this.txtDescuento);
            this.pnlDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescuento.Location = new System.Drawing.Point(201, 3);
            this.pnlDescuento.Name = "pnlDescuento";
            this.pnlDescuento.Size = new System.Drawing.Size(93, 28);
            this.pnlDescuento.TabIndex = 4;
            this.pnlDescuento.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlDescuento.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.White;
            this.txtDescuento.Location = new System.Drawing.Point(0, 5);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(93, 18);
            this.txtDescuento.TabIndex = 1;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.Text = "$ 3500,00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtDescuento.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlInteres
            // 
            this.pnlInteres.Controls.Add(this.txtInteres);
            this.pnlInteres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInteres.Location = new System.Drawing.Point(102, 3);
            this.pnlInteres.Name = "pnlInteres";
            this.pnlInteres.Size = new System.Drawing.Size(93, 28);
            this.pnlInteres.TabIndex = 3;
            this.pnlInteres.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlInteres.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtInteres
            // 
            this.txtInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInteres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtInteres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.ForeColor = System.Drawing.Color.White;
            this.txtInteres.Location = new System.Drawing.Point(0, 5);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.Size = new System.Drawing.Size(93, 18);
            this.txtInteres.TabIndex = 1;
            this.txtInteres.TabStop = false;
            this.txtInteres.Text = "$ 3500,00";
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInteres.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtInteres.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.txtFecha);
            this.pnlFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFecha.Location = new System.Drawing.Point(3, 3);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(93, 28);
            this.pnlFecha.TabIndex = 1;
            this.pnlFecha.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlFecha.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(0, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(93, 18);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.TabStop = false;
            this.txtFecha.Text = "20/08/2022";
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtFecha.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlMonto
            // 
            this.pnlMonto.Controls.Add(this.txtMonto);
            this.pnlMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMonto.Location = new System.Drawing.Point(300, 3);
            this.pnlMonto.Name = "pnlMonto";
            this.pnlMonto.Size = new System.Drawing.Size(93, 28);
            this.pnlMonto.TabIndex = 1;
            this.pnlMonto.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlMonto.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(0, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(93, 18);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TabStop = false;
            this.txtMonto.Text = "$ 3500,00";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonto.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtMonto.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlEmpleado
            // 
            this.pnlEmpleado.Controls.Add(this.txtUsuario);
            this.pnlEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmpleado.Location = new System.Drawing.Point(399, 3);
            this.pnlEmpleado.Name = "pnlEmpleado";
            this.pnlEmpleado.Size = new System.Drawing.Size(148, 28);
            this.pnlEmpleado.TabIndex = 1;
            this.pnlEmpleado.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlEmpleado.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(0, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(148, 18);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtUsuario.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlBtnVer
            // 
            this.pnlBtnVer.Controls.Add(this.btnVer);
            this.pnlBtnVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtnVer.Location = new System.Drawing.Point(553, 3);
            this.pnlBtnVer.Name = "pnlBtnVer";
            this.pnlBtnVer.Padding = new System.Windows.Forms.Padding(6);
            this.pnlBtnVer.Size = new System.Drawing.Size(24, 28);
            this.pnlBtnVer.TabIndex = 2;
            this.pnlBtnVer.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlBtnVer.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = global::IDEVStudioUI.Properties.Resources.verRecibo;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVer.Location = new System.Drawing.Point(6, 6);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(12, 16);
            this.btnVer.TabIndex = 3;
            this.btnVer.TabStop = false;
            this.btnVer.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnVer.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // IDEVStudioUIRegVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.Controls.Add(this.pnlVenta);
            this.Name = "IDEVStudioUIRegVenta";
            this.Size = new System.Drawing.Size(580, 34);
            this.Enter += new System.EventHandler(this.IDEVStudioUIRegVenta_Enter);
            this.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.pnlVenta.ResumeLayout(false);
            this.pnlDescuento.ResumeLayout(false);
            this.pnlDescuento.PerformLayout();
            this.pnlInteres.ResumeLayout(false);
            this.pnlInteres.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.pnlMonto.ResumeLayout(false);
            this.pnlMonto.PerformLayout();
            this.pnlEmpleado.ResumeLayout(false);
            this.pnlEmpleado.PerformLayout();
            this.pnlBtnVer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Panel pnlMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Panel pnlEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TableLayoutPanel pnlVenta;
        private System.Windows.Forms.Panel pnlBtnVer;
        private System.Windows.Forms.Panel pnlDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Panel pnlInteres;
        private System.Windows.Forms.TextBox txtInteres;
        public System.Windows.Forms.PictureBox btnVer;
    }
}
