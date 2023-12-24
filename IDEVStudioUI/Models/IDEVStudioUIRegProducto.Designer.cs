namespace IDEVStudioUI.Models
{
    partial class IDEVStudioUIRegProducto
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
            this.pnlProducto = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrecioVenta = new System.Windows.Forms.Panel();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.pnlPrecioCompra = new System.Windows.Forms.Panel();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pnlCod = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.pnlProducto.SuspendLayout();
            this.pnlPrecioVenta.SuspendLayout();
            this.pnlPrecioCompra.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlCod.SuspendLayout();
            this.pnlNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlProducto.ColumnCount = 6;
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.67327F));
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83168F));
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83168F));
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83168F));
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83168F));
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlProducto.Controls.Add(this.pnlPrecioVenta, 4, 0);
            this.pnlProducto.Controls.Add(this.pnlPrecioCompra, 3, 0);
            this.pnlProducto.Controls.Add(this.pnlStock, 2, 0);
            this.pnlProducto.Controls.Add(this.pnlCod, 1, 0);
            this.pnlProducto.Controls.Add(this.pnlNombre, 0, 0);
            this.pnlProducto.Controls.Add(this.btnAgregarProducto, 5, 0);
            this.pnlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.RowCount = 1;
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlProducto.Size = new System.Drawing.Size(512, 30);
            this.pnlProducto.TabIndex = 2;
            this.pnlProducto.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlProducto.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlPrecioVenta
            // 
            this.pnlPrecioVenta.Controls.Add(this.txtPrecioVenta);
            this.pnlPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrecioVenta.Location = new System.Drawing.Point(403, 3);
            this.pnlPrecioVenta.Name = "pnlPrecioVenta";
            this.pnlPrecioVenta.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlPrecioVenta.Size = new System.Drawing.Size(75, 24);
            this.pnlPrecioVenta.TabIndex = 10;
            this.pnlPrecioVenta.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlPrecioVenta.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.txtPrecioVenta.Location = new System.Drawing.Point(0, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(75, 18);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.Text = "$ 100";
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioVenta.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtPrecioVenta.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlPrecioCompra
            // 
            this.pnlPrecioCompra.Controls.Add(this.txtPrecioCompra);
            this.pnlPrecioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrecioCompra.Location = new System.Drawing.Point(322, 3);
            this.pnlPrecioCompra.Name = "pnlPrecioCompra";
            this.pnlPrecioCompra.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlPrecioCompra.Size = new System.Drawing.Size(75, 24);
            this.pnlPrecioCompra.TabIndex = 9;
            this.pnlPrecioCompra.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlPrecioCompra.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.txtPrecioCompra.Location = new System.Drawing.Point(0, 2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.ReadOnly = true;
            this.txtPrecioCompra.Size = new System.Drawing.Size(75, 18);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.Text = "$ 100";
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioCompra.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtPrecioCompra.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.txtStock);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(241, 3);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlStock.Size = new System.Drawing.Size(75, 24);
            this.pnlStock.TabIndex = 8;
            this.pnlStock.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlStock.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStock.ForeColor = System.Drawing.Color.White;
            this.txtStock.Location = new System.Drawing.Point(0, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(75, 18);
            this.txtStock.TabIndex = 3;
            this.txtStock.Text = "15";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtStock.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlCod
            // 
            this.pnlCod.Controls.Add(this.txtCodigo);
            this.pnlCod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCod.Location = new System.Drawing.Point(160, 3);
            this.pnlCod.Name = "pnlCod";
            this.pnlCod.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlCod.Size = new System.Drawing.Size(75, 24);
            this.pnlCod.TabIndex = 7;
            this.pnlCod.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlCod.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(0, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(75, 18);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Text = "0005000";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtCodigo.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // pnlNombre
            // 
            this.pnlNombre.Controls.Add(this.txtProducto);
            this.pnlNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNombre.Location = new System.Drawing.Point(3, 3);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlNombre.Size = new System.Drawing.Size(151, 24);
            this.pnlNombre.TabIndex = 6;
            this.pnlNombre.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.pnlNombre.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(0, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(151, 18);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Text = "Coca Cola 1/2L";
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProducto.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.txtProducto.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackgroundImage = global::IDEVStudioUI.Properties.Resources.addP;
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Location = new System.Drawing.Point(484, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(25, 24);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btnAgregarProducto.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // IDEVStudioUIRegProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.Controls.Add(this.pnlProducto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IDEVStudioUIRegProducto";
            this.Size = new System.Drawing.Size(512, 30);
            this.Enter += new System.EventHandler(this.IDEVStudioUIRegProducto_Enter);
            this.pnlProducto.ResumeLayout(false);
            this.pnlPrecioVenta.ResumeLayout(false);
            this.pnlPrecioVenta.PerformLayout();
            this.pnlPrecioCompra.ResumeLayout(false);
            this.pnlPrecioCompra.PerformLayout();
            this.pnlStock.ResumeLayout(false);
            this.pnlStock.PerformLayout();
            this.pnlCod.ResumeLayout(false);
            this.pnlCod.PerformLayout();
            this.pnlNombre.ResumeLayout(false);
            this.pnlNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlProducto;
        private System.Windows.Forms.Panel pnlPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Panel pnlCod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Panel pnlPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        public System.Windows.Forms.Button btnAgregarProducto;
    }
}
