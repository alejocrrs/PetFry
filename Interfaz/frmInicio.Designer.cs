namespace Interfaz
{
    partial class frmInicio
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.pagClientes = new System.Windows.Forms.TabPage();
            this.flpClientes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClientesEliminar = new System.Windows.Forms.Button();
            this.btnClientesEditar = new System.Windows.Forms.Button();
            this.btnClientesAgregar = new System.Windows.Forms.Button();
            this.lvwClientes = new System.Windows.Forms.ListView();
            this.chdIdCliente = new System.Windows.Forms.ColumnHeader();
            this.chdDocumentoCliente = new System.Windows.Forms.ColumnHeader();
            this.chdNombreCliente = new System.Windows.Forms.ColumnHeader();
            this.chdDireccionCliente = new System.Windows.Forms.ColumnHeader();
            this.chdTelefonoCliente = new System.Windows.Forms.ColumnHeader();
            this.chdCorreoCliente = new System.Windows.Forms.ColumnHeader();
            this.pagMascotas = new System.Windows.Forms.TabPage();
            this.flpMascotas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMascotasEliminar = new System.Windows.Forms.Button();
            this.btnMascotasEditar = new System.Windows.Forms.Button();
            this.btnMascotasAgregar = new System.Windows.Forms.Button();
            this.lvwMascotas = new System.Windows.Forms.ListView();
            this.chdIdMascota = new System.Windows.Forms.ColumnHeader();
            this.chdNombreMascota = new System.Windows.Forms.ColumnHeader();
            this.chdPropietario = new System.Windows.Forms.ColumnHeader();
            this.chdAnimal = new System.Windows.Forms.ColumnHeader();
            this.chdRaza = new System.Windows.Forms.ColumnHeader();
            this.chdPeso = new System.Windows.Forms.ColumnHeader();
            this.chdColor = new System.Windows.Forms.ColumnHeader();
            this.chdNotas = new System.Windows.Forms.ColumnHeader();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.pagClientes.SuspendLayout();
            this.flpClientes.SuspendLayout();
            this.pagMascotas.SuspendLayout();
            this.flpMascotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.picLogo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tabOpciones, 0, 1);
            this.tlpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpPrincipal.Size = new System.Drawing.Size(960, 637);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::Interfaz.Properties.Resources.PetFry_Logo;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(954, 153);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.pagClientes);
            this.tabOpciones.Controls.Add(this.pagMascotas);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpciones.Location = new System.Drawing.Point(3, 162);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(954, 472);
            this.tabOpciones.TabIndex = 1;
            // 
            // pagClientes
            // 
            this.pagClientes.Controls.Add(this.flpClientes);
            this.pagClientes.Controls.Add(this.lvwClientes);
            this.pagClientes.Location = new System.Drawing.Point(4, 24);
            this.pagClientes.Name = "pagClientes";
            this.pagClientes.Padding = new System.Windows.Forms.Padding(3);
            this.pagClientes.Size = new System.Drawing.Size(946, 444);
            this.pagClientes.TabIndex = 0;
            this.pagClientes.Text = "Clientes";
            this.pagClientes.UseVisualStyleBackColor = true;
            // 
            // flpClientes
            // 
            this.flpClientes.Controls.Add(this.btnClientesEliminar);
            this.flpClientes.Controls.Add(this.btnClientesEditar);
            this.flpClientes.Controls.Add(this.btnClientesAgregar);
            this.flpClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpClientes.Location = new System.Drawing.Point(3, 3);
            this.flpClientes.Name = "flpClientes";
            this.flpClientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpClientes.Size = new System.Drawing.Size(940, 38);
            this.flpClientes.TabIndex = 1;
            this.flpClientes.Click += new System.EventHandler(this.flpClientes_Click);
            // 
            // btnClientesEliminar
            // 
            this.btnClientesEliminar.Enabled = false;
            this.btnClientesEliminar.Location = new System.Drawing.Point(862, 3);
            this.btnClientesEliminar.Name = "btnClientesEliminar";
            this.btnClientesEliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClientesEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesEliminar.TabIndex = 2;
            this.btnClientesEliminar.Text = "Eliminar";
            this.btnClientesEliminar.UseVisualStyleBackColor = true;
            this.btnClientesEliminar.Click += new System.EventHandler(this.btnClientesEliminar_Click);
            // 
            // btnClientesEditar
            // 
            this.btnClientesEditar.Enabled = false;
            this.btnClientesEditar.Location = new System.Drawing.Point(781, 3);
            this.btnClientesEditar.Name = "btnClientesEditar";
            this.btnClientesEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClientesEditar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesEditar.TabIndex = 1;
            this.btnClientesEditar.Text = "Editar";
            this.btnClientesEditar.UseVisualStyleBackColor = true;
            this.btnClientesEditar.Click += new System.EventHandler(this.btnClientesEditar_Click);
            // 
            // btnClientesAgregar
            // 
            this.btnClientesAgregar.Location = new System.Drawing.Point(700, 3);
            this.btnClientesAgregar.Name = "btnClientesAgregar";
            this.btnClientesAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClientesAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesAgregar.TabIndex = 0;
            this.btnClientesAgregar.Text = "Agregar";
            this.btnClientesAgregar.UseVisualStyleBackColor = true;
            this.btnClientesAgregar.Click += new System.EventHandler(this.btnClientesAgregar_Click);
            // 
            // lvwClientes
            // 
            this.lvwClientes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdCliente,
            this.chdDocumentoCliente,
            this.chdNombreCliente,
            this.chdTelefonoCliente,
            this.chdDireccionCliente,
            this.chdCorreoCliente});
            this.lvwClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwClientes.FullRowSelect = true;
            this.lvwClientes.Location = new System.Drawing.Point(3, 41);
            this.lvwClientes.MultiSelect = false;
            this.lvwClientes.Name = "lvwClientes";
            this.lvwClientes.Size = new System.Drawing.Size(940, 400);
            this.lvwClientes.TabIndex = 0;
            this.lvwClientes.TileSize = new System.Drawing.Size(3, 3);
            this.lvwClientes.UseCompatibleStateImageBehavior = false;
            this.lvwClientes.View = System.Windows.Forms.View.Details;
            this.lvwClientes.SelectedIndexChanged += new System.EventHandler(this.lvwClientes_SelectedIndexChanged);
            this.lvwClientes.DoubleClick += new System.EventHandler(this.btnClientesEditar_Click);
            // 
            // chdIdCliente
            // 
            this.chdIdCliente.Text = "Id";
            this.chdIdCliente.Width = 50;
            // 
            // chdDocumentoCliente
            // 
            this.chdDocumentoCliente.Text = "Documento";
            this.chdDocumentoCliente.Width = 100;
            // 
            // chdNombreCliente
            // 
            this.chdNombreCliente.Text = "Nombre completo";
            this.chdNombreCliente.Width = 250;
            // 
            // chdDireccionCliente
            // 
            this.chdDireccionCliente.Text = "Dirección de residencia";
            this.chdDireccionCliente.Width = 200;
            // 
            // chdTelefonoCliente
            // 
            this.chdTelefonoCliente.Text = "Teléfono";
            this.chdTelefonoCliente.Width = 110;
            // 
            // chdCorreoCliente
            // 
            this.chdCorreoCliente.Text = "Correo electrónico";
            this.chdCorreoCliente.Width = 220;
            // 
            // pagMascotas
            // 
            this.pagMascotas.Controls.Add(this.flpMascotas);
            this.pagMascotas.Controls.Add(this.lvwMascotas);
            this.pagMascotas.Location = new System.Drawing.Point(4, 24);
            this.pagMascotas.Name = "pagMascotas";
            this.pagMascotas.Padding = new System.Windows.Forms.Padding(3);
            this.pagMascotas.Size = new System.Drawing.Size(946, 444);
            this.pagMascotas.TabIndex = 5;
            this.pagMascotas.Text = "Mascotas";
            this.pagMascotas.UseVisualStyleBackColor = true;
            // 
            // flpMascotas
            // 
            this.flpMascotas.Controls.Add(this.btnMascotasEliminar);
            this.flpMascotas.Controls.Add(this.btnMascotasEditar);
            this.flpMascotas.Controls.Add(this.btnMascotasAgregar);
            this.flpMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMascotas.Location = new System.Drawing.Point(3, 3);
            this.flpMascotas.Name = "flpMascotas";
            this.flpMascotas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpMascotas.Size = new System.Drawing.Size(940, 38);
            this.flpMascotas.TabIndex = 1;
            this.flpMascotas.Click += new System.EventHandler(this.flpMascotas_Click);
            // 
            // btnMascotasEliminar
            // 
            this.btnMascotasEliminar.Enabled = false;
            this.btnMascotasEliminar.Location = new System.Drawing.Point(862, 3);
            this.btnMascotasEliminar.Name = "btnMascotasEliminar";
            this.btnMascotasEliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMascotasEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnMascotasEliminar.TabIndex = 2;
            this.btnMascotasEliminar.Text = "Eliminar";
            this.btnMascotasEliminar.UseVisualStyleBackColor = true;
            this.btnMascotasEliminar.Click += new System.EventHandler(this.btnMascotasEliminar_Click);
            // 
            // btnMascotasEditar
            // 
            this.btnMascotasEditar.Enabled = false;
            this.btnMascotasEditar.Location = new System.Drawing.Point(781, 3);
            this.btnMascotasEditar.Name = "btnMascotasEditar";
            this.btnMascotasEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMascotasEditar.Size = new System.Drawing.Size(75, 23);
            this.btnMascotasEditar.TabIndex = 1;
            this.btnMascotasEditar.Text = "Editar";
            this.btnMascotasEditar.UseVisualStyleBackColor = true;
            this.btnMascotasEditar.Click += new System.EventHandler(this.btnMascotasEditar_Click);
            // 
            // btnMascotasAgregar
            // 
            this.btnMascotasAgregar.Location = new System.Drawing.Point(700, 3);
            this.btnMascotasAgregar.Name = "btnMascotasAgregar";
            this.btnMascotasAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMascotasAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnMascotasAgregar.TabIndex = 0;
            this.btnMascotasAgregar.Text = "Agregar";
            this.btnMascotasAgregar.UseVisualStyleBackColor = true;
            this.btnMascotasAgregar.Click += new System.EventHandler(this.btnMascotasAgregar_Click);
            // 
            // lvwMascotas
            // 
            this.lvwMascotas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwMascotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdMascota,
            this.chdNombreMascota,
            this.chdPropietario,
            this.chdAnimal,
            this.chdRaza,
            this.chdPeso,
            this.chdColor,
            this.chdNotas});
            this.lvwMascotas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwMascotas.FullRowSelect = true;
            this.lvwMascotas.Location = new System.Drawing.Point(3, 41);
            this.lvwMascotas.MultiSelect = false;
            this.lvwMascotas.Name = "lvwMascotas";
            this.lvwMascotas.Size = new System.Drawing.Size(940, 400);
            this.lvwMascotas.TabIndex = 0;
            this.lvwMascotas.TileSize = new System.Drawing.Size(3, 3);
            this.lvwMascotas.UseCompatibleStateImageBehavior = false;
            this.lvwMascotas.View = System.Windows.Forms.View.Details;
            this.lvwMascotas.SelectedIndexChanged += new System.EventHandler(this.lvwMascotas_SelectedIndexChanged);
            // 
            // chdIdMascota
            // 
            this.chdIdMascota.Text = "Id";
            this.chdIdMascota.Width = 50;
            // 
            // chdNombreMascota
            // 
            this.chdNombreMascota.Text = "Nombre";
            this.chdNombreMascota.Width = 100;
            // 
            // chdPropietario
            // 
            this.chdPropietario.Text = "Propietario (Documento)";
            this.chdPropietario.Width = 150;
            // 
            // chdAnimal
            // 
            this.chdAnimal.Text = "Animal";
            this.chdAnimal.Width = 80;
            // 
            // chdRaza
            // 
            this.chdRaza.Text = "Raza";
            this.chdRaza.Width = 120;
            // 
            // chdPeso
            // 
            this.chdPeso.Text = "Peso (kg)";
            this.chdPeso.Width = 70;
            // 
            // chdColor
            // 
            this.chdColor.Text = "Color";
            this.chdColor.Width = 100;
            // 
            // chdNotas
            // 
            this.chdNotas.Text = "Notas u observaciones";
            this.chdNotas.Width = 250;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetFry - Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabOpciones.ResumeLayout(false);
            this.pagClientes.ResumeLayout(false);
            this.flpClientes.ResumeLayout(false);
            this.pagMascotas.ResumeLayout(false);
            this.flpMascotas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private PictureBox picLogo;
        private TabControl tabOpciones;
        private TabPage pagClientes;
        private FlowLayoutPanel flpClientes;
        private Button btnClientesEliminar;
        private Button btnClientesEditar;
        private Button btnClientesAgregar;
        public ListView lvwClientes;
        private ColumnHeader chdIdCliente;
        private ColumnHeader chdDocumentoCliente;
        private ColumnHeader chdNombreCliente;
        private ColumnHeader chdDireccionCliente;
        private ColumnHeader chdTelefonoCliente;
        private ColumnHeader chdCorreoCliente;
        private TabPage pagMascotas;
        private FlowLayoutPanel flpMascotas;
        private Button btnMascotasEliminar;
        private Button btnMascotasEditar;
        private Button btnMascotasAgregar;
        public ListView lvwMascotas;
        private ColumnHeader chdIdMascota;
        private ColumnHeader chdNombreMascota;
        private ColumnHeader chdPropietario;
        private ColumnHeader chdAnimal;
        private ColumnHeader chdRaza;
        private ColumnHeader chdPeso;
        private ColumnHeader columnHeader2;
        private ColumnHeader chdColor;
        private ColumnHeader chdNotas;
    }
}