using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public class Usuario: Persona
    {
        private bool _administrador;
        private bool _bloqueado;

        public bool Administrador { get => _administrador; set => _administrador = value; }
        public bool Bloqueado { get => _bloqueado; set => _bloqueado = value; }

        public Usuario(string documento, string nombre, string telefono, string direccion, string correo, bool administrador, bool bloqueado) : base(documento, nombre, telefono, direccion, correo)
        {
            Administrador = administrador;
            Bloqueado = bloqueado;
        }
    }
}
