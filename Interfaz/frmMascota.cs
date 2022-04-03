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
            txtNombre.Text = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Nombre;
            txtPropietario.Text = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Propietario.Documento;
            cboAnimal.SelectedText = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Animal;
            txtRaza.Text = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Raza;
            txtPeso.Text = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Peso.ToString();
            txtColor.Text = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Color;
            txtNotas.Text = FormInicio.PETFRY.Mascotas[this.IndiceMascota].Notas;
            btnAgregar.Text = "Editar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente? propietario;

            if (txtNombre.Text.Equals("") || txtPropietario.Text.Equals("") || cboAnimal.SelectedText.Equals("") || txtRaza.Text.Equals("") || txtPeso.Text.Equals("") || txtColor.Text.Equals("") || txtNotas.Text.Equals(""))
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
                    FormInicio.PETFRY.AgregarMascota(new Mascota(txtNombre.Text, propietario, cboAnimal.SelectedText, txtRaza.Text, peso, txtColor.Text, txtNotas.Text));
                }
                else
                {

                }

                this.Close();
            }
        }
    }
}
