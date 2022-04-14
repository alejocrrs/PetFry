namespace Interfaz
{
    partial class frmProducto
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
            this.tlpFormProducto = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.tlpFormProducto.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFormProducto
            // 
            this.tlpFormProducto.ColumnCount = 2;
            this.tlpFormProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpFormProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFormProducto.Controls.Add(this.txtNotas, 1, 2);
            this.tlpFormProducto.Controls.Add(this.lblNotas, 0, 2);
            this.tlpFormProducto.Controls.Add(this.lblNombre, 0, 0);
            this.tlpFormProducto.Controls.Add(this.lblValor, 0, 1);
            this.tlpFormProducto.Controls.Add(this.txtNombre, 1, 0);
            this.tlpFormProducto.Controls.Add(this.flpOpciones, 1, 3);
            this.tlpFormProducto.Controls.Add(this.numValor, 1, 1);
            this.tlpFormProducto.Location = new System.Drawing.Point(12, 12);
            this.tlpFormProducto.Name = "tlpFormProducto";
            this.tlpFormProducto.RowCount = 4;
            this.tlpFormProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpFormProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFormProducto.Size = new System.Drawing.Size(330, 167);
            this.tlpFormProducto.TabIndex = 4;
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(93, 63);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.PlaceholderText = "Observaciones (Opcional)";
            this.txtNotas.Size = new System.Drawing.Size(234, 64);
            this.txtNotas.TabIndex = 3;
            // 
            // lblNotas
            // 
            this.lblNotas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(49, 87);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 15);
            this.lblNotas.TabIndex = 15;
            this.lblNotas.Text = "Notas";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(10, 37);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(77, 15);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor unitario";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(93, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre distintivo";
            this.txtNombre.Size = new System.Drawing.Size(234, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // flpOpciones
            // 
            this.flpOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Location = new System.Drawing.Point(93, 133);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(234, 26);
            this.flpOpciones.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(156, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(75, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            this.numValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numValor.DecimalPlaces = 2;
            this.numValor.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(93, 33);
            this.numValor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(234, 23);
            this.numValor.TabIndex = 2;
            this.numValor.ThousandsSeparator = true;
            // 
            // frmProducto
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(354, 191);
            this.Controls.Add(this.tlpFormProducto);
            this.MaximizeBox = false;
            this.Name = "frmProducto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar producto";
            this.tlpFormProducto.ResumeLayout(false);
            this.tlpFormProducto.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpFormProducto;
        private TextBox txtNotas;
        private Label lblNotas;
        private Label lblNombre;
        private Label lblValor;
        private TextBox txtNombre;
        private FlowLayoutPanel flpOpciones;
        private Button btnAgregar;
        private Button btnCancelar;
        private NumericUpDown numValor;
    }
}