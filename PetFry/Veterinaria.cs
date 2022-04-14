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

        //ACCIONES CLIENTE
        public Cliente BuscarCliente(int indice)
        {
            return Clientes[indice];
        }

        public int BuscarCliente(Cliente cliente)
        {
            return Clientes.IndexOf(cliente);
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

        //ACCIONES MASCOTA
        public Mascota BuscarMascota(int indice)
        {
            return Mascotas[indice];
        }

        public List<Mascota> BuscarMascotasCliente(string documentoCliente)
        {
            List<Mascota> mascotasCliente = new List<Mascota>();

            foreach (Mascota mascota in Mascotas)
            {
                if (mascota.Propietario.Documento == documentoCliente)
                {
                    mascotasCliente.Add(mascota);
                }
            }
            return mascotasCliente;
        }

        public int BuscarMascota(string documentoCliente, string nombreMascota)
        {
            List<Mascota> mascotasCliente = BuscarMascotasCliente(documentoCliente);

            foreach (Mascota mascota in mascotasCliente)
            {
                if (mascota.Nombre == nombreMascota)
                {
                    return Mascotas.IndexOf(mascota);
                }
            }
            return -1;
        }

        public void AgregarMascota(string nombre, Cliente propietario, string animal, string raza, decimal peso, string color, string notas)
        {
            Mascotas.Add(new Mascota(nombre, propietario, animal, raza, peso, color, notas));
        }

        public void EditarMascota(int indice, string nombre, Cliente propietario, string animal, string raza, decimal peso, string color, string notas)
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

        //ACCIONES PRODUCTO
        public Producto BuscarProducto(int indice)
        {
            return Productos[indice];
        }

        public void AgregarProducto(string nombre, decimal valor, string notas)
        {
            Productos.Add(new Producto(nombre, valor, notas));
        }

        public void EditarProducto(int indice, string nombre, decimal valor, string notas)
        {
            Productos[indice].Nombre = nombre;
            Productos[indice].Valor = valor;
            Productos[indice].Notas = notas;
        }

        public void EliminarProducto(int indice)
        {
            Productos.RemoveAt(indice);
        }

        //ACCIONES SERVICIO
        public Servicio BuscarServicio(int indice)
        {
            return Servicios[indice];
        }

        public void AgregarServicio(string nombre, decimal valor, string notas)
        {
            Servicios.Add(new Servicio(nombre, valor, notas));
        }

        public void EditarServicio(int indice, string nombre, decimal valor, string notas)
        {
            Servicios[indice].Nombre = nombre;
            Servicios[indice].Valor = valor;
            Servicios[indice].Notas = notas;
        }

        public void EliminarServicio(int indice)
        {
            Servicios.RemoveAt(indice);
        }

        //ACCIONES ORDEN
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