﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry
{
    public class Mascota
    {
        private string _nombre;
        private Cliente _propietario;
        private string _animal;
        private string _raza;
        private decimal _peso;
        private string _color;
        private string _notas;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public Cliente Propietario { get => _propietario; set => _propietario = value; }
        public string Animal { get => _animal; set => _animal = value; }
        public string Raza { get => _raza; set => _raza = value; }
        public decimal Peso { get => _peso; set => _peso = value; }
        public string Color { get => _color; set => _color = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Mascota(string nombre, Cliente propietario, string animal, string raza, decimal peso, string color, string notas)
        {
            Nombre = nombre;
            Propietario = propietario;
            Animal = animal;
            Raza = raza;
            Peso = peso;
            Color = color;
            Notas = notas;
        }
    }
}