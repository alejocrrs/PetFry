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
    public partial class frmListaArticulos : Form
    {
        private frmOrden _formOrden;
        private string _tipo;

        public frmOrden FormOrden { get => _formOrden; set => _formOrden = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }

        public frmListaArticulos(frmOrden formOrden, string tipo)
        {
            this.FormOrden = formOrden;
            this.Tipo = tipo;

            InitializeComponent();

            if (Tipo == "Producto")
            {
                Text = "Lista de productos disponibles";
            }
            else if (Tipo == "Servicios")
            {
                Text = "Lista de servicios disponibles";
            }
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lvwArticulos.Items.Clear();

            if (Tipo == "Producto")
            {
                foreach (Producto producto in FormOrden.FormInicio.PETFRY.Productos)
                {
                    ListViewItem item = new ListViewItem((FormOrden.FormInicio.PETFRY.Productos.IndexOf(producto) + 1).ToString());
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, producto.Nombre));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, producto.Valor.ToString("C")));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, producto.Notas));
                    
                    if (FormOrden.ListaArticulos.Contains(producto))
                    {
                        item.Checked = true;
                    }

                    lvwArticulos.Items.Add(item);
                }
            }
            else if (Tipo == "Servicio")
            {
                foreach (Servicio servicio in FormOrden.FormInicio.PETFRY.Servicios)
                {
                    ListViewItem item = new ListViewItem((FormOrden.FormInicio.PETFRY.Servicios.IndexOf(servicio) + 1).ToString());
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, servicio.Nombre));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, servicio.Valor.ToString("C")));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, servicio.Notas));

                    if (FormOrden.ListaArticulos.Contains(servicio))
                    {
                        item.Checked = true;
                    }

                    lvwArticulos.Items.Add(item);
                }
            }
        }

        // EVENTOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            if (Tipo == "Producto")
            {
                foreach (ListViewItem item in lvwArticulos.Items)
                {
                    Producto producto = FormOrden.FormInicio.PETFRY.BuscarProducto(item.Index);
                    if (item.Checked && !FormOrden.ListaArticulos.Contains(producto))
                    {
                        FormOrden.ListaArticulos.Add(producto);
                    }
                    else if (!item.Checked && FormOrden.ListaArticulos.Contains(producto))
                    {
                        FormOrden.ListaArticulos.Remove(producto);
                    }
                }
            }
            else if (Tipo == "Servicio")
            {
                foreach (ListViewItem item in lvwArticulos.Items)
                {
                    Servicio servicio = FormOrden.FormInicio.PETFRY.BuscarServicio(item.Index);
                    if (item.Checked && !FormOrden.ListaArticulos.Contains(servicio))
                    {
                        FormOrden.ListaArticulos.Add(servicio);
                    }
                    else if (!item.Checked && FormOrden.ListaArticulos.Contains(servicio))
                    {
                        FormOrden.ListaArticulos.Remove(servicio);
                    }
                }
            }

            FormOrden.CalcularValor();
            this.Close();
        }
    }
}
