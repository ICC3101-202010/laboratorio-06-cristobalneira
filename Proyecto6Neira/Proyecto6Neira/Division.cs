using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    [Serializable]
    public class Division
    {
        public Persona EncargadoD;
        public string nombre_division;
        public List<Area> listadeareas = new List<Area>();
        public Division(Persona e,string nombre)
        {
            this.EncargadoD = e;
            this.nombre_division = nombre;
        }
    }
}
