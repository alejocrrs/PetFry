using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public class Orden
    {
        private Cliente _cliente;
        private Mascota? _mascota;
        private string _tipo;
        private List<Articulo> _listaCompra;
        private decimal _valorTotal;
        private DateTime _fecha;
        private string _notas;

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Mascota? Mascota { get => _mascota; set => _mascota = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public List<Articulo> ListaCompra { get => _listaCompra; set => _listaCompra = value; }
        public decimal ValorTotal { get => _valorTotal; set => _valorTotal = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Orden(Cliente cliente, Mascota? mascota, string tipo, List<Articulo> listaCompra, string notas)
        {
            Cliente = cliente;
            Mascota = mascota;
            Tipo = tipo;
            ListaCompra = listaCompra;
            ValorTotal = CalcularValor(listaCompra);
            Fecha = DateTime.Now;
            Notas = notas;
        }

        public static decimal CalcularValor(List<Articulo> listaCompra)
        {
            decimal valorTotal = 0;
            foreach (var articulo in listaCompra)
            {
                valorTotal += articulo.Valor;
            }
            return valorTotal;
        }
    }
}