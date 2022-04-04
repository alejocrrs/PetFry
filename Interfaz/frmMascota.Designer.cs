namespace Interfaz
{
    partial class frmMascota
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
            this.tlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.tlpFormMascota = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpFormulario.SuspendLayout();
            this.tlpFormMascota.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFormulario
            // 
            this.tlpFormulario.ColumnCount = 2;
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFormulario.Controls.Add(this.txtCorreo, 1, 4);
            this.tlpFormulario.Location = new System.Drawing.Point(0, 0);
            this.tlpFormulario.Name = "tlpFormulario";
            this.tlpFormulario.RowCount = 5;
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFormulario.Size = new System.Drawing.Size(200, 100);
            this.tlpFormulario.TabIndex = 0;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Location = new System.Drawing.Point(123, 83);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(184, 23);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(123, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 23);
            this.txtTelefono.TabIndex = 8;
            // 
            // tlpFormMascota
            // 
            this.tlpFormMascota.ColumnCount = 2;
            this.tlpFormMascota.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpFormMascota.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFormMascota.Controls.Add(this.txtNotas, 1, 6);
            this.tlpFormMascota.Controls.Add(this.lblNotas, 0, 6);
            this.tlpFormMascota.Controls.Add(this.txtColor, 1, 5);
            this.tlpFormMascota.Controls.Add(this.lblColor, 0, 5);
            this.tlpFormMascota.Controls.Add(this.txtPeso, 1, 4);
            this.tlpFormMascota.Controls.Add(this.txtRaza, 1, 3);
            this.tlpFormMascota.Controls.Add(this.txtPropietario, 1, 1);
            this.tlpFormMascota.Controls.Add(this.lblDocumento, 0, 0);
            this.tlpFormMascota.Controls.Add(this.lblPropietario, 0, 1);
            this.tlpFormMascota.Controls.Add(this.lblAnimal, 0, 2);
            this.tlpFormMascota.Controls.Add(this.lblRaza, 0, 3);
            this.tlpFormMascota.Controls.Add(this.lblPeso, 0, 4);
            this.tlpFormMascota.Controls.Add(this.txtNombre, 1, 0);
            this.tlpFormMascota.Controls.Add(this.cboAnimal, 1, 2);
            this.tlpFormMascota.Controls.Add(this.flpOpciones, 1, 7);
            this.tlpFormMascota.Location = new System.Drawing.Point(12, 12);
            this.tlpFormMascota.Name = "tlpFormMascota";
            this.tlpFormMascota.RowCount = 8;
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpFormMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormMascota.Size = new System.Drawing.Size(310, 287);
            this.tlpFormMascota.TabIndex = 1;
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(83, 188);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.PlaceholderText = "Observaciones";
            this.txtNotas.Size = new System.Drawing.Size(224, 64);
            this.txtNotas.TabIndex = 16;
            // 
            // lblNotas
            // 
            this.lblNotas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(39, 212);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 15);
            this.lblNotas.TabIndex = 15;
            this.lblNotas.Text = "Notas";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Location = new System.Drawing.Point(83, 158);
            this.txtColor.Name = "txtColor";
            this.txtColor.PlaceholderText = "Color o colores distintivos";
            this.txtColor.Size = new System.Drawing.Size(224, 23);
            this.txtColor.TabIndex = 14;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(41, 162);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color";
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeso.Location = new System.Drawing.Point(83, 128);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PlaceholderText = "Peso en kilogramos";
            this.txtPeso.Size = new System.Drawing.Size(224, 23);
            this.txtPeso.TabIndex = 9;
            // 
            // txtRaza
            // 
            this.txtRaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaza.Location = new System.Drawing.Point(83, 98);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.PlaceholderText = "Raza (perro o gato)";
            this.txtRaza.Size = new System.Drawing.Size(224, 23);
            this.txtRaza.TabIndex = 8;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropietario.Location = new System.Drawing.Point(83, 36);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.PlaceholderText = "Documento del propietario";
            this.txtPropietario.Size = new System.Drawing.Size(224, 23);
            this.txtPropietario.TabIndex = 6;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(26, 7);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(51, 15);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Nombre";
            // 
            // lblPropietario
            // 
            this.lblPropietario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(12, 40);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(65, 15);
            this.lblPropietario.TabIndex = 1;
            this.lblPropietario.Text = "Propietario";
            // 
            // lblAnimal
            // 
            this.lblAnimal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(32, 72);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(45, 15);
            this.lblAnimal.TabIndex = 2;
            this.lblAnimal.Text = "Animal";
            // 
            // lblRaza
            // 
            this.lblRaza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(46, 102);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(31, 15);
            this.lblRaza.TabIndex = 3;
            this.lblRaza.Text = "Raza";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(45, 132);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(83, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre o apodo";
            this.txtNombre.Size = new System.Drawing.Size(224, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // cboAnimal
            // 
            this.cboAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cboAnimal.Location = new System.Drawing.Point(83, 68);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(184, 23);
            this.cboAnimal.TabIndex = 11;
            this.cboAnimal.Tag = "";
            // 
            // flpOpciones
            // 
            this.flpOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Location = new System.Drawing.Point(83, 258);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(224, 26);
            this.flpOpciones.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(146, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(65, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmMascota
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.tlpFormMascota);
            this.MaximizeBox = false;
            this.Name = "frmMascota";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar mascota";
            this.tlpFormulario.ResumeLayout(false);
            this.tlpFormulario.PerformLayout();
            this.tlpFormMascota.ResumeLayout(false);
            this.tlpFormMascota.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpFormulario;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TableLayoutPanel tlpFormMascota;
        private TextBox txtPeso;
        private TextBox txtRaza;
        private Label lblDocumento;
        private Label lblPropietario;
        private Label lblAnimal;
        private Label lblRaza;
        private Label lblPeso;
        private TextBox txtNombre;
        private TextBox txtPropietario;
        private ComboBox cboAnimal;
        private FlowLayoutPanel flpOpciones;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtNotas;
        private Label lblNotas;
        private TextBox txtColor;
        private Label lblColor;
    }
}