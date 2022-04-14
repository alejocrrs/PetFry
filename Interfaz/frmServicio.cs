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
    public partial class frmServicio : Form
    {
        private frmInicio _formInicio;
        private int _indiceServicio;

        public frmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IndiceServicio { get => _indiceServicio; set => _indiceServicio = value; }

        public frmServicio(frmInicio formInicio)
        {
            this.FormInicio = formInicio;
            this.IndiceServicio = -1;
            InitializeComponent();
        }

        public frmServicio(frmInicio formInicio, int indiceServicio)
        {
            this.FormInicio = formInicio;
            this.IndiceServicio = indiceServicio - 1;
            InitializeComponent();

            Text = $"Editar servicio #{indiceServicio}";
            Servicio servicio = FormInicio.PETFRY.BuscarServicio(this.IndiceServicio);
            txtNombre.Text = servicio.Nombre;
            numValor.Value = servicio.Valor;
            txtNotas.Text = servicio.Notas;
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
                if (IndiceServicio == -1)
                {
                    FormInicio.PETFRY.AgregarServicio(txtNombre.Text, numValor.Value, txtNotas.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarServicio(IndiceServicio, txtNombre.Text, numValor.Value, txtNotas.Text);
                }

                FormInicio.ActualizarListaServicios();
                this.Close();
            }
        }
    }
}
