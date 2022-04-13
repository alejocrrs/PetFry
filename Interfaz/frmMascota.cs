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
    public partial class frmMascota : Form
    {
        private frmInicio _formInicio;
        private int _indiceMascota;

        public frmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IndiceMascota { get => _indiceMascota; set => _indiceMascota = value; }

        public frmMascota(frmInicio formInicio)
        {
            this.FormInicio = formInicio;
            this.IndiceMascota = -1;
            InitializeComponent();
        }

        public frmMascota(frmInicio formInicio, int indiceMascota)
        {
            this.FormInicio = formInicio;
            this.IndiceMascota = indiceMascota - 1;
            InitializeComponent();

            Text = $"Editar mascota #{indiceMascota}";
            Mascota mascota = FormInicio.PETFRY.BuscarMascota(this.IndiceMascota);
            txtNombre.Text = mascota.Nombre;
            txtPropietario.Text = mascota.Propietario.Documento;
            cboAnimal.SelectedItem = mascota.Animal;
            txtRaza.Text = mascota.Raza;
            numPeso.Value = mascota.Peso;
            txtColor.Text = mascota.Color;
            txtNotas.Text = mascota.Notas;
            btnAgregar.Text = "Editar";
        }

        private bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el nombre o apodo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombre.TextLength > 15)
            {
                MessageBox.Show("El nombre excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (FormInicio.PETFRY.BuscarMascota(txtPropietario.Text, txtNombre.Text) != -1 && IndiceMascota != FormInicio.PETFRY.BuscarMascota(txtPropietario.Text, txtNombre.Text))
            {
                MessageBox.Show($"El nombre coincide con una mascota ya registrada del propietario indicado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarPropietario()
        {
<<<<<<< HEAD
            txtPropietario.Focus();

            if (txtPropietario.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el número de documento del propietario.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPropietario.TextLength > 15)
=======
            Cliente? propietario;
            string? animal;

            if (txtNombre.Text.Equals("") || txtPropietario.Text.Equals("") || (animal = cboAnimal.SelectedItem.ToString()) is null || txtRaza.Text.Equals("") || txtPeso.Text.Equals("") || txtColor.Text.Equals(""))
>>>>>>> 0c48c96ac609ab4316b8a8a9115cd5a0a794df10
            {
                MessageBox.Show("El número de documento del propietario excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtPropietario.Text, out _))
            {
                MessageBox.Show("El número de documento del propietario debe contener solo valores numéricos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (FormInicio.PETFRY.BuscarClienteDocumento(txtPropietario.Text) is null)
            {
                MessageBox.Show("El número de documento del propietario no se encuentra registrado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool VerificarAnimal()
        {
            cboAnimal.Focus();

            if (cboAnimal.SelectedItem is null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de animal.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarRaza()
        {
            txtRaza.Focus();

            if (txtRaza.TextLength > 25)
            {
                MessageBox.Show("La raza excede los 25 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarPeso()
        {
            numPeso.Focus();

            if (numPeso.Value == 0)
            {
                MessageBox.Show("Por favor, ingresa un peso válido.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarColor()
        {
            txtColor.Focus();

            if (txtColor.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el color o los patrones distintivos.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtColor.TextLength > 50)
            {
                MessageBox.Show("El color excede los 50 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
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
            if (VerificarNombre() && VerificarPropietario() && VerificarAnimal() && VerificarRaza() && VerificarPeso() && VerificarColor() && VerificarNotas())
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
                Cliente? propietario = FormInicio.PETFRY.BuscarClienteDocumento(txtPropietario.Text);
                string? animal = cboAnimal.SelectedItem.ToString();

                if (IndiceMascota.Equals(-1))
                {
<<<<<<< HEAD
                    FormInicio.PETFRY.AgregarMascota(txtNombre.Text, propietario, animal, txtRaza.Text, numPeso.Value, txtColor.Text, txtNotas.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarMascota(IndiceMascota, txtNombre.Text, propietario, animal, txtRaza.Text, numPeso.Value, txtColor.Text, txtNotas.Text);
=======
                    FormInicio.PETFRY.AgregarMascota(txtNombre.Text, propietario, animal, txtRaza.Text, peso, txtColor.Text, txtNotas.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarMascota(IndiceMascota, txtNombre.Text, propietario, animal, txtRaza.Text, peso, txtColor.Text, txtNotas.Text);
>>>>>>> 0c48c96ac609ab4316b8a8a9115cd5a0a794df10
                }

                FormInicio.ActualizarListaMascotas();
                this.Close();
            }
        }
    }
}
