using System;

namespace Proyecto6Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Quiere utilizar un archivo para cargar informacion de la empresa");
            Console.WriteLine("[1] Si, [2] No, [0] Salir");
            int p1 = Convert.ToInt32(Console.ReadLine());
            //Salir
            if (p1 == 0)
            {
                //break;
            }
            //Poner info
            else if (p1 == 2)
            {
                Console.WriteLine("Ingrese nombre de la empresa:");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese rut de la empresa (solo numeros:");
                int rut = Convert.ToInt32(Console.ReadLine());
                Empresa emp = new Empresa(name, rut);
                //Poner en el archivo "empresa.bin"
            }
            //Cargar Info
        }
    }
}
