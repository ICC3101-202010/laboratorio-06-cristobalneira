using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    [Serializable]
    public class Bloque
    {
        public Persona EncargadoB;
        public string nombre_bloque;
        public List<Persona> listadetrabajadores = new List<Persona>();
        public Bloque(Persona e,string n)
        {
            this.EncargadoB = e;
            this.nombre_bloque = n;
        }
    }
}
