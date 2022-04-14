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
        private Veterinaria _PETFRY = new Veterinaria("PetFry", "***", "000", "admin@petfry.com");

        public Veterinaria PETFRY { get => _PETFRY; set => _PETFRY = value; }

        public frmInicio()
        {
            PETFRY.AgregarCliente("1001025610", "Alejandro Córdoba Ríos", "3118372792", "Cr. 89 #27-42", "alejocrrs@gmail.com");
            PETFRY.AgregarMascota("Andy", PETFRY.BuscarCliente(0), "Perro", "Caniche argentino", (decimal)30.4, "Blanco", "");
            PETFRY.AgregarProducto("Comida para gato", (decimal)3500, "");
            PETFRY.AgregarServicio("Baño para perro", (decimal)25300, "");
            InitializeComponent();
        }

        // GENERAL
        private void frmInicio_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            ActualizarListaMascotas();
            ActualizarListaProductos();
            ActualizarListaServicios();
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
            //MessageBox.Show("Te extraño mucho, mi Ornitorrinco :(", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MessageBox.Show("El cliente no se puede eliminar porque hay mascotas u órdenes registradas a su referencia.", "Eliminación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
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

        private bool ValidarEliminarMascota(int indiceMascota) // REALIZAR VALIDACIÓN
        {
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

        private bool ValidarEliminarProducto(int indiceProducto) // REALIZAR VALIDACIÓN
        {
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

        private bool ValidarEliminarServicio(int indiceServicio) // REALIZAR VALIDACIÓN
        {
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
    }
}