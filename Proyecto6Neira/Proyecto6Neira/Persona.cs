using System;
using System.Collections.Generic;
namespace Proyecto6Neira
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int rut;
        public string cargo;
        public enum Cargo
        {
            Trabajador = 1,
            EncargadoB = 2,
            EncargadoS = 3,
            EncargadoD = 4,
            EncargadoA = 5,
            EncargadoDiv = 6,
            EncargadoEmpresa = 7,
        }

        public Persona(string n, string a, int r, int c)
        {
            this.nombre = n;
            this.apellido = a;
            this.rut = r;
            this.cargo = ((Cargo)c).ToString();
        }

        public string InfoPersona()
        {
            return "Nombre: " + nombre + " " + apellido + " Rut: " + rut + " Cargo: " + cargo + ".";
        }
    }
}
