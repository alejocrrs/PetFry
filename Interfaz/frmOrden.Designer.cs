namespace Interfaz
{
    partial class frmOrden
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
            this.tlpFormMascota = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.tlpFormMascota.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFormMascota
            // 
            this.tlpFormMascota.ColumnCount = 2;
            this.tlpFormMascota.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpFormMascota.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFormMascota.Controls.Add(this.txtNotas, 1, 5);
            this.tlpFormMascota.Controls.Add(this.lblNotas, 0, 5);
            this.tlpFormMascota.Controls.Add(this.lblTipo, 0, 2);
            this.tlpFormMascota.Controls.Add(this.lblArticulos, 0, 3);
            this.tlpFormMascota.Controls.Add(this.lblValor, 0, 4);
            this.tlpFormMascota.Controls.Add(this.cboTipo, 1, 2);
            this.tlpFormMascota.Controls.Add(this.flpOpciones, 1, 6);
            this.tlpFormMascota.Controls.Add(this.numValor, 1, 4);
            this.tlpFormMascota.Controls.Add(this.lblMascota, 0, 1);
            this.tlpFormMascota.Controls.Add(this.lblCliente, 0, 0);
            this.tlpFormMascota.Controls.Add(this.txtMascota, 1, 1);
            this.tlpFormMascota.Controls.Add(this.txtCliente, 1, 0);
            this.tlpFormMascota.Controls.Add(this.btnArticulos, 1, 3);
            this.tlpFormMascota.Location = new System.Drawing.Point(12, 12);
            this.tlpFormMascota.Name = "tlpFormMascota";
            this.tlpFormMascota.RowCount = 7;
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFormMascota.Size = new System.Drawing.Size(310, 257);
            this.tlpFormMascota.TabIndex = 2;
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(83, 158);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.PlaceholderText = "Observaciones (Opcional)";
            this.txtNotas.Size = new System.Drawing.Size(224, 64);
            this.txtNotas.TabIndex = 6;
            // 
            // lblNotas
            // 
            this.lblNotas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(39, 182);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 15);
            this.lblNotas.TabIndex = 15;
            this.lblNotas.Text = "Notas";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(47, 72);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblArticulos
            // 
            this.lblArticulos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Location = new System.Drawing.Point(23, 102);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(54, 15);
            this.lblArticulos.TabIndex = 3;
            this.lblArticulos.Text = "Artículos";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(17, 132);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(60, 15);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor total";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Producto",
            "Servicio"});
            this.cboTipo.Location = new System.Drawing.Point(83, 68);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(224, 23);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.Tag = "";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // flpOpciones
            // 
            this.flpOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Location = new System.Drawing.Point(83, 228);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(224, 26);
            this.flpOpciones.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(146, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(65, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            this.numValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numValor.DecimalPlaces = 2;
            this.numValor.Enabled = false;
            this.numValor.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(83, 128);
            this.numValor.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.ReadOnly = true;
            this.numValor.Size = new System.Drawing.Size(224, 23);
            this.numValor.TabIndex = 5;
            this.numValor.ThousandsSeparator = true;
            // 
            // lblMascota
            // 
            this.lblMascota.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(25, 40);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(52, 15);
            this.lblMascota.TabIndex = 0;
            this.lblMascota.Text = "Mascota";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(33, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // txtMascota
            // 
            this.txtMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMascota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMascota.Enabled = false;
            this.txtMascota.Location = new System.Drawing.Point(83, 36);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.PlaceholderText = "Nombre de la mascota (si es un servicio)";
            this.txtMascota.Size = new System.Drawing.Size(224, 23);
            this.txtMascota.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(83, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Documento del propietario";
            this.txtCliente.Size = new System.Drawing.Size(224, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArticulos.Location = new System.Drawing.Point(83, 98);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(224, 23);
            this.btnArticulos.TabIndex = 16;
            this.btnArticulos.Text = "Seleccionar artículos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // frmOrden
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.tlpFormMascota);
            this.MaximizeBox = false;
            this.Name = "frmOrden";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar orden";
            this.tlpFormMascota.ResumeLayout(false);
            this.tlpFormMascota.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpFormMascota;
        private TextBox txtNotas;
        private Label lblNotas;
        private TextBox txtCliente;
        private Label lblMascota;
        private Label lblCliente;
        private Label lblTipo;
        private Label lblArticulos;
        private Label lblValor;
        private TextBox txtMascota;
        private ComboBox cboTipo;
        private FlowLayoutPanel flpOpciones;
        private Button btnAgregar;
        private Button btnCancelar;
        private NumericUpDown numValor;
        private Button btnArticulos;
    }
}