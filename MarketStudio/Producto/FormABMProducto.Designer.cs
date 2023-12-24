namespace MarketStudio
{
    partial class FormABMProducto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlProducto = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPrecioC = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.txtNombre = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.cboProveedores = new IDEVStudioUI.Controls.IDEVStudioUIComboBox();
            this.txtCodigo = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.txtPrecioV = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.cboUnidadMedida = new IDEVStudioUI.Controls.IDEVStudioUIComboBox();
            this.txtStock = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.cboCategorias = new IDEVStudioUI.Controls.IDEVStudioUIComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plSup_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MarketStudio.Properties.Resources.Productos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plSup_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(37, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Modificar Producto";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plSup_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::MarketStudio.Properties.Resources.Cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(321, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlProducto.ColumnCount = 2;
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlProducto.Controls.Add(this.btnGuardar, 1, 6);
            this.pnlProducto.Controls.Add(this.btnCancelar, 0, 6);
            this.pnlProducto.Controls.Add(this.txtPrecioC, 0, 2);
            this.pnlProducto.Controls.Add(this.txtNombre, 0, 0);
            this.pnlProducto.Controls.Add(this.cboProveedores, 0, 3);
            this.pnlProducto.Controls.Add(this.txtCodigo, 0, 1);
            this.pnlProducto.Controls.Add(this.txtPrecioV, 1, 2);
            this.pnlProducto.Controls.Add(this.cboUnidadMedida, 0, 5);
            this.pnlProducto.Controls.Add(this.txtStock, 1, 1);
            this.pnlProducto.Controls.Add(this.cboCategorias, 0, 4);
            this.pnlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducto.Location = new System.Drawing.Point(0, 40);
            this.pnlProducto.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.RowCount = 8;
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlProducto.Size = new System.Drawing.Size(350, 268);
            this.pnlProducto.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(178, 231);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(169, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.toolTip.SetToolTip(this.btnGuardar, "guardar cambios");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip.SetToolTip(this.btnCancelar, "cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.txtPrecioC.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.txtPrecioC.BorderRadius = 0;
            this.txtPrecioC.BorderSize = 1;
            this.txtPrecioC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioC.ForeColor = System.Drawing.Color.White;
            this.txtPrecioC.Location = new System.Drawing.Point(4, 80);
            this.txtPrecioC.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioC.Multiline = false;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioC.PasswordChar = false;
            this.txtPrecioC.PlaceholderColor = System.Drawing.Color.White;
            this.txtPrecioC.PlaceholderText = "";
            this.txtPrecioC.ReadOnly = false;
            this.txtPrecioC.ShowIcon = false;
            this.txtPrecioC.Size = new System.Drawing.Size(167, 31);
            this.txtPrecioC.TabIndex = 3;
            this.txtPrecioC.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtPrecioC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioC.Texts = "";
            this.txtPrecioC.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pnlProducto.SetColumnSpan(this.txtNombre, 2);
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(4, 4);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.White;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.ShowIcon = false;
            this.txtNombre.Size = new System.Drawing.Size(342, 31);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // cboProveedores
            // 
            this.cboProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.cboProveedores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.cboProveedores.BorderSize = 1;
            this.pnlProducto.SetColumnSpan(this.cboProveedores, 2);
            this.cboProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedores.ForeColor = System.Drawing.Color.White;
            this.cboProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.cboProveedores.Items.AddRange(new object[] {
            "Proveedor 1",
            "Proveedor 2",
            "BS Systems"});
            this.cboProveedores.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.cboProveedores.ListTextColor = System.Drawing.Color.White;
            this.cboProveedores.Location = new System.Drawing.Point(3, 117);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Padding = new System.Windows.Forms.Padding(1);
            this.cboProveedores.Size = new System.Drawing.Size(344, 32);
            this.cboProveedores.TabIndex = 5;
            this.cboProveedores.TabStop = false;
            this.cboProveedores.Texts = "Proveedor";
            this.toolTip.SetToolTip(this.cboProveedores, "proveedores");
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.txtCodigo.BorderRadius = 0;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(4, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.White;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.ShowIcon = false;
            this.txtCodigo.Size = new System.Drawing.Size(167, 31);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtPrecioV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.txtPrecioV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.txtPrecioV.BorderRadius = 0;
            this.txtPrecioV.BorderSize = 1;
            this.txtPrecioV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecioV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.ForeColor = System.Drawing.Color.White;
            this.txtPrecioV.Location = new System.Drawing.Point(179, 80);
            this.txtPrecioV.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioV.Multiline = false;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioV.PasswordChar = false;
            this.txtPrecioV.PlaceholderColor = System.Drawing.Color.White;
            this.txtPrecioV.PlaceholderText = "";
            this.txtPrecioV.ReadOnly = false;
            this.txtPrecioV.ShowIcon = false;
            this.txtPrecioV.Size = new System.Drawing.Size(167, 31);
            this.txtPrecioV.TabIndex = 4;
            this.txtPrecioV.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtPrecioV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioV.Texts = "";
            this.txtPrecioV.UnderlinedStyle = false;
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.cboUnidadMedida.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.cboUnidadMedida.BorderSize = 1;
            this.pnlProducto.SetColumnSpan(this.cboUnidadMedida, 2);
            this.cboUnidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUnidadMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadMedida.ForeColor = System.Drawing.Color.White;
            this.cboUnidadMedida.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.cboUnidadMedida.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.cboUnidadMedida.ListTextColor = System.Drawing.Color.White;
            this.cboUnidadMedida.Location = new System.Drawing.Point(3, 193);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Padding = new System.Windows.Forms.Padding(1);
            this.cboUnidadMedida.Size = new System.Drawing.Size(344, 32);
            this.cboUnidadMedida.TabIndex = 7;
            this.cboUnidadMedida.TabStop = false;
            this.cboUnidadMedida.Texts = "Unidad de medida";
            this.toolTip.SetToolTip(this.cboUnidadMedida, "unidades de medida");
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.txtStock.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.txtStock.BorderRadius = 0;
            this.txtStock.BorderSize = 1;
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.White;
            this.txtStock.Location = new System.Drawing.Point(179, 42);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStock.PasswordChar = false;
            this.txtStock.PlaceholderColor = System.Drawing.Color.White;
            this.txtStock.PlaceholderText = "";
            this.txtStock.ReadOnly = false;
            this.txtStock.ShowIcon = false;
            this.txtStock.Size = new System.Drawing.Size(167, 31);
            this.txtStock.TabIndex = 2;
            this.txtStock.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStock.Texts = "";
            this.txtStock.UnderlinedStyle = false;
            // 
            // cboCategorias
            // 
            this.cboCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.cboCategorias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.cboCategorias.BorderSize = 1;
            this.pnlProducto.SetColumnSpan(this.cboCategorias, 2);
            this.cboCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.ForeColor = System.Drawing.Color.White;
            this.cboCategorias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.cboCategorias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.cboCategorias.ListTextColor = System.Drawing.Color.White;
            this.cboCategorias.Location = new System.Drawing.Point(3, 155);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Padding = new System.Windows.Forms.Padding(1);
            this.cboCategorias.Size = new System.Drawing.Size(344, 32);
            this.cboCategorias.TabIndex = 6;
            this.cboCategorias.TabStop = false;
            this.cboCategorias.Texts = "Categoría";
            this.toolTip.SetToolTip(this.cboCategorias, "categorias");
            // 
            // FormABMProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 308);
            this.ControlBox = false;
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormABMProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormABMProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlProducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TableLayoutPanel pnlProducto;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtPrecioC;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtNombre;
        private IDEVStudioUI.Controls.IDEVStudioUIComboBox cboProveedores;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtCodigo;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtPrecioV;
        private IDEVStudioUI.Controls.IDEVStudioUIComboBox cboUnidadMedida;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtStock;
        private IDEVStudioUI.Controls.IDEVStudioUIComboBox cboCategorias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip toolTip;
    }
}