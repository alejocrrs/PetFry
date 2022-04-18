using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetFry;

namespace Interfaz
{
    public partial class frmInicio : Form
    {
        private Veterinaria _PETFRY = new Veterinaria("PetFry", "Cl. 50 #23-89", "4065694", "admin@petfry.com");

        public Veterinaria PETFRY { get => _PETFRY; set => _PETFRY = value; }

        public frmInicio()
        {
            PETFRY.AgregarCliente("123456789", "Caralampio Rodríguez", "3104505329", "Cl. 69 #42-94 (Int. 305)", "clampior@gmail.com");
            PETFRY.AgregarCliente("103379053", "Susana Horia", "3258941278", "Cr. 32 #73A-12", "sanahoria@hotmail.com");
            PETFRY.AgregarMascota("Rosky", PETFRY.BuscarCliente(0), "Perro", "Poddle", (decimal)30.4, "Blanco", "");
            PETFRY.AgregarProducto("Comida para gato", (decimal)6500, "");
            PETFRY.AgregarProducto("Comida para perro", (decimal)4500, "");
            PETFRY.AgregarProducto("Pelota", (decimal)15000, "");
            PETFRY.AgregarServicio("Baño para perro", (decimal)25300, "");
            PETFRY.AgregarServicio("Baño para gato", (decimal)25300, "");
            PETFRY.AgregarServicio("Esterilización para perro", (decimal)60000, "");
            PETFRY.AgregarServicio("Esterilización para gato", (decimal)72000, "");
            PETFRY.AgregarOrden(PETFRY.BuscarCliente(0), null, "Producto", new List<Articulo> { PETFRY.BuscarProducto(0), PETFRY.BuscarProducto(0) }, "");
            PETFRY.AgregarOrden(PETFRY.BuscarCliente(0), PETFRY.BuscarMascota(0), "Servicio", new List<Articulo> { PETFRY.BuscarServicio(0) }, "");
            InitializeComponent();
        }

        // GENERAL
        private void frmInicio_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            ActualizarListaMascotas();
            ActualizarListaProductos();
            ActualizarListaServicios();
            ActualizarListaOrdenes();
        }

        private void tabOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabOpciones.SelectedIndex)
            {
                case 0:
                    ActualizarListaClientes();
                    break;
                case 1:
                    ActualizarListaMascotas();
                    break;
                case 2:
                    ActualizarListaProductos();
                    break;
                case 3:
                    ActualizarListaServicios();
                    break;
                case 4:
                    ActualizarListaOrdenes();
                    break;
            }
        }

        // CLIENTES
        public void ActualizarListaClientes()
        {
            lvwClientes.Items.Clear();

            foreach (Cliente cliente in PETFRY.Clientes)
            {
                ListViewItem item = new ListViewItem((PETFRY.Clientes.IndexOf(cliente) + 1).ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cliente.Documento));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cliente.Nombre));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cliente.Telefono));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cliente.Direccion));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cliente.Correo));
                lvwClientes.Items.Add(item);
            }
        }

        private void lvwClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwClientes.SelectedItems.Count > 0)
            {
                btnClientesEditar.Enabled = true;
                btnClientesEliminar.Enabled = true;
            }
            else
            {
                btnClientesEditar.Enabled = false;
                btnClientesEliminar.Enabled = false;
            }
        }

        private void btnClientesAgregar_Click(object sender, EventArgs e)
        {
            new frmCliente(this).ShowDialog();
        }

        private void btnClientesEditar_Click(object sender, EventArgs e)
        {
            int indiceCliente = Int32.Parse(lvwClientes.SelectedItems[0].Text);
            new frmCliente(this, indiceCliente).ShowDialog();

            btnProductosEditar.Enabled = false;
            btnProductosEliminar.Enabled = false;
        }

        public bool ValidarEliminarCliente(int indiceCliente)
        {
            Cliente cliente = PETFRY.BuscarCliente(indiceCliente);

            if (PETFRY.BuscarMascotasCliente(cliente.Documento).Count != 0)
            {
                MessageBox.Show("No se puede eliminar el cliente porque hay mascotas registradas a su referencia.", "Eliminación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                foreach (Orden orden in PETFRY.Ordenes)
                {
                    if (orden.Cliente == cliente)
                    {
                        MessageBox.Show("No se puede eliminar el cliente porque hay órdenes registradas a su referencia.", "Eliminación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
        }

        private void btnClientesEliminar_Click(object sender, EventArgs e)
        {
            int indiceCliente = Int32.Parse(lvwClientes.SelectedItems[0].Text);

            if (MessageBox.Show($"¿Quieres eliminar el cliente #{indiceCliente}?", $"Eliminar cliente #{indiceCliente}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                indiceCliente--;

                if (ValidarEliminarCliente(indiceCliente))
                {
                    PETFRY.EliminarCliente(indiceCliente);
                    lvwClientes.Items.RemoveAt(indiceCliente);
                    ActualizarListaClientes();
                }
            }

            btnProductosEditar.Enabled = false;
            btnProductosEliminar.Enabled = false;
        }

        // MASCOTAS
        public void ActualizarListaMascotas()
        {
            lvwMascotas.Items.Clear();

            foreach (Mascota mascota in PETFRY.Mascotas)
            {
                ListViewItem item = new ListViewItem((PETFRY.Mascotas.IndexOf(mascota) + 1).ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Nombre));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Propietario.Documento));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Animal));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Raza));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Peso.ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Color));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, mascota.Notas));
                lvwMascotas.Items.Add(item);
            }
        }

        private void lvwMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMascotas.SelectedItems.Count > 0)
            {
                btnMascotasEditar.Enabled = true;
                btnMascotasEliminar.Enabled = true;
            }
            else
            {
                btnMascotasEditar.Enabled = false;
                btnMascotasEliminar.Enabled = false;
            }
        }

        private void btnMascotasAgregar_Click(object sender, EventArgs e)
        {
            new frmMascota(this).ShowDialog();
        }

        private void btnMascotasEditar_Click(object sender, EventArgs e)
        {
            int indiceMascota = Int32.Parse(lvwMascotas.SelectedItems[0].Text);
            new frmMascota(this, indiceMascota).ShowDialog();

            btnMascotasEditar.Enabled = false;
            btnMascotasEliminar.Enabled = false;
        }

        private bool ValidarEliminarMascota(int indiceMascota)
        {
            Mascota mascota = PETFRY.BuscarMascota(indiceMascota);

            foreach (Orden orden in PETFRY.Ordenes)
            {
                if (orden.Mascota == mascota)
                {
                    MessageBox.Show("No se puede eliminar la mascota porque hay órdenes registradas a su referencia.", "Eliminación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnMascotasEliminar_Click(object sender, EventArgs e)
        {
            int indiceMascota = Int32.Parse(lvwMascotas.SelectedItems[0].Text);

            if (MessageBox.Show($"¿Quieres eliminar la mascota #{indiceMascota}?", $"Eliminar mascota #{indiceMascota}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                indiceMascota--;
                
                if (ValidarEliminarMascota(indiceMascota))
                {
                    PETFRY.EliminarMascota(indiceMascota);
                    lvwMascotas.Items.RemoveAt(indiceMascota);
                    ActualizarListaMascotas();
                }
            }

            btnMascotasEditar.Enabled = false;
            btnMascotasEliminar.Enabled = false;
        }

        // PRODUCTOS
        public void ActualizarListaProductos()
        {
            lvwProductos.Items.Clear();

            foreach (Producto producto in PETFRY.Productos)
            {
                ListViewItem item = new ListViewItem((PETFRY.Productos.IndexOf(producto) + 1).ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, producto.Nombre));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, producto.Valor.ToString("C")));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, producto.Notas));
                lvwProductos.Items.Add(item);
            }
        }

        private void lvwProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count > 0)
            {
                btnProductosEditar.Enabled = true;
                btnProductosEliminar.Enabled = true;
            }
            else
            {
                btnProductosEditar.Enabled = false;
                btnProductosEliminar.Enabled = false;
            }
        }

        private void btnProductosAgregar_Click(object sender, EventArgs e)
        {
            new frmProducto(this).ShowDialog();
        }

        private void btnProductosEditar_Click(object sender, EventArgs e)
        {
            int indiceProducto = Int32.Parse(lvwProductos.SelectedItems[0].Text);
            new frmProducto(this, indiceProducto).ShowDialog();

            btnProductosEditar.Enabled = false;
            btnProductosEliminar.Enabled = false;
        }

        private bool ValidarEliminarProducto(int indiceProducto)
        {
            Producto producto = PETFRY.BuscarProducto(indiceProducto);

            foreach (Orden orden in PETFRY.Ordenes)
            {
                foreach (Articulo articulo in orden.ListaCompra)
                {
                    if (articulo == producto)
                    {
                        MessageBox.Show("No se puede eliminar el producto porque hay órdenes registradas a su referencia.", "Eliminación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnProductosEliminar_Click(object sender, EventArgs e)
        {
            int indiceProducto = Int32.Parse(lvwProductos.SelectedItems[0].Text);

            if (MessageBox.Show($"¿Quieres eliminar el producto #{indiceProducto}?", $"Eliminar producto #{indiceProducto}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                indiceProducto--;

                if (ValidarEliminarProducto(indiceProducto))
                {
                    PETFRY.EliminarProducto(indiceProducto);
                    lvwProductos.Items.RemoveAt(indiceProducto);
                    ActualizarListaProductos();
                }
            }

            btnProductosEditar.Enabled = false;
            btnProductosEliminar.Enabled = false;
        }

        // SERVICIOS
        public void ActualizarListaServicios()
        {
            lvwServicios.Items.Clear();

            foreach (Servicio servicio in PETFRY.Servicios)
            {
                ListViewItem item = new ListViewItem((PETFRY.Servicios.IndexOf(servicio) + 1).ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, servicio.Nombre));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, servicio.Valor.ToString("C")));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, servicio.Notas));
                lvwServicios.Items.Add(item);
            }
        }

        private void lvwServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwServicios.SelectedItems.Count > 0)
            {
                btnServiciosEditar.Enabled = true;
                btnServiciosEliminar.Enabled = true;
            }
            else
            {
                btnServiciosEditar.Enabled = false;
                btnServiciosEliminar.Enabled = false;
            }
        }

        private void btnServiciosAgregar_Click(object sender, EventArgs e)
        {
            new frmServicio(this).ShowDialog();
        }

        private void btnServiciosEditar_Click(object sender, EventArgs e)
        {
            int indiceServicio = Int32.Parse(lvwServicios.SelectedItems[0].Text);
            new frmServicio(this, indiceServicio).ShowDialog();

            btnServiciosEditar.Enabled = false;
            btnServiciosEliminar.Enabled = false;
        }

        private bool ValidarEliminarServicio(int indiceServicio)
        {
            Servicio servicio = PETFRY.BuscarServicio(indiceServicio);

            foreach (Orden orden in PETFRY.Ordenes)
            {
                foreach (Articulo articulo in orden.ListaCompra)
                {
                    if (articulo == servicio)
                    {
                        MessageBox.Show("No se puede eliminar el servicio porque hay órdenes registradas a su referencia.", "Eliminación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnServiciosEliminar_Click(object sender, EventArgs e)
        {
            int indiceServicio = Int32.Parse(lvwServicios.SelectedItems[0].Text);

            if (MessageBox.Show($"¿Quieres eliminar el servicio #{indiceServicio}?", $"Eliminar servicio #{indiceServicio}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                indiceServicio--;

                if (ValidarEliminarServicio(indiceServicio))
                {
                    PETFRY.EliminarServicio(indiceServicio);
                    lvwServicios.Items.RemoveAt(indiceServicio);
                    ActualizarListaServicios();
                }
            }

            btnServiciosEditar.Enabled = false;
            btnServiciosEliminar.Enabled = false;
        }

        // ÓRDENES
        public void ActualizarListaOrdenes()
        {
            lvwOrdenes.Items.Clear();

            foreach (Orden orden in PETFRY.Ordenes)
            {
                string? nombreMascota = null;
                if (orden.Mascota is not null)
                {
                    nombreMascota = orden.Mascota.Nombre;
                }

                string? listaCompra = null;
                if (orden.ListaCompra is not null)
                {
                    int indiceArticulo = 0;
                    foreach (Articulo articulo in orden.ListaCompra)
                    {
                        listaCompra += articulo.Nombre;
                        if (indiceArticulo != orden.ListaCompra.Count - 1)
                        {
                            listaCompra += "/";
                        }
                        indiceArticulo++;
                    }
                }

                ListViewItem item = new ListViewItem((PETFRY.Ordenes.IndexOf(orden) + 1).ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, orden.Cliente.Documento));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, nombreMascota));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, orden.Tipo));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, listaCompra));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, orden.ValorTotal.ToString("C")));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, orden.Fecha.ToString("dd/MM/yyyy HH:mm:ss")));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, orden.Notas));
                lvwOrdenes.Items.Add(item);
            }
        }

        private void lvwOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwOrdenes.SelectedItems.Count > 0)
            {
                btnOrdenesEditar.Enabled = true;
                btnOrdenesEliminar.Enabled = true;
            }
            else
            {
                btnOrdenesEditar.Enabled = false;
                btnOrdenesEliminar.Enabled = false;
            }
        }

        private void btnOrdenesAgregar_Click(object sender, EventArgs e)
        {
            new frmOrden(this).ShowDialog();
        }

        private void btnOrdenesEditar_Click(object sender, EventArgs e)
        {
            int indiceOrden = Int32.Parse(lvwOrdenes.SelectedItems[0].Text);
            new frmOrden(this, indiceOrden).ShowDialog();

            btnOrdenesEditar.Enabled = false;
            btnOrdenesEliminar.Enabled = false;
        }

        private void btnOrdenesEliminar_Click(object sender, EventArgs e)
        {
            int indiceOrden = Int32.Parse(lvwOrdenes.SelectedItems[0].Text);

            if (MessageBox.Show($"¿Quieres eliminar la orden #{indiceOrden}?", $"Eliminar orden #{indiceOrden}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                indiceOrden--;
                
                PETFRY.EliminarOrden(indiceOrden);
                lvwOrdenes.Items.RemoveAt(indiceOrden);
                ActualizarListaOrdenes();
            }

            btnOrdenesEditar.Enabled = false;
            btnOrdenesEliminar.Enabled = false;
        }
    }
}