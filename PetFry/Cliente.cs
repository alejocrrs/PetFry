using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public class Cliente: Persona
    {
        public Cliente(string documento, string nombre, string telefono, string direccion, string correo) : base(documento, nombre, telefono, direccion, correo)
        {
        }
    }
}