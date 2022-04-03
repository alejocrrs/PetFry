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
                PETFRY.EliminarClienteIndice(--indiceCliente);
                lvwClientes.Items.RemoveAt(indiceCliente);
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
    }
}
