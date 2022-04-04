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
            Cliente cliente = FormInicio.PETFRY.BuscarCliente(this.IndiceCliente);
            txtDocumento.Text = cliente.Documento;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            txtCorreo.Text = cliente.Correo;
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
                    FormInicio.PETFRY.AgregarCliente(txtDocumento.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarCliente(IndiceCliente, txtDocumento.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text);
                }

                FormInicio.ActualizarListaClientes();
                this.Close();
            }
        }
    }
}
