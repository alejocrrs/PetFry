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
    public partial class frmProducto : Form
    {
        private frmInicio _formInicio;
        private int _indiceProducto;

        public frmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IndiceProducto { get => _indiceProducto; set => _indiceProducto = value; }

        public frmProducto(frmInicio formInicio)
        {
            this.FormInicio = formInicio;
            this.IndiceProducto = -1;
            InitializeComponent();
        }

        public frmProducto(frmInicio formInicio, int indiceProducto)
        {
            this.FormInicio = formInicio;
            this.IndiceProducto = indiceProducto - 1;
            InitializeComponent();

            Text = $"Editar producto #{indiceProducto}";
            Producto producto = FormInicio.PETFRY.BuscarProducto(this.IndiceProducto);
            txtNombre.Text = producto.Nombre;
            numValor.Value = producto.Valor;
            txtNotas.Text = producto.Notas;
            btnAgregar.Text = "Editar";
        }

        private bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el nombre distintivo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombre.TextLength > 70)
            {
                MessageBox.Show("El nombre excede los 70 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarValor()
        {
            numValor.Focus();

            return true;
        }

        private bool VerificarNotas()
        {
            txtNotas.Focus();

            if (txtNotas.TextLength > 200)
            {
                MessageBox.Show("Las notas exceden los 200 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarDatos()
        {
            if (VerificarNombre() && VerificarValor() && VerificarNotas())
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
                if (IndiceProducto == -1)
                {
                    FormInicio.PETFRY.AgregarProducto(txtNombre.Text, numValor.Value, txtNotas.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarProducto(IndiceProducto, txtNombre.Text, numValor.Value, txtNotas.Text);
                }

                FormInicio.ActualizarListaProductos();
                this.Close();
            }
        }
    }
}
