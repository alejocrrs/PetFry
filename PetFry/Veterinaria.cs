using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public class Veterinaria
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private List<Cliente> _clientes;
        private List<Mascota> _mascotas;
        private List<Producto> _productos;
        private List<Servicio> _servicios;
        private List<Orden> _ordenes;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }
        public List<Mascota> Mascotas { get => _mascotas; set => _mascotas = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }
        public List<Servicio> Servicios { get => _servicios; set => _servicios = value; }
        public List<Orden> Ordenes { get => _ordenes; set => _ordenes = value; }

        public Veterinaria(string nombre, string direccion, string telefono, string correo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;

            Clientes = new List<Cliente>();
            Mascotas = new List<Mascota>();
            Productos = new List<Producto>();
            Servicios = new List<Servicio>();
            Ordenes = new List<Orden>();
        }

        //Acciones Cliente
        public Cliente BuscarCliente(int indice)
        {
            return Clientes[indice];
        }

        public Cliente? BuscarClienteDocumento(string documento)
        {
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Documento == documento)
                {
                    return cliente;
                }
            }
            return null;
        }

        public void AgregarCliente(string documento, string nombre, string telefono, string direccion, string correo)
        {
            Clientes.Add(new Cliente(documento, nombre, telefono, direccion, correo));
        }

        public void EditarCliente(int indice, string documento, string nombre, string telefono, string direccion, string correo)
        {
            Clientes[indice].Documento = documento;
            Clientes[indice].Nombre = nombre;
            Clientes[indice].Telefono = telefono;
            Clientes[indice].Direccion = direccion;
            Clientes[indice].Correo = correo;
        }

        public void EliminarCliente(int indice)
        {
            Clientes.RemoveAt(indice);
        }

        //Acciones Mascota
        public Mascota BuscarMascota(int indice)
        {
            return Mascotas[indice];
        }

        public void AgregarMascota(string nombre, Cliente propietario, string animal, string raza, double peso, string color, string notas)
        {
            Mascotas.Add(new Mascota(nombre, propietario, animal, raza, peso, color, notas));
        }

        public void EditarMascota(int indice, string nombre, Cliente propietario, string animal, string raza, double peso, string color, string notas)
        {
            Mascotas[indice].Nombre = nombre;
            Mascotas[indice].Propietario = propietario;
            Mascotas[indice].Animal = animal;
            Mascotas[indice].Raza = raza;
            Mascotas[indice].Peso = peso;
            Mascotas[indice].Color = color;
            Mascotas[indice].Notas = notas;
        }

        public void EliminarMascota(int indice)
        {
            Mascotas.RemoveAt(indice);
        }

        //Acciones Producto
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void EliminarProducto(int indice)
        {
            Productos.RemoveAt(indice);
        }

        //Acciones Servicio
        public void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }

        public void EliminarServicio(int indice)
        {
            Servicios.RemoveAt(indice);
        }

        //Acciones Orden
        public void AgregarOrden(Orden orden)
        {
            Ordenes.Add(orden);
        }

        public void EliminarOrden(int indice)
        {
            Ordenes.RemoveAt(indice);
        }
    }
}