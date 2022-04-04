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
        private Veterinaria _PETFRY;

        public Veterinaria PETFRY { get => _PETFRY; set => _PETFRY = value; }

        public frmInicio()
        {
            this.PETFRY = new Veterinaria("PetFry", "***", "000", "home@petfry.com");
            InitializeComponent();
        }

        public void ActualizarListaClientes()
        {
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

        public void ActualizarListaMascotas()
        {
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

        // EVENTOS GENERALES
        private void frmInicio_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            ActualizarListaMascotas();
        }

        // EVENTOS CLIENTES
        private void flpClientes_Click(object sender, EventArgs e)
        {
            ActualizarListaClientes();
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
        }

        private void btnClientesEliminar_Click(object sender, EventArgs e)
        {
            int indiceCliente = Int32.Parse(lvwClientes.SelectedItems[0].Text);
            if (MessageBox.Show($"¿Quieres eliminar el cliente #{indiceCliente}?", $"Eliminar cliente #{indiceCliente}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                --indiceCliente;
                PETFRY.EliminarCliente(indiceCliente);
                lvwClientes.Items.RemoveAt(indiceCliente);
                ActualizarListaClientes();
            }
        }

        // EVENTOS MASCOTAS
        private void flpMascotas_Click(object sender, EventArgs e)
        {
            ActualizarListaMascotas();
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
        }

        private void btnMascotasEliminar_Click(object sender, EventArgs e)
        {
            int indiceMascota = Int32.Parse(lvwMascotas.SelectedItems[0].Text);
            if (MessageBox.Show($"¿Quieres eliminar la mascota #{indiceMascota}?", $"Eliminar mascota #{indiceMascota}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                --indiceMascota;
                PETFRY.EliminarMascota(indiceMascota);
                lvwMascotas.Items.RemoveAt(indiceMascota);
                ActualizarListaMascotas();
            }
        }
    }
}
