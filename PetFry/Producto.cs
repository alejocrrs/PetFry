using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public class Producto : Articulo
    {
        public Producto(string nombre, decimal valor) : base(nombre, valor)
        {
        }

        public Producto(string nombre, decimal valor, string notas) : base(nombre, valor, notas)
        {
        }
    }
}