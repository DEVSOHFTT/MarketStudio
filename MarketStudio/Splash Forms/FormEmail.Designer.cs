namespace MarketStudio
{
    partial class FormEmail
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
            this.lstPaths = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtBody = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.txtAsunto = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.txtDestino = new IDEVStudioUI.Controls.IDEVStudioUITextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPaths
            // 
            this.lstPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lstPaths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.lstPaths, 3);
            this.lstPaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPaths.ForeColor = System.Drawing.Color.White;
            this.lstPaths.FormattingEnabled = true;
            this.lstPaths.ItemHeight = 17;
            this.lstPaths.Location = new System.Drawing.Point(3, 193);
            this.lstPaths.Name = "lstPaths";
            this.tableLayoutPanel1.SetRowSpan(this.lstPaths, 2);
            this.lstPaths.Size = new System.Drawing.Size(494, 70);
            this.lstPaths.TabIndex = 0;
            this.lstPaths.TabStop = false;
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
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MarketStudio.Properties.Resources.Compartir;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compartir detalle de venta";
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
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(3, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Adjuntar Archivo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(169, 269);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(160, 32);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar Archivo";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Recibo";
            this.openFileDialog.Filter = "(*.txt)|*.txt|(*.pdf)|*.pdf|(*.png)|*.png|(*.jpg)|*.jpg|All files (*.*)|*.*";
            this.openFileDialog.Title = "Seleccionar documento";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnEnviar, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBody, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAsunto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDestino, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnQuitar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lstPaths, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 305);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(335, 269);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(162, 32);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar Archivo";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtBody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtBody.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtBody.BorderRadius = 0;
            this.txtBody.BorderSize = 1;
            this.txtBody.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBody, 3);
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.ForeColor = System.Drawing.Color.White;
            this.txtBody.Location = new System.Drawing.Point(4, 80);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBody.PasswordChar = false;
            this.txtBody.PlaceholderColor = System.Drawing.Color.White;
            this.txtBody.PlaceholderText = "";
            this.txtBody.ReadOnly = false;
            this.tableLayoutPanel1.SetRowSpan(this.txtBody, 3);
            this.txtBody.ShowIcon = false;
            this.txtBody.Size = new System.Drawing.Size(492, 106);
            this.txtBody.TabIndex = 11;
            this.txtBody.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBody.Texts = "";
            this.txtBody.UnderlinedStyle = false;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtAsunto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtAsunto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtAsunto.BorderRadius = 0;
            this.txtAsunto.BorderSize = 1;
            this.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.txtAsunto, 3);
            this.txtAsunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.ForeColor = System.Drawing.Color.White;
            this.txtAsunto.Location = new System.Drawing.Point(4, 42);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsunto.Multiline = false;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAsunto.PasswordChar = false;
            this.txtAsunto.PlaceholderColor = System.Drawing.Color.White;
            this.txtAsunto.PlaceholderText = "";
            this.txtAsunto.ReadOnly = false;
            this.txtAsunto.ShowIcon = false;
            this.txtAsunto.Size = new System.Drawing.Size(492, 35);
            this.txtAsunto.TabIndex = 10;
            this.txtAsunto.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAsunto.Texts = "";
            this.txtAsunto.UnderlinedStyle = false;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDestino.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDestino.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.txtDestino.BorderRadius = 0;
            this.txtDestino.BorderSize = 1;
            this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDestino, 3);
            this.txtDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.Color.White;
            this.txtDestino.Location = new System.Drawing.Point(4, 4);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Multiline = false;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDestino.PasswordChar = false;
            this.txtDestino.PlaceholderColor = System.Drawing.Color.White;
            this.txtDestino.PlaceholderText = "";
            this.txtDestino.ReadOnly = false;
            this.txtDestino.ShowIcon = false;
            this.txtDestino.Size = new System.Drawing.Size(492, 35);
            this.txtDestino.TabIndex = 2;
            this.txtDestino.TexboxIcon = global::MarketStudio.Properties.Resources.Buscar;
            this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDestino.Texts = "";
            this.txtDestino.UnderlinedStyle = false;
            // 
            // FormEmail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPaths;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtBody;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtAsunto;
        private IDEVStudioUI.Controls.IDEVStudioUITextBox txtDestino;
        private System.Windows.Forms.Button btnEnviar;
    }
}