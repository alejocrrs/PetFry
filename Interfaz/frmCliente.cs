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
    public partial class frmCliente : Form
    {
        private frmInicio _formInicio;
        private int _indiceCliente;

        public frmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IndiceCliente { get => _indiceCliente; set => _indiceCliente = value; }

        public frmCliente(frmInicio formInicio)
        {
            this.FormInicio = formInicio;
            this.IndiceCliente = -1;
            InitializeComponent();
        }

        public frmCliente(frmInicio formInicio, int indiceCliente)
        {
            FormInicio = formInicio;
            IndiceCliente = indiceCliente - 1;
            InitializeComponent();

            Text = $"Editar cliente #{indiceCliente}";
            txtDocumento.Text = FormInicio.PETFRY.Clientes[this.IndiceCliente].Documento;
            txtNombre.Text = FormInicio.PETFRY.Clientes[this.IndiceCliente].Nombre;
            txtDireccion.Text = FormInicio.PETFRY.Clientes[this.IndiceCliente].Direccion;
            txtTelefono.Text = FormInicio.PETFRY.Clientes[this.IndiceCliente].Telefono;
            txtCorreo.Text = FormInicio.PETFRY.Clientes[this.IndiceCliente].Correo;
            btnAgregar.Text = "Editar";
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Equals("") || txtNombre.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals("") || txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ingresa todos los datos requeridos.", "Datos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (IndiceCliente.Equals(-1))
                {
                    FormInicio.PETFRY.AgregarCliente(new Cliente(txtDocumento.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text));
                    
                    ListViewItem nuevoItem = new ListViewItem(FormInicio.PETFRY.Clientes.Count().ToString());
                    nuevoItem.SubItems.Add(new ListViewItem.ListViewSubItem(nuevoItem, txtDocumento.Text));
                    nuevoItem.SubItems.Add(new ListViewItem.ListViewSubItem(nuevoItem, txtNombre.Text));
                    nuevoItem.SubItems.Add(new ListViewItem.ListViewSubItem(nuevoItem, txtDireccion.Text));
                    nuevoItem.SubItems.Add(new ListViewItem.ListViewSubItem(nuevoItem, txtTelefono.Text));
                    nuevoItem.SubItems.Add(new ListViewItem.ListViewSubItem(nuevoItem, txtCorreo.Text));
                    FormInicio.lvwClientes.Items.Add(nuevoItem);
                }
                else
                {
                    FormInicio.PETFRY.Clientes[this.IndiceCliente].Documento = txtDocumento.Text;
                    FormInicio.PETFRY.Clientes[this.IndiceCliente].Nombre = txtNombre.Text;
                    FormInicio.PETFRY.Clientes[this.IndiceCliente].Direccion = txtDireccion.Text;
                    FormInicio.PETFRY.Clientes[this.IndiceCliente].Telefono = txtTelefono.Text;
                    FormInicio.PETFRY.Clientes[this.IndiceCliente].Correo = txtCorreo.Text;

                    FormInicio.lvwClientes.Items[this.IndiceCliente].SubItems[1].Text = txtDocumento.Text;
                    FormInicio.lvwClientes.Items[this.IndiceCliente].SubItems[2].Text = txtNombre.Text;
                    FormInicio.lvwClientes.Items[this.IndiceCliente].SubItems[3].Text = txtDireccion.Text;
                    FormInicio.lvwClientes.Items[this.IndiceCliente].SubItems[4].Text = txtTelefono.Text;
                    FormInicio.lvwClientes.Items[this.IndiceCliente].SubItems[5].Text = txtCorreo.Text;
                }

                this.Close();
            }
        }
    }
}
