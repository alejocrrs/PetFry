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
    public partial class frmOrden : Form
    {
        private frmInicio _formInicio;
        private int _indiceOrden;
        private List<Articulo> _listaArticulos;

        public frmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IndiceOrden { get => _indiceOrden; set => _indiceOrden = value; }
        public List<Articulo> ListaArticulos { get => _listaArticulos; set => _listaArticulos = value; }

        public frmOrden(frmInicio formInicio)
        {
            this.FormInicio = formInicio;
            this.IndiceOrden = -1;
            this.ListaArticulos = new List<Articulo>();
            InitializeComponent();
        }

        public frmOrden(frmInicio formInicio, int indiceOrden)
        {
            this.FormInicio = formInicio;
            this.IndiceOrden = indiceOrden -1;
            this.ListaArticulos = new List<Articulo>();
            InitializeComponent();

            Text = $"Editar orden #{indiceOrden}";
            Orden orden = FormInicio.PETFRY.BuscarOrden(this.IndiceOrden);
            string? nombreMascota = null;
            if (orden.Mascota is not null)
            {
                nombreMascota = orden.Mascota.Nombre;
            }

            txtCliente.Text = orden.Cliente.Documento;
            txtMascota.Text = nombreMascota;
            if (orden.Tipo == "Producto")
            {
                cboTipo.SelectedItem = "Producto";
                lblArticulos.Text = "Productos";
                btnArticulos.Text = "Seleccionar productos";
            }
            else if (orden.Tipo == "Servicio")
            {
                cboTipo.SelectedItem = "Servicio";
                lblArticulos.Text = "Servicios";
                btnArticulos.Text = "Seleccionar servicios";
            }

            ListaArticulos = orden.ListaCompra;
            numValor.Value = orden.ValorTotal;
            txtNotas.Text = orden.Notas;
            btnAgregar.Text = "Editar";
        }

        public void CalcularValor()
        {
            numValor.Value = 0;
            foreach (Articulo articulo in ListaArticulos)
            {
                numValor.Value += articulo.Valor;
            }
        }

        private bool VerificarCliente()
        {
            txtCliente.Focus();

            if (txtCliente.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el número de documento del cliente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCliente.TextLength > 15)
            {
                MessageBox.Show("El número de documento del cliente excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtCliente.Text, out _))
            {
                MessageBox.Show("El número de documento del cliente debe contener solo valores numéricos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (FormInicio.PETFRY.BuscarClienteDocumento(txtCliente.Text) is null)
            {
                MessageBox.Show("El número de documento del cliente no se encuentra registrado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarMascota()
        {
            txtMascota.Focus();

            if (cboTipo.SelectedItem is not null && cboTipo.SelectedItem.ToString() == "Servicio")
            {
                if (txtMascota.Text == "")
                {
                    MessageBox.Show("Por favor, ingresa el nombre o apodo de la mascota.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (txtMascota.TextLength > 15)
                {
                    MessageBox.Show("El nombre de la mascota excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (FormInicio.PETFRY.BuscarMascota(txtCliente.Text, txtMascota.Text) == -1)
                {
                    MessageBox.Show($"El nombre de la mascota no coincide con una mascota registrada del propietario indicado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private bool VerificarTipo()
        {
            cboTipo.Focus();

            if (cboTipo.SelectedItem is null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de orden.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarArticulos()
        {
            btnArticulos.Focus();

            if (ListaArticulos.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona los artículos (productos/servicios) a solicitar.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public bool VerificarDatos()
        {
            if (VerificarCliente() && VerificarMascota() && VerificarTipo() && VerificarArticulos() && VerificarNotas())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // EVENTOS
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem is not null)
            {
                new frmListaArticulos(this, cboTipo.SelectedItem.ToString()).ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona antes un tipo de orden.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                Cliente? cliente = FormInicio.PETFRY.BuscarClienteDocumento(txtCliente.Text);
                Mascota? mascota = null;
                if (txtMascota.Text != "")
                {
                    mascota = FormInicio.PETFRY.BuscarMascota(FormInicio.PETFRY.BuscarMascota(txtCliente.Text, txtMascota.Text));
                }

                if (IndiceOrden == -1)
                {
                    FormInicio.PETFRY.AgregarOrden(cliente, mascota, cboTipo.SelectedItem.ToString(), ListaArticulos, txtNotas.Text);
                }
                else
                {
                    FormInicio.PETFRY.EditarOrden(IndiceOrden, cliente, mascota, cboTipo.SelectedItem.ToString(), ListaArticulos, txtNotas.Text);
                }

                FormInicio.ActualizarListaOrdenes();
                this.Close();
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem.ToString() == "Producto")
            {
                lblArticulos.Text = "Productos";
                btnArticulos.Text = "Seleccionar productos";
                txtMascota.Text = "";
                txtMascota.Enabled = false;
                ListaArticulos.Clear();
                CalcularValor();
            }
            else if (cboTipo.SelectedItem.ToString() == "Servicio")
            {
                lblArticulos.Text = "Servicios";
                btnArticulos.Text = "Seleccionar servicios";
                txtMascota.Enabled = true;
                ListaArticulos.Clear();
                CalcularValor();
            }
        }
    }
}
