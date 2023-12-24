namespace MarketStudio
{
    partial class FormAgregarProductoCarrito
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlDetalleVenta = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDescuento = new System.Windows.Forms.Panel();
            this.txtDescuento = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlInteres = new System.Windows.Forms.Panel();
            this.txtInteres = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlCantidad = new System.Windows.Forms.Panel();
            this.txtCantidad = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUnidadMedida = new System.Windows.Forms.Panel();
            this.txtUnidadMedida = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.txtCategoria = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlProveedor = new System.Windows.Forms.Panel();
            this.txtProveedor = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlPrecioV = new System.Windows.Forms.Panel();
            this.txtPrecioV = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlPrecioC = new System.Windows.Forms.Panel();
            this.txtPrecioC = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.txtStock = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.txtCodigo = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.txtProducto = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.pnlTipoPago = new System.Windows.Forms.Panel();
            this.cboTiposPago = new IDEVStudioUI.Controls.IDEVStudioUIComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarCarrito = new IDEVStudioUI.Controls.IDEVStudioUIButton();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDetalle = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlDetalleVenta.SuspendLayout();
            this.pnlDescuento.SuspendLayout();
            this.pnlInteres.SuspendLayout();
            this.pnlCantidad.SuspendLayout();
            this.pnlUnidadMedida.SuspendLayout();
            this.pnlCategoria.SuspendLayout();
            this.pnlProveedor.SuspendLayout();
            this.pnlPrecioV.SuspendLayout();
            this.pnlPrecioC.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.pnlNombre.SuspendLayout();
            this.pnlTipoPago.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 40);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plSup_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MarketStudio.Properties.Resources.Ventas;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plSup_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar al carrito";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plSup_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::MarketStudio.Properties.Resources.Cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(471, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlDetalleVenta
            // 
            this.pnlDetalleVenta.ColumnCount = 4;
            this.pnlDetalleVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetalleVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetalleVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetalleVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetalleVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetalleVenta.Controls.Add(this.pnlDescuento, 3, 3);
            this.pnlDetalleVenta.Controls.Add(this.pnlInteres, 2, 3);
            this.pnlDetalleVenta.Controls.Add(this.pnlCantidad, 2, 0);
            this.pnlDetalleVenta.Controls.Add(this.pnlUnidadMedida, 0, 5);
            this.pnlDetalleVenta.Controls.Add(this.pnlCategoria, 0, 4);
            this.pnlDetalleVenta.Controls.Add(this.pnlProveedor, 0, 3);
            this.pnlDetalleVenta.Controls.Add(this.pnlPrecioV, 1, 2);
            this.pnlDetalleVenta.Controls.Add(this.pnlPrecioC, 0, 2);
            this.pnlDetalleVenta.Controls.Add(this.pnlStock, 1, 1);
            this.pnlDetalleVenta.Controls.Add(this.pnlCodigo, 0, 1);
            this.pnlDetalleVenta.Controls.Add(this.pnlNombre, 0, 0);
            this.pnlDetalleVenta.Controls.Add(this.pnlTipoPago, 2, 2);
            this.pnlDetalleVenta.Controls.Add(this.panel2, 2, 4);
            this.pnlDetalleVenta.Controls.Add(this.panel3, 0, 6);
            this.pnlDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalleVenta.Location = new System.Drawing.Point(0, 40);
            this.pnlDetalleVenta.Name = "pnlDetalleVenta";
            this.pnlDetalleVenta.RowCount = 7;
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDetalleVenta.Size = new System.Drawing.Size(500, 360);
            this.pnlDetalleVenta.TabIndex = 5;
            // 
            // pnlDescuento
            // 
            this.pnlDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDescuento.Controls.Add(this.txtDescuento);
            this.pnlDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescuento.Location = new System.Drawing.Point(378, 123);
            this.pnlDescuento.Name = "pnlDescuento";
            this.pnlDescuento.Size = new System.Drawing.Size(119, 34);
            this.pnlDescuento.TabIndex = 57;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDescuento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDescuento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDescuento.BorderRadius = 0;
            this.txtDescuento.BorderSize = 1;
            this.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.White;
            this.txtDescuento.Location = new System.Drawing.Point(0, 0);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescuento.PasswordChar = false;
            this.txtDescuento.PlaceholderColor = System.Drawing.Color.White;
            this.txtDescuento.PlaceholderText = "";
            this.txtDescuento.ReadOnly = false;
            this.txtDescuento.ShowIcon = false;
            this.txtDescuento.Size = new System.Drawing.Size(119, 35);
            this.txtDescuento.TabIndex = 1;
            this.txtDescuento.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.Texts = "0";
            this.toolTip.SetToolTip(this.txtDescuento, "% Descuento");
            this.txtDescuento.UnderlinedStyle = false;
            // 
            // pnlInteres
            // 
            this.pnlInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlInteres.Controls.Add(this.txtInteres);
            this.pnlInteres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInteres.Location = new System.Drawing.Point(253, 123);
            this.pnlInteres.Name = "pnlInteres";
            this.pnlInteres.Size = new System.Drawing.Size(119, 34);
            this.pnlInteres.TabIndex = 56;
            // 
            // txtInteres
            // 
            this.txtInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtInteres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtInteres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtInteres.BorderRadius = 0;
            this.txtInteres.BorderSize = 1;
            this.txtInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInteres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInteres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.ForeColor = System.Drawing.Color.White;
            this.txtInteres.Location = new System.Drawing.Point(0, 0);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Multiline = false;
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtInteres.PasswordChar = false;
            this.txtInteres.PlaceholderColor = System.Drawing.Color.White;
            this.txtInteres.PlaceholderText = "";
            this.txtInteres.ReadOnly = false;
            this.txtInteres.ShowIcon = false;
            this.txtInteres.Size = new System.Drawing.Size(119, 35);
            this.txtInteres.TabIndex = 1;
            this.txtInteres.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInteres.Texts = "0";
            this.txtInteres.UnderlinedStyle = false;
            // 
            // pnlCantidad
            // 
            this.pnlCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.pnlCantidad, 2);
            this.pnlCantidad.Controls.Add(this.txtCantidad);
            this.pnlCantidad.Controls.Add(this.label2);
            this.pnlCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCantidad.Location = new System.Drawing.Point(253, 3);
            this.pnlCantidad.Name = "pnlCantidad";
            this.pnlDetalleVenta.SetRowSpan(this.pnlCantidad, 2);
            this.pnlCantidad.Size = new System.Drawing.Size(244, 74);
            this.pnlCantidad.TabIndex = 54;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCantidad.BorderRadius = 0;
            this.txtCantidad.BorderSize = 1;
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(0, 29);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.White;
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.ReadOnly = false;
            this.txtCantidad.ShowIcon = false;
            this.txtCantidad.Size = new System.Drawing.Size(244, 45);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.Texts = "0,00";
            this.toolTip.SetToolTip(this.txtCantidad, "Cantidad");
            this.txtCantidad.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad del Producto";
            // 
            // pnlUnidadMedida
            // 
            this.pnlUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.pnlUnidadMedida, 2);
            this.pnlUnidadMedida.Controls.Add(this.txtUnidadMedida);
            this.pnlUnidadMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnidadMedida.Location = new System.Drawing.Point(3, 203);
            this.pnlUnidadMedida.Name = "pnlUnidadMedida";
            this.pnlUnidadMedida.Size = new System.Drawing.Size(244, 34);
            this.pnlUnidadMedida.TabIndex = 53;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtUnidadMedida.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtUnidadMedida.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtUnidadMedida.BorderRadius = 0;
            this.txtUnidadMedida.BorderSize = 1;
            this.txtUnidadMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUnidadMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadMedida.ForeColor = System.Drawing.Color.White;
            this.txtUnidadMedida.Location = new System.Drawing.Point(0, 0);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadMedida.Multiline = false;
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUnidadMedida.PasswordChar = false;
            this.txtUnidadMedida.PlaceholderColor = System.Drawing.Color.White;
            this.txtUnidadMedida.PlaceholderText = "";
            this.txtUnidadMedida.ReadOnly = true;
            this.txtUnidadMedida.ShowIcon = false;
            this.txtUnidadMedida.Size = new System.Drawing.Size(244, 35);
            this.txtUnidadMedida.TabIndex = 1;
            this.txtUnidadMedida.TabStop = false;
            this.txtUnidadMedida.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtUnidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnidadMedida.Texts = "";
            this.txtUnidadMedida.UnderlinedStyle = false;
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.pnlCategoria, 2);
            this.pnlCategoria.Controls.Add(this.txtCategoria);
            this.pnlCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoria.Location = new System.Drawing.Point(3, 163);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(244, 34);
            this.pnlCategoria.TabIndex = 52;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCategoria.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCategoria.BorderRadius = 0;
            this.txtCategoria.BorderSize = 1;
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(0, 0);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Multiline = false;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCategoria.PasswordChar = false;
            this.txtCategoria.PlaceholderColor = System.Drawing.Color.White;
            this.txtCategoria.PlaceholderText = "";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.ShowIcon = false;
            this.txtCategoria.Size = new System.Drawing.Size(244, 35);
            this.txtCategoria.TabIndex = 1;
            this.txtCategoria.TabStop = false;
            this.txtCategoria.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoria.Texts = "";
            this.txtCategoria.UnderlinedStyle = false;
            // 
            // pnlProveedor
            // 
            this.pnlProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.pnlProveedor, 2);
            this.pnlProveedor.Controls.Add(this.txtProveedor);
            this.pnlProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProveedor.Location = new System.Drawing.Point(3, 123);
            this.pnlProveedor.Name = "pnlProveedor";
            this.pnlProveedor.Size = new System.Drawing.Size(244, 34);
            this.pnlProveedor.TabIndex = 51;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProveedor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProveedor.BorderRadius = 0;
            this.txtProveedor.BorderSize = 1;
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(0, 0);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Multiline = false;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProveedor.PasswordChar = false;
            this.txtProveedor.PlaceholderColor = System.Drawing.Color.White;
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.ShowIcon = false;
            this.txtProveedor.Size = new System.Drawing.Size(244, 35);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.TabStop = false;
            this.txtProveedor.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProveedor.Texts = "";
            this.txtProveedor.UnderlinedStyle = false;
            // 
            // pnlPrecioV
            // 
            this.pnlPrecioV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlPrecioV.Controls.Add(this.txtPrecioV);
            this.pnlPrecioV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrecioV.Location = new System.Drawing.Point(128, 83);
            this.pnlPrecioV.Name = "pnlPrecioV";
            this.pnlPrecioV.Size = new System.Drawing.Size(119, 34);
            this.pnlPrecioV.TabIndex = 50;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioV.BorderRadius = 0;
            this.txtPrecioV.BorderSize = 1;
            this.txtPrecioV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.ForeColor = System.Drawing.Color.White;
            this.txtPrecioV.Location = new System.Drawing.Point(0, 0);
            this.txtPrecioV.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioV.Multiline = false;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioV.PasswordChar = false;
            this.txtPrecioV.PlaceholderColor = System.Drawing.Color.White;
            this.txtPrecioV.PlaceholderText = "";
            this.txtPrecioV.ReadOnly = true;
            this.txtPrecioV.ShowIcon = false;
            this.txtPrecioV.Size = new System.Drawing.Size(119, 35);
            this.txtPrecioV.TabIndex = 1;
            this.txtPrecioV.TabStop = false;
            this.txtPrecioV.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtPrecioV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioV.Texts = "";
            this.txtPrecioV.UnderlinedStyle = false;
            // 
            // pnlPrecioC
            // 
            this.pnlPrecioC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlPrecioC.Controls.Add(this.txtPrecioC);
            this.pnlPrecioC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrecioC.Location = new System.Drawing.Point(3, 83);
            this.pnlPrecioC.Name = "pnlPrecioC";
            this.pnlPrecioC.Size = new System.Drawing.Size(119, 34);
            this.pnlPrecioC.TabIndex = 49;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioC.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioC.BorderRadius = 0;
            this.txtPrecioC.BorderSize = 1;
            this.txtPrecioC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioC.ForeColor = System.Drawing.Color.White;
            this.txtPrecioC.Location = new System.Drawing.Point(0, 0);
            this.txtPrecioC.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioC.Multiline = false;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioC.PasswordChar = false;
            this.txtPrecioC.PlaceholderColor = System.Drawing.Color.White;
            this.txtPrecioC.PlaceholderText = "";
            this.txtPrecioC.ReadOnly = true;
            this.txtPrecioC.ShowIcon = false;
            this.txtPrecioC.Size = new System.Drawing.Size(119, 35);
            this.txtPrecioC.TabIndex = 1;
            this.txtPrecioC.TabStop = false;
            this.txtPrecioC.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtPrecioC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioC.Texts = "";
            this.txtPrecioC.UnderlinedStyle = false;
            // 
            // pnlStock
            // 
            this.pnlStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlStock.Controls.Add(this.txtStock);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(128, 43);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(119, 34);
            this.pnlStock.TabIndex = 48;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtStock.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtStock.BorderRadius = 0;
            this.txtStock.BorderSize = 1;
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.White;
            this.txtStock.Location = new System.Drawing.Point(0, 0);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStock.PasswordChar = false;
            this.txtStock.PlaceholderColor = System.Drawing.Color.White;
            this.txtStock.PlaceholderText = "";
            this.txtStock.ReadOnly = true;
            this.txtStock.ShowIcon = false;
            this.txtStock.Size = new System.Drawing.Size(119, 35);
            this.txtStock.TabIndex = 1;
            this.txtStock.TabStop = false;
            this.txtStock.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.Texts = "";
            this.txtStock.UnderlinedStyle = false;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlCodigo.Controls.Add(this.txtCodigo);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodigo.Location = new System.Drawing.Point(3, 43);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(119, 34);
            this.pnlCodigo.TabIndex = 47;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCodigo.BorderRadius = 0;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.White;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.ShowIcon = false;
            this.txtCodigo.Size = new System.Drawing.Size(119, 35);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // pnlNombre
            // 
            this.pnlNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.pnlNombre, 2);
            this.pnlNombre.Controls.Add(this.txtProducto);
            this.pnlNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNombre.Location = new System.Drawing.Point(3, 3);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(244, 34);
            this.pnlNombre.TabIndex = 46;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProducto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtProducto.BorderRadius = 0;
            this.txtProducto.BorderSize = 1;
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(0, 0);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Multiline = false;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProducto.PasswordChar = false;
            this.txtProducto.PlaceholderColor = System.Drawing.Color.White;
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.ShowIcon = false;
            this.txtProducto.Size = new System.Drawing.Size(244, 35);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TabStop = false;
            this.txtProducto.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProducto.Texts = "";
            this.txtProducto.UnderlinedStyle = false;
            // 
            // pnlTipoPago
            // 
            this.pnlTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.pnlTipoPago, 2);
            this.pnlTipoPago.Controls.Add(this.cboTiposPago);
            this.pnlTipoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTipoPago.Location = new System.Drawing.Point(253, 83);
            this.pnlTipoPago.Name = "pnlTipoPago";
            this.pnlTipoPago.Size = new System.Drawing.Size(244, 34);
            this.pnlTipoPago.TabIndex = 55;
            // 
            // cboTiposPago
            // 
            this.cboTiposPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.cboTiposPago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.cboTiposPago.BorderSize = 0;
            this.cboTiposPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTiposPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTiposPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTiposPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTiposPago.ForeColor = System.Drawing.Color.White;
            this.cboTiposPago.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.cboTiposPago.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.cboTiposPago.ListTextColor = System.Drawing.Color.White;
            this.cboTiposPago.Location = new System.Drawing.Point(0, 0);
            this.cboTiposPago.Name = "cboTiposPago";
            this.cboTiposPago.Size = new System.Drawing.Size(244, 34);
            this.cboTiposPago.TabIndex = 0;
            this.cboTiposPago.Texts = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.btnAgregarCarrito);
            this.panel2.Controls.Add(this.lblDescuento);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblInteres);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(253, 163);
            this.panel2.Name = "panel2";
            this.pnlDetalleVenta.SetRowSpan(this.panel2, 3);
            this.panel2.Size = new System.Drawing.Size(244, 194);
            this.panel2.TabIndex = 58;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.btnAgregarCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.btnAgregarCarrito.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.btnAgregarCarrito.BorderRadius = 20;
            this.btnAgregarCarrito.BorderSize = 0;
            this.btnAgregarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCarrito.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(37, 146);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(170, 40);
            this.btnAgregarCarrito.TabIndex = 2;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.TextColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.lblDescuento.Location = new System.Drawing.Point(120, 34);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(66, 25);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "$ 0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Descuento:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.lblInteres.Location = new System.Drawing.Point(120, 9);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(66, 25);
            this.lblInteres.TabIndex = 1;
            this.lblInteres.Text = "$ 0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Interés:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(12, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 45);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$ 0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total a Pagar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlDetalleVenta.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.txtDetalle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 114);
            this.panel3.TabIndex = 59;
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDetalle.ForeColor = System.Drawing.Color.White;
            this.txtDetalle.Location = new System.Drawing.Point(0, 26);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(244, 88);
            this.txtDetalle.TabIndex = 0;
            this.txtDetalle.Text = "";
            this.toolTip.SetToolTip(this.txtDetalle, "Detalle del producto.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Detalles del Producto";
            // 
            // FormAgregarProductoCarrito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnlDetalleVenta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarProductoCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarProductoCarrito";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlDetalleVenta.ResumeLayout(false);
            this.pnlDescuento.ResumeLayout(false);
            this.pnlInteres.ResumeLayout(false);
            this.pnlCantidad.ResumeLayout(false);
            this.pnlCantidad.PerformLayout();
            this.pnlUnidadMedida.ResumeLayout(false);
            this.pnlCategoria.ResumeLayout(false);
            this.pnlProveedor.ResumeLayout(false);
            this.pnlPrecioV.ResumeLayout(false);
            this.pnlPrecioC.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            this.pnlCodigo.ResumeLayout(false);
            this.pnlNombre.ResumeLayout(false);
            this.pnlTipoPago.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TableLayoutPanel pnlDetalleVenta;
        private System.Windows.Forms.Panel pnlStock;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtStock;
        private System.Windows.Forms.Panel pnlCodigo;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtCodigo;
        private System.Windows.Forms.Panel pnlNombre;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtProducto;
        private System.Windows.Forms.Panel pnlPrecioV;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtPrecioV;
        private System.Windows.Forms.Panel pnlPrecioC;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtPrecioC;
        private System.Windows.Forms.Panel pnlProveedor;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtProveedor;
        private System.Windows.Forms.Panel pnlCategoria;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtCategoria;
        private System.Windows.Forms.Panel pnlUnidadMedida;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtUnidadMedida;
        private System.Windows.Forms.Panel pnlCantidad;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTipoPago;
        private IDEVStudioUI.Controls.IDEVStudioUIComboBox cboTiposPago;
        private System.Windows.Forms.Panel pnlDescuento;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtDescuento;
        private System.Windows.Forms.Panel pnlInteres;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtInteres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label label6;
        private IDEVStudioUI.Controls.IDEVStudioUIButton btnAgregarCarrito;
        private System.Windows.Forms.ToolTip toolTip;
    }
}