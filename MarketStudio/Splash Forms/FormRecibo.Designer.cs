namespace MarketStudio
{
    partial class FormRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecibo));
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlContedor = new System.Windows.Forms.Panel();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.pnlMontos = new System.Windows.Forms.Panel();
            this.txtInteres = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.txtDescuento = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.txtSubTotal = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuntoVenta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idevStudioUITextBox1 = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.cboIvas = new System.Windows.Forms.ComboBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblHoraFecha = new System.Windows.Forms.Label();
            this.pnlContedor.SuspendLayout();
            this.pnlMontos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto total";
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "Recibo";
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.UseAntiAlias = true;
            this.printPreviewDialog.Visible = false;
            // 
            // pnlContedor
            // 
            this.pnlContedor.AutoSize = true;
            this.pnlContedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContedor.Controls.Add(this.pnlDetalles);
            this.pnlContedor.Controls.Add(this.pnlMontos);
            this.pnlContedor.Location = new System.Drawing.Point(44, 276);
            this.pnlContedor.MaximumSize = new System.Drawing.Size(729, 745);
            this.pnlContedor.MinimumSize = new System.Drawing.Size(729, 135);
            this.pnlContedor.Name = "pnlContedor";
            this.pnlContedor.Size = new System.Drawing.Size(729, 179);
            this.pnlContedor.TabIndex = 4;
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.AutoSize = true;
            this.pnlDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalles.Location = new System.Drawing.Point(0, 0);
            this.pnlDetalles.MinimumSize = new System.Drawing.Size(729, 26);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(729, 26);
            this.pnlDetalles.TabIndex = 5;
            // 
            // pnlMontos
            // 
            this.pnlMontos.Controls.Add(this.label2);
            this.pnlMontos.Controls.Add(this.txtInteres);
            this.pnlMontos.Controls.Add(this.txtDescuento);
            this.pnlMontos.Controls.Add(this.idevStudioUITextBox1);
            this.pnlMontos.Controls.Add(this.txtSubTotal);
            this.pnlMontos.Controls.Add(this.label4);
            this.pnlMontos.Controls.Add(this.label9);
            this.pnlMontos.Controls.Add(this.txtTotal);
            this.pnlMontos.Controls.Add(this.label6);
            this.pnlMontos.Controls.Add(this.label8);
            this.pnlMontos.Controls.Add(this.label7);
            this.pnlMontos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMontos.Location = new System.Drawing.Point(0, 26);
            this.pnlMontos.Name = "pnlMontos";
            this.pnlMontos.Size = new System.Drawing.Size(727, 151);
            this.pnlMontos.TabIndex = 4;
            // 
            // txtInteres
            // 
            this.txtInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInteres.BackColor = System.Drawing.Color.White;
            this.txtInteres.BorderColor = System.Drawing.Color.White;
            this.txtInteres.BorderFocusColor = System.Drawing.Color.White;
            this.txtInteres.BorderRadius = 0;
            this.txtInteres.BorderSize = 1;
            this.txtInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.ForeColor = System.Drawing.Color.Black;
            this.txtInteres.Location = new System.Drawing.Point(116, 1);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Multiline = false;
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtInteres.PasswordChar = false;
            this.txtInteres.PlaceholderColor = System.Drawing.Color.White;
            this.txtInteres.PlaceholderText = "";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.ShowIcon = false;
            this.txtInteres.Size = new System.Drawing.Size(144, 40);
            this.txtInteres.TabIndex = 0;
            this.txtInteres.TabStop = false;
            this.txtInteres.TexboxIcon = ((System.Drawing.Image)(resources.GetObject("txtInteres.TexboxIcon")));
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInteres.Texts = "0,00";
            this.txtInteres.UnderlinedStyle = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescuento.BackColor = System.Drawing.Color.White;
            this.txtDescuento.BorderColor = System.Drawing.Color.White;
            this.txtDescuento.BorderFocusColor = System.Drawing.Color.White;
            this.txtDescuento.BorderRadius = 0;
            this.txtDescuento.BorderSize = 1;
            this.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.Black;
            this.txtDescuento.Location = new System.Drawing.Point(116, 35);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescuento.PasswordChar = false;
            this.txtDescuento.PlaceholderColor = System.Drawing.Color.White;
            this.txtDescuento.PlaceholderText = "";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.ShowIcon = false;
            this.txtDescuento.Size = new System.Drawing.Size(144, 40);
            this.txtDescuento.TabIndex = 0;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.TexboxIcon = ((System.Drawing.Image)(resources.GetObject("txtDescuento.TexboxIcon")));
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescuento.Texts = "0,00";
            this.txtDescuento.UnderlinedStyle = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderFocusColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderRadius = 0;
            this.txtSubTotal.BorderSize = 1;
            this.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(114, 70);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Multiline = false;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubTotal.PasswordChar = false;
            this.txtSubTotal.PlaceholderColor = System.Drawing.Color.White;
            this.txtSubTotal.PlaceholderText = "";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.ShowIcon = false;
            this.txtSubTotal.Size = new System.Drawing.Size(235, 46);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TexboxIcon = ((System.Drawing.Image)(resources.GetObject("txtSubTotal.TexboxIcon")));
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubTotal.Texts = "0,00";
            this.txtSubTotal.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Interés";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descuento";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sub total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.White;
            this.txtTotal.BorderFocusColor = System.Drawing.Color.White;
            this.txtTotal.BorderRadius = 0;
            this.txtTotal.BorderSize = 1;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(487, 14);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.PlaceholderColor = System.Drawing.Color.White;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ShowIcon = false;
            this.txtTotal.Size = new System.Drawing.Size(235, 48);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            this.txtTotal.TexboxIcon = ((System.Drawing.Image)(resources.GetObject("txtTotal.TexboxIcon")));
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.Texts = "0,00";
            this.txtTotal.UnderlinedStyle = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(334, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(791, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(44, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 204);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblFechaE);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lblHoraFecha);
            this.panel2.Controls.Add(this.lblNroFactura);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblPuntoVenta);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(364, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 202);
            this.panel2.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(124, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "13/01/2023";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Fecha de la venta:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "CUIT:";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(232, 63);
            this.lblNroFactura.MaximumSize = new System.Drawing.Size(101, 30);
            this.lblNroFactura.MinimumSize = new System.Drawing.Size(101, 30);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(101, 30);
            this.lblNroFactura.TabIndex = 9;
            this.lblNroFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario que realizó la venta:";
            // 
            // lblPuntoVenta
            // 
            this.lblPuntoVenta.AutoSize = true;
            this.lblPuntoVenta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoVenta.Location = new System.Drawing.Point(113, 63);
            this.lblPuntoVenta.MaximumSize = new System.Drawing.Size(57, 30);
            this.lblPuntoVenta.MinimumSize = new System.Drawing.Size(57, 30);
            this.lblPuntoVenta.Name = "lblPuntoVenta";
            this.lblPuntoVenta.Size = new System.Drawing.Size(57, 30);
            this.lblPuntoVenta.TabIndex = 10;
            this.lblPuntoVenta.Text = "0001";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(193, 117);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(160, 22);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TabStop = false;
            // 
            // txtCuit
            // 
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.Location = new System.Drawing.Point(50, 95);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(182, 18);
            this.txtCuit.TabIndex = 5;
            this.txtCuit.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(167, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Comp. n°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Punto de venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "RECIBO";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtEmpresa);
            this.panel3.Controls.Add(this.lblIva);
            this.panel3.Controls.Add(this.lblCondicion);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtCuit);
            this.panel3.Controls.Add(this.txtRazonSocial);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtDomicilio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 202);
            this.panel3.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(11, 10);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(346, 50);
            this.txtEmpresa.TabIndex = 11;
            this.txtEmpresa.TabStop = false;
            this.txtEmpresa.Text = "POPPYS";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(141, 119);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(217, 51);
            this.txtDomicilio.TabIndex = 12;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.Text = "LAGO ARGENTINO 2000, BARRIO RESIDENCIAL SUD, CÓRDOBA, CÓRDOBA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Razón social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(94, 67);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(225, 22);
            this.txtRazonSocial.TabIndex = 14;
            this.txtRazonSocial.TabStop = false;
            this.txtRazonSocial.Text = "POPPYS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Domicilio comercial:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOCUMENTO NO VALIDO COMO FACTURA";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicion.Location = new System.Drawing.Point(7, 174);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(302, 17);
            this.lblCondicion.TabIndex = 8;
            this.lblCondicion.Text = "IVA Responsable Inscripto – Agente de Percepción";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Su vuelto";
            // 
            // idevStudioUITextBox1
            // 
            this.idevStudioUITextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idevStudioUITextBox1.BackColor = System.Drawing.Color.White;
            this.idevStudioUITextBox1.BorderColor = System.Drawing.Color.White;
            this.idevStudioUITextBox1.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.idevStudioUITextBox1.BorderRadius = 0;
            this.idevStudioUITextBox1.BorderSize = 1;
            this.idevStudioUITextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idevStudioUITextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idevStudioUITextBox1.ForeColor = System.Drawing.Color.Black;
            this.idevStudioUITextBox1.Location = new System.Drawing.Point(486, 70);
            this.idevStudioUITextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.idevStudioUITextBox1.Multiline = false;
            this.idevStudioUITextBox1.Name = "idevStudioUITextBox1";
            this.idevStudioUITextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.idevStudioUITextBox1.PasswordChar = false;
            this.idevStudioUITextBox1.PlaceholderColor = System.Drawing.Color.White;
            this.idevStudioUITextBox1.PlaceholderText = "";
            this.idevStudioUITextBox1.ReadOnly = false;
            this.idevStudioUITextBox1.ShowIcon = false;
            this.idevStudioUITextBox1.Size = new System.Drawing.Size(235, 46);
            this.idevStudioUITextBox1.TabIndex = 0;
            this.idevStudioUITextBox1.TabStop = false;
            this.idevStudioUITextBox1.TexboxIcon = ((System.Drawing.Image)(resources.GetObject("idevStudioUITextBox1.TexboxIcon")));
            this.idevStudioUITextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idevStudioUITextBox1.Texts = "0,00";
            this.idevStudioUITextBox1.UnderlinedStyle = false;
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaE.Location = new System.Drawing.Point(8, 153);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(273, 17);
            this.lblFechaE.TabIndex = 7;
            this.lblFechaE.Text = "Hora y Fecha de emisión del comprobante:";
            // 
            // cboIvas
            // 
            this.cboIvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboIvas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIvas.FormattingEnabled = true;
            this.cboIvas.Items.AddRange(new object[] {
            "IVA Responsable Inscripto",
            "IVA Responsable no Inscripto",
            "IVA no Responsable",
            "IVA Sujeto Exento",
            "Consumidor Final",
            "Responsable Monotributo",
            "Sujeto no Categorizado",
            "Proveedor del Exterior",
            "Cliente del Exterior",
            "IVA Liberado – Ley Nº 19.640",
            "IVA Responsable Inscripto – Agente de Percepción",
            "Pequeño Contribuyente Eventual",
            "Monotributista Social",
            "Pequeño Contribuyente Eventual Social"});
            this.cboIvas.Location = new System.Drawing.Point(420, 12);
            this.cboIvas.Name = "cboIvas";
            this.cboIvas.Size = new System.Drawing.Size(365, 29);
            this.cboIvas.TabIndex = 18;
            this.cboIvas.TabStop = false;
            this.cboIvas.SelectedValueChanged += new System.EventHandler(this.cboIvas_SelectedValueChanged);
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(7, 153);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(145, 17);
            this.lblIva.TabIndex = 8;
            this.lblIva.Text = "Condición ante el IVA:";
            // 
            // lblHoraFecha
            // 
            this.lblHoraFecha.AutoSize = true;
            this.lblHoraFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFecha.Location = new System.Drawing.Point(8, 172);
            this.lblHoraFecha.Name = "lblHoraFecha";
            this.lblHoraFecha.Size = new System.Drawing.Size(158, 21);
            this.lblHoraFecha.TabIndex = 8;
            this.lblHoraFecha.Text = "20:52:35 13/01/2023";
            // 
            // FormRecibo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 881);
            this.ControlBox = false;
            this.Controls.Add(this.cboIvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlContedor);
            this.Controls.Add(this.btnImprimir);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecibo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecibo";
            this.pnlContedor.ResumeLayout(false);
            this.pnlContedor.PerformLayout();
            this.pnlMontos.ResumeLayout(false);
            this.pnlMontos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtTotal;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Panel pnlContedor;
        private System.Windows.Forms.Panel pnlDetalles;
        private System.Windows.Forms.Panel pnlMontos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtInteres;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtDescuento;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtSubTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuntoVenta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox idevStudioUITextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblFechaE;
        private System.Windows.Forms.ComboBox cboIvas;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblHoraFecha;
    }
}