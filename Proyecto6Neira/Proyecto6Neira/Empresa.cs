using System;
using System.Collections.Generic;

namespace Proyecto6Neira
{
    [Serializable]
    public class Empresa
    {
        public Persona Dueño;
        public string nombre;
        public int rut;
        public List<Division> listadivisiones = new List<Division>();
        public Empresa(Persona D, string n, int r)
        {
            this.Dueño = D;
            this.nombre = n;
            this.rut = r;
        }
    }
}
