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
            this.chdTelefonoCliente = new System.Windows.Forms.ColumnHeader();
            this.chdDireccionCliente = new System.Windows.Forms.ColumnHeader();
            this.chdCorreoCliente = new System.Windows.Forms.ColumnHeader();
            this.pagMascotas = new System.Windows.Forms.TabPage();
            this.flpMascotas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMascotasEliminar = new System.Windows.Forms.Button();
            this.btnMascotasEditar = new System.Windows.Forms.Button();
            this.btnMascotasAgregar = new System.Windows.Forms.Button();
            this.lvwMascotas = new System.Windows.Forms.ListView();
            this.chdIdMascota = new System.Windows.Forms.ColumnHeader();
            this.chdNombreMascota = new System.Windows.Forms.ColumnHeader();
            this.chdPropietarioMascota = new System.Windows.Forms.ColumnHeader();
            this.chdAnimalMascota = new System.Windows.Forms.ColumnHeader();
            this.chdRazaMascota = new System.Windows.Forms.ColumnHeader();
            this.chdPesoMascota = new System.Windows.Forms.ColumnHeader();
            this.chdColorMascota = new System.Windows.Forms.ColumnHeader();
            this.chdNotasMascota = new System.Windows.Forms.ColumnHeader();
            this.pagProductos = new System.Windows.Forms.TabPage();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProductosEliminar = new System.Windows.Forms.Button();
            this.btnProductosEditar = new System.Windows.Forms.Button();
            this.btnProductosAgregar = new System.Windows.Forms.Button();
            this.lvwProductos = new System.Windows.Forms.ListView();
            this.chdIdProducto = new System.Windows.Forms.ColumnHeader();
            this.chdNombreProducto = new System.Windows.Forms.ColumnHeader();
            this.chdValorProducto = new System.Windows.Forms.ColumnHeader();
            this.chdNotasProducto = new System.Windows.Forms.ColumnHeader();
            this.pagServicios = new System.Windows.Forms.TabPage();
            this.flpServicios = new System.Windows.Forms.FlowLayoutPanel();
            this.btnServiciosEliminar = new System.Windows.Forms.Button();
            this.btnServiciosEditar = new System.Windows.Forms.Button();
            this.btnServiciosAgregar = new System.Windows.Forms.Button();
            this.lvwServicios = new System.Windows.Forms.ListView();
            this.chdIdServicio = new System.Windows.Forms.ColumnHeader();
            this.chdNombreServicio = new System.Windows.Forms.ColumnHeader();
            this.chdValorServicio = new System.Windows.Forms.ColumnHeader();
            this.chdNotasServicio = new System.Windows.Forms.ColumnHeader();
            this.pagOrdenes = new System.Windows.Forms.TabPage();
            this.flpOrdenes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrdenesEliminar = new System.Windows.Forms.Button();
            this.btnOrdenesEditar = new System.Windows.Forms.Button();
            this.btnOrdenesAgregar = new System.Windows.Forms.Button();
            this.lvwOrdenes = new System.Windows.Forms.ListView();
            this.chdIdOrden = new System.Windows.Forms.ColumnHeader();
            this.chdClienteOrden = new System.Windows.Forms.ColumnHeader();
            this.chdMascotaOrden = new System.Windows.Forms.ColumnHeader();
            this.chdTipoOrden = new System.Windows.Forms.ColumnHeader();
            this.chdArticulosOrden = new System.Windows.Forms.ColumnHeader();
            this.chdValorOrden = new System.Windows.Forms.ColumnHeader();
            this.chdFechaOrden = new System.Windows.Forms.ColumnHeader();
            this.chdNotasOrden = new System.Windows.Forms.ColumnHeader();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.pagClientes.SuspendLayout();
            this.flpClientes.SuspendLayout();
            this.pagMascotas.SuspendLayout();
            this.flpMascotas.SuspendLayout();
            this.pagProductos.SuspendLayout();
            this.flpProductos.SuspendLayout();
            this.pagServicios.SuspendLayout();
            this.flpServicios.SuspendLayout();
            this.pagOrdenes.SuspendLayout();
            this.flpOrdenes.SuspendLayout();
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
            this.tabOpciones.Controls.Add(this.pagProductos);
            this.tabOpciones.Controls.Add(this.pagServicios);
            this.tabOpciones.Controls.Add(this.pagOrdenes);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpciones.Location = new System.Drawing.Point(3, 162);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(954, 472);
            this.tabOpciones.TabIndex = 1;
            this.tabOpciones.SelectedIndexChanged += new System.EventHandler(this.tabOpciones_SelectedIndexChanged);
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
            // chdTelefonoCliente
            // 
            this.chdTelefonoCliente.Text = "Teléfono";
            this.chdTelefonoCliente.Width = 110;
            // 
            // chdDireccionCliente
            // 
            this.chdDireccionCliente.Text = "Dirección de residencia";
            this.chdDireccionCliente.Width = 200;
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
            this.chdPropietarioMascota,
            this.chdAnimalMascota,
            this.chdRazaMascota,
            this.chdPesoMascota,
            this.chdColorMascota,
            this.chdNotasMascota});
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
            this.lvwMascotas.DoubleClick += new System.EventHandler(this.btnMascotasEditar_Click);
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
            // chdPropietarioMascota
            // 
            this.chdPropietarioMascota.Text = "Propietario (Documento)";
            this.chdPropietarioMascota.Width = 150;
            // 
            // chdAnimalMascota
            // 
            this.chdAnimalMascota.Text = "Animal";
            this.chdAnimalMascota.Width = 80;
            // 
            // chdRazaMascota
            // 
            this.chdRazaMascota.Text = "Raza";
            this.chdRazaMascota.Width = 120;
            // 
            // chdPesoMascota
            // 
            this.chdPesoMascota.Text = "Peso (kg)";
            this.chdPesoMascota.Width = 70;
            // 
            // chdColorMascota
            // 
            this.chdColorMascota.Text = "Color";
            this.chdColorMascota.Width = 100;
            // 
            // chdNotasMascota
            // 
            this.chdNotasMascota.Text = "Notas u observaciones";
            this.chdNotasMascota.Width = 250;
            // 
            // pagProductos
            // 
            this.pagProductos.Controls.Add(this.flpProductos);
            this.pagProductos.Controls.Add(this.lvwProductos);
            this.pagProductos.Location = new System.Drawing.Point(4, 24);
            this.pagProductos.Name = "pagProductos";
            this.pagProductos.Padding = new System.Windows.Forms.Padding(3);
            this.pagProductos.Size = new System.Drawing.Size(946, 444);
            this.pagProductos.TabIndex = 8;
            this.pagProductos.Text = "Productos";
            this.pagProductos.UseVisualStyleBackColor = true;
            // 
            // flpProductos
            // 
            this.flpProductos.Controls.Add(this.btnProductosEliminar);
            this.flpProductos.Controls.Add(this.btnProductosEditar);
            this.flpProductos.Controls.Add(this.btnProductosAgregar);
            this.flpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductos.Location = new System.Drawing.Point(3, 3);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpProductos.Size = new System.Drawing.Size(940, 38);
            this.flpProductos.TabIndex = 1;
            // 
            // btnProductosEliminar
            // 
            this.btnProductosEliminar.Enabled = false;
            this.btnProductosEliminar.Location = new System.Drawing.Point(862, 3);
            this.btnProductosEliminar.Name = "btnProductosEliminar";
            this.btnProductosEliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProductosEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnProductosEliminar.TabIndex = 2;
            this.btnProductosEliminar.Text = "Eliminar";
            this.btnProductosEliminar.UseVisualStyleBackColor = true;
            this.btnProductosEliminar.Click += new System.EventHandler(this.btnProductosEliminar_Click);
            // 
            // btnProductosEditar
            // 
            this.btnProductosEditar.Enabled = false;
            this.btnProductosEditar.Location = new System.Drawing.Point(781, 3);
            this.btnProductosEditar.Name = "btnProductosEditar";
            this.btnProductosEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProductosEditar.Size = new System.Drawing.Size(75, 23);
            this.btnProductosEditar.TabIndex = 1;
            this.btnProductosEditar.Text = "Editar";
            this.btnProductosEditar.UseVisualStyleBackColor = true;
            this.btnProductosEditar.Click += new System.EventHandler(this.btnProductosEditar_Click);
            // 
            // btnProductosAgregar
            // 
            this.btnProductosAgregar.Location = new System.Drawing.Point(700, 3);
            this.btnProductosAgregar.Name = "btnProductosAgregar";
            this.btnProductosAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProductosAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnProductosAgregar.TabIndex = 0;
            this.btnProductosAgregar.Text = "Agregar";
            this.btnProductosAgregar.UseVisualStyleBackColor = true;
            this.btnProductosAgregar.Click += new System.EventHandler(this.btnProductosAgregar_Click);
            // 
            // lvwProductos
            // 
            this.lvwProductos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdProducto,
            this.chdNombreProducto,
            this.chdValorProducto,
            this.chdNotasProducto});
            this.lvwProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwProductos.FullRowSelect = true;
            this.lvwProductos.Location = new System.Drawing.Point(3, 41);
            this.lvwProductos.MultiSelect = false;
            this.lvwProductos.Name = "lvwProductos";
            this.lvwProductos.Size = new System.Drawing.Size(940, 400);
            this.lvwProductos.TabIndex = 0;
            this.lvwProductos.TileSize = new System.Drawing.Size(3, 3);
            this.lvwProductos.UseCompatibleStateImageBehavior = false;
            this.lvwProductos.View = System.Windows.Forms.View.Details;
            this.lvwProductos.SelectedIndexChanged += new System.EventHandler(this.lvwProductos_SelectedIndexChanged);
            this.lvwProductos.DoubleClick += new System.EventHandler(this.btnProductosEditar_Click);
            // 
            // chdIdProducto
            // 
            this.chdIdProducto.Text = "Id";
            this.chdIdProducto.Width = 50;
            // 
            // chdNombreProducto
            // 
            this.chdNombreProducto.Text = "Nombre";
            this.chdNombreProducto.Width = 300;
            // 
            // chdValorProducto
            // 
            this.chdValorProducto.Text = "Valor (por unidad)";
            this.chdValorProducto.Width = 200;
            // 
            // chdNotasProducto
            // 
            this.chdNotasProducto.Text = "Notas u observaciones";
            this.chdNotasProducto.Width = 250;
            // 
            // pagServicios
            // 
            this.pagServicios.Controls.Add(this.flpServicios);
            this.pagServicios.Controls.Add(this.lvwServicios);
            this.pagServicios.Location = new System.Drawing.Point(4, 24);
            this.pagServicios.Name = "pagServicios";
            this.pagServicios.Padding = new System.Windows.Forms.Padding(3);
            this.pagServicios.Size = new System.Drawing.Size(946, 444);
            this.pagServicios.TabIndex = 9;
            this.pagServicios.Text = "Servicios";
            this.pagServicios.UseVisualStyleBackColor = true;
            // 
            // flpServicios
            // 
            this.flpServicios.Controls.Add(this.btnServiciosEliminar);
            this.flpServicios.Controls.Add(this.btnServiciosEditar);
            this.flpServicios.Controls.Add(this.btnServiciosAgregar);
            this.flpServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpServicios.Location = new System.Drawing.Point(3, 3);
            this.flpServicios.Name = "flpServicios";
            this.flpServicios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpServicios.Size = new System.Drawing.Size(940, 38);
            this.flpServicios.TabIndex = 1;
            // 
            // btnServiciosEliminar
            // 
            this.btnServiciosEliminar.Enabled = false;
            this.btnServiciosEliminar.Location = new System.Drawing.Point(862, 3);
            this.btnServiciosEliminar.Name = "btnServiciosEliminar";
            this.btnServiciosEliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnServiciosEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnServiciosEliminar.TabIndex = 2;
            this.btnServiciosEliminar.Text = "Eliminar";
            this.btnServiciosEliminar.UseVisualStyleBackColor = true;
            this.btnServiciosEliminar.Click += new System.EventHandler(this.btnServiciosEliminar_Click);
            // 
            // btnServiciosEditar
            // 
            this.btnServiciosEditar.Enabled = false;
            this.btnServiciosEditar.Location = new System.Drawing.Point(781, 3);
            this.btnServiciosEditar.Name = "btnServiciosEditar";
            this.btnServiciosEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnServiciosEditar.Size = new System.Drawing.Size(75, 23);
            this.btnServiciosEditar.TabIndex = 1;
            this.btnServiciosEditar.Text = "Editar";
            this.btnServiciosEditar.UseVisualStyleBackColor = true;
            this.btnServiciosEditar.Click += new System.EventHandler(this.btnServiciosEditar_Click);
            // 
            // btnServiciosAgregar
            // 
            this.btnServiciosAgregar.Location = new System.Drawing.Point(700, 3);
            this.btnServiciosAgregar.Name = "btnServiciosAgregar";
            this.btnServiciosAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnServiciosAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnServiciosAgregar.TabIndex = 0;
            this.btnServiciosAgregar.Text = "Agregar";
            this.btnServiciosAgregar.UseVisualStyleBackColor = true;
            this.btnServiciosAgregar.Click += new System.EventHandler(this.btnServiciosAgregar_Click);
            // 
            // lvwServicios
            // 
            this.lvwServicios.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwServicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdServicio,
            this.chdNombreServicio,
            this.chdValorServicio,
            this.chdNotasServicio});
            this.lvwServicios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwServicios.FullRowSelect = true;
            this.lvwServicios.Location = new System.Drawing.Point(3, 41);
            this.lvwServicios.MultiSelect = false;
            this.lvwServicios.Name = "lvwServicios";
            this.lvwServicios.Size = new System.Drawing.Size(940, 400);
            this.lvwServicios.TabIndex = 0;
            this.lvwServicios.TileSize = new System.Drawing.Size(3, 3);
            this.lvwServicios.UseCompatibleStateImageBehavior = false;
            this.lvwServicios.View = System.Windows.Forms.View.Details;
            this.lvwServicios.SelectedIndexChanged += new System.EventHandler(this.lvwServicios_SelectedIndexChanged);
            this.lvwServicios.DoubleClick += new System.EventHandler(this.btnServiciosEditar_Click);
            // 
            // chdIdServicio
            // 
            this.chdIdServicio.Text = "Id";
            this.chdIdServicio.Width = 50;
            // 
            // chdNombreServicio
            // 
            this.chdNombreServicio.Text = "Nombre";
            this.chdNombreServicio.Width = 300;
            // 
            // chdValorServicio
            // 
            this.chdValorServicio.Text = "Valor (por unidad)";
            this.chdValorServicio.Width = 200;
            // 
            // chdNotasServicio
            // 
            this.chdNotasServicio.Text = "Notas u observaciones";
            this.chdNotasServicio.Width = 250;
            // 
            // pagOrdenes
            // 
            this.pagOrdenes.Controls.Add(this.flpOrdenes);
            this.pagOrdenes.Controls.Add(this.lvwOrdenes);
            this.pagOrdenes.Location = new System.Drawing.Point(4, 24);
            this.pagOrdenes.Name = "pagOrdenes";
            this.pagOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.pagOrdenes.Size = new System.Drawing.Size(946, 444);
            this.pagOrdenes.TabIndex = 10;
            this.pagOrdenes.Text = "Órdenes";
            this.pagOrdenes.UseVisualStyleBackColor = true;
            // 
            // flpOrdenes
            // 
            this.flpOrdenes.Controls.Add(this.btnOrdenesEliminar);
            this.flpOrdenes.Controls.Add(this.btnOrdenesEditar);
            this.flpOrdenes.Controls.Add(this.btnOrdenesAgregar);
            this.flpOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrdenes.Location = new System.Drawing.Point(3, 3);
            this.flpOrdenes.Name = "flpOrdenes";
            this.flpOrdenes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOrdenes.Size = new System.Drawing.Size(940, 38);
            this.flpOrdenes.TabIndex = 1;
            // 
            // btnOrdenesEliminar
            // 
            this.btnOrdenesEliminar.Enabled = false;
            this.btnOrdenesEliminar.Location = new System.Drawing.Point(862, 3);
            this.btnOrdenesEliminar.Name = "btnOrdenesEliminar";
            this.btnOrdenesEliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrdenesEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenesEliminar.TabIndex = 2;
            this.btnOrdenesEliminar.Text = "Eliminar";
            this.btnOrdenesEliminar.UseVisualStyleBackColor = true;
            this.btnOrdenesEliminar.Click += new System.EventHandler(this.btnOrdenesEliminar_Click);
            // 
            // btnOrdenesEditar
            // 
            this.btnOrdenesEditar.Enabled = false;
            this.btnOrdenesEditar.Location = new System.Drawing.Point(781, 3);
            this.btnOrdenesEditar.Name = "btnOrdenesEditar";
            this.btnOrdenesEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrdenesEditar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenesEditar.TabIndex = 1;
            this.btnOrdenesEditar.Text = "Editar";
            this.btnOrdenesEditar.UseVisualStyleBackColor = true;
            this.btnOrdenesEditar.Click += new System.EventHandler(this.btnOrdenesEditar_Click);
            // 
            // btnOrdenesAgregar
            // 
            this.btnOrdenesAgregar.Location = new System.Drawing.Point(700, 3);
            this.btnOrdenesAgregar.Name = "btnOrdenesAgregar";
            this.btnOrdenesAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrdenesAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenesAgregar.TabIndex = 0;
            this.btnOrdenesAgregar.Text = "Agregar";
            this.btnOrdenesAgregar.UseVisualStyleBackColor = true;
            this.btnOrdenesAgregar.Click += new System.EventHandler(this.btnOrdenesAgregar_Click);
            // 
            // lvwOrdenes
            // 
            this.lvwOrdenes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdOrden,
            this.chdClienteOrden,
            this.chdMascotaOrden,
            this.chdTipoOrden,
            this.chdArticulosOrden,
            this.chdValorOrden,
            this.chdFechaOrden,
            this.chdNotasOrden});
            this.lvwOrdenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwOrdenes.FullRowSelect = true;
            this.lvwOrdenes.Location = new System.Drawing.Point(3, 41);
            this.lvwOrdenes.MultiSelect = false;
            this.lvwOrdenes.Name = "lvwOrdenes";
            this.lvwOrdenes.Size = new System.Drawing.Size(940, 400);
            this.lvwOrdenes.TabIndex = 0;
            this.lvwOrdenes.TileSize = new System.Drawing.Size(3, 3);
            this.lvwOrdenes.UseCompatibleStateImageBehavior = false;
            this.lvwOrdenes.View = System.Windows.Forms.View.Details;
            this.lvwOrdenes.SelectedIndexChanged += new System.EventHandler(this.lvwOrdenes_SelectedIndexChanged);
            this.lvwOrdenes.DoubleClick += new System.EventHandler(this.btnOrdenesEditar_Click);
            // 
            // chdIdOrden
            // 
            this.chdIdOrden.Text = "Id";
            this.chdIdOrden.Width = 50;
            // 
            // chdClienteOrden
            // 
            this.chdClienteOrden.Text = "Cliente (Documento)";
            this.chdClienteOrden.Width = 130;
            // 
            // chdMascotaOrden
            // 
            this.chdMascotaOrden.Text = "Mascota (Nombre)";
            this.chdMascotaOrden.Width = 120;
            // 
            // chdTipoOrden
            // 
            this.chdTipoOrden.Text = "Tipo";
            this.chdTipoOrden.Width = 70;
            // 
            // chdArticulosOrden
            // 
            this.chdArticulosOrden.Text = "Artículos (Productos/Servicios)";
            this.chdArticulosOrden.Width = 180;
            // 
            // chdValorOrden
            // 
            this.chdValorOrden.Text = "Valor total";
            this.chdValorOrden.Width = 100;
            // 
            // chdFechaOrden
            // 
            this.chdFechaOrden.Text = "Fecha/Hora";
            this.chdFechaOrden.Width = 120;
            // 
            // chdNotasOrden
            // 
            this.chdNotasOrden.Text = "Notas u observaciones";
            this.chdNotasOrden.Width = 160;
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
            this.pagProductos.ResumeLayout(false);
            this.flpProductos.ResumeLayout(false);
            this.pagServicios.ResumeLayout(false);
            this.flpServicios.ResumeLayout(false);
            this.pagOrdenes.ResumeLayout(false);
            this.flpOrdenes.ResumeLayout(false);
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
        private ColumnHeader chdTelefonoCliente;
        private ColumnHeader chdDireccionCliente;
        private ColumnHeader chdCorreoCliente;
        private TabPage pagMascotas;
        private FlowLayoutPanel flpMascotas;
        private Button btnMascotasEliminar;
        private Button btnMascotasEditar;
        private Button btnMascotasAgregar;
        public ListView lvwMascotas;
        private ColumnHeader chdIdMascota;
        private ColumnHeader chdNombreMascota;
        private ColumnHeader chdPropietarioMascota;
        private ColumnHeader chdAnimalMascota;
        private ColumnHeader chdRazaMascota;
        private ColumnHeader chdPesoMascota;
        private ColumnHeader chdColorMascota;
        private ColumnHeader chdNotasMascota;
        private TabPage pagProductos;
        private FlowLayoutPanel flpProductos;
        private Button btnProductosEliminar;
        private Button btnProductosEditar;
        private Button btnProductosAgregar;
        public ListView lvwProductos;
        private ColumnHeader chdIdProducto;
        private ColumnHeader chdNombreProducto;
        private ColumnHeader chdValorProducto;
        private ColumnHeader chdNotasProducto;
        private TabPage pagServicios;
        private FlowLayoutPanel flpServicios;
        private Button btnServiciosEliminar;
        private Button btnServiciosEditar;
        private Button btnServiciosAgregar;
        public ListView lvwServicios;
        private ColumnHeader chdIdServicio;
        private ColumnHeader chdNombreServicio;
        private ColumnHeader chdValorServicio;
        private ColumnHeader chdNotasServicio;
        private TabPage pagOrdenes;
        private FlowLayoutPanel flpOrdenes;
        private Button btnOrdenesEliminar;
        private Button btnOrdenesEditar;
        private Button btnOrdenesAgregar;
        public ListView lvwOrdenes;
        private ColumnHeader chdIdOrden;
        private ColumnHeader chdMascotaOrden;
        private ColumnHeader chdClienteOrden;
        private ColumnHeader chdTipoOrden;
        private ColumnHeader chdArticulosOrden;
        private ColumnHeader chdValorOrden;
        private ColumnHeader chdNotasOrden;
        private ColumnHeader chdFechaOrden;
    }
}