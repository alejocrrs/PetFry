namespace Interfaz
{
    partial class frmListaArticulos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvwArticulos = new System.Windows.Forms.ListView();
            this.chdIdProducto = new System.Windows.Forms.ColumnHeader();
            this.chdNombreProducto = new System.Windows.Forms.ColumnHeader();
            this.chdValorProducto = new System.Windows.Forms.ColumnHeader();
            this.chdNotasProducto = new System.Windows.Forms.ColumnHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lvwArticulos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 337);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lvwArticulos
            // 
            this.lvwArticulos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwArticulos.CheckBoxes = true;
            this.lvwArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdProducto,
            this.chdNombreProducto,
            this.chdValorProducto,
            this.chdNotasProducto});
            this.lvwArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwArticulos.FullRowSelect = true;
            this.lvwArticulos.Location = new System.Drawing.Point(3, 3);
            this.lvwArticulos.Name = "lvwArticulos";
            this.lvwArticulos.Size = new System.Drawing.Size(504, 297);
            this.lvwArticulos.TabIndex = 1;
            this.lvwArticulos.TileSize = new System.Drawing.Size(3, 3);
            this.lvwArticulos.UseCompatibleStateImageBehavior = false;
            this.lvwArticulos.View = System.Windows.Forms.View.Details;
            // 
            // chdIdProducto
            // 
            this.chdIdProducto.Text = "Id";
            this.chdIdProducto.Width = 50;
            // 
            // chdNombreProducto
            // 
            this.chdNombreProducto.Text = "Nombre";
            this.chdNombreProducto.Width = 150;
            // 
            // chdValorProducto
            // 
            this.chdValorProducto.Text = "Valor (por unidad)";
            this.chdValorProducto.Width = 150;
            // 
            // chdNotasProducto
            // 
            this.chdNotasProducto.Text = "Notas u observaciones";
            this.chdNotasProducto.Width = 150;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 306);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(426, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(345, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmListaArticulos
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmListaArticulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de artículos disponibles";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGuardar;
        private Button btnCancelar;
        public ListView lvwArticulos;
        private ColumnHeader chdIdProducto;
        private ColumnHeader chdNombreProducto;
        private ColumnHeader chdValorProducto;
        private ColumnHeader chdNotasProducto;
    }
}