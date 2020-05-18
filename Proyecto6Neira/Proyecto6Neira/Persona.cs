using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int rut;
        public string cargo;

        public Persona(string n, string a, int r, string c)
        {
            this.nombre = n;
            this.apellido = a;
            this.rut = r;
            this.cargo = c;

        }
    }
}
