using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    [Serializable]
    public class Seccion
    {
        public Persona EncargadoS;
        public string nombre_seccion;
        public List<Bloque> listadebloques = new List<Bloque>();
        public Seccion(Persona e,string n)
        {
            this.EncargadoS = e;
            this.nombre_seccion = n;
        }
    }
}
