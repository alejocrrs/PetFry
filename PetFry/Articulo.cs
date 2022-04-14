using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public abstract class Articulo
    {
        private string _nombre;
        private decimal _valor;
        private string _notas;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Articulo(string nombre, decimal valor, string notas)
        {
            Nombre = nombre;
            Valor = valor;
            Notas = notas;
        }
    }
}