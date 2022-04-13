using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        private bool VerificarDocumento()
        {
            txtDocumento.Focus();

            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el número de documento.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtDocumento.TextLength > 15)
            {
                MessageBox.Show("El número de documento excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El número de documento debe contener solo valores numéricos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (FormInicio.PETFRY.BuscarClienteDocumento(txtDocumento.Text) is not null && IndiceCliente != FormInicio.PETFRY.BuscarCliente(FormInicio.PETFRY.BuscarClienteDocumento(txtDocumento.Text)))
            {
                MessageBox.Show("El número de documento ya se encuentra registrado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el nombre completo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombre.TextLength > 50)
            {
                MessageBox.Show("El nombre excede los 50 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarTelefono()
        {
            txtTelefono.Focus();

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el número de teléfono.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTelefono.TextLength > 15)
            {
                MessageBox.Show("El número de teléfono excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El número de teléfono debe contener solo valores numéricos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarDireccion()
        {
            txtDireccion.Focus();

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Por favor, ingresa la dirección de residencia.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtDireccion.TextLength > 50)
            {
                MessageBox.Show("La dirección de residencia excede los 50 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarCorreo()
        {
            txtCorreo.Focus();

            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el correo electrónico.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCorreo.TextLength > 40)
            {
                MessageBox.Show("El correo electrónico excede los 40 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!new EmailAddressAttribute().IsValid(txtCorreo.Text))
            {
                MessageBox.Show("El correo electrónico no cumple con la estructura básica (Ejemplo: nombre@ejemplo.com).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarDatos()
        {
            if (VerificarDocumento() && VerificarNombre() && VerificarTelefono() && VerificarDireccion() && VerificarCorreo())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
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
