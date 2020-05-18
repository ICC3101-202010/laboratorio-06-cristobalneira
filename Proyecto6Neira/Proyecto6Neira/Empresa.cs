using System;
using System.Collections.Generic;

namespace Proyecto6Neira
{
    public class Empresa
    {
        public string nombre;
        public int rut;
        public List<Division> divisiones = new List<Division>();
        public Empresa(string n, int r)
        {
            this.nombre = n;
            this.rut = r;
        }
    }
}
