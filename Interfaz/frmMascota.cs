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
            txtPeso.Text = mascota.Peso.ToString();
            txtColor.Text = mascota.Color;
            txtNotas.Text = mascota.Notas;
            btnAgregar.Text = "Editar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente? propietario;
            string? animal;

            if (txtNombre.Text.Equals("") || txtPropietario.Text.Equals("") || (animal = cboAnimal.SelectedItem.ToString()) is null || txtRaza.Text.Equals("") || txtPeso.Text.Equals("") || txtColor.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ingresa todos los datos requeridos.", "Datos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((propietario = FormInicio.PETFRY.BuscarClienteDocumento(txtPropietario.Text)) is null)
            {
                MessageBox.Show("Por favor, ingresa un propietario válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!Double.TryParse(txtPeso.Text.Replace(".", ","), out _))
            {
                MessageBox.Show("Por favor, ingresa un peso válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double peso = Double.Parse(txtPeso.Text.Replace(".", ","));

                if (IndiceMascota.Equals(-1))
                {
                    FormInicio.PETFRY.AgregarMascota(txtNombre.Text, propietario, animal, txtRaza.Text, peso, txtColor.Text, txtNotas.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarMascota(IndiceMascota, txtNombre.Text, propietario, animal, txtRaza.Text, peso, txtColor.Text, txtNotas.Text);
                }

                FormInicio.ActualizarListaMascotas();
                this.Close();
            }
        }
    }
}
