using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    [Serializable]
    public class Departamento
    {
        public Persona EncargadoD;
        public string nombre_departamento;
        public List<Seccion> listadesecciones = new List<Seccion>();
        public Departamento(Persona e,string n)
        {
            this.EncargadoD = e;
            this.nombre_departamento = n;
        }
    }
}
