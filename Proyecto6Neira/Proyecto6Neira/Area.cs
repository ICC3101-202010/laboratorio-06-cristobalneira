using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    [Serializable]
    public class Area
    {
        public Persona EncargadoA;
        public string nombre_area;
        public List<Departamento> listadedep = new List<Departamento>();
        public Area(Persona enc,string nombre)
        {
            this.EncargadoA = enc;
            this.nombre_area = nombre;
        }
    }
}
