using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Proyecto6Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona per1 = new Persona("Tomas", "Neira", 190712420, 1);
            Persona per2 = new Persona("Rocio", "Roberira", 190712426, 1);
            Persona ebq1 = new Persona("Rocio", "Roberira", 190712426, 2);
            Bloque bloque1 = new Bloque(ebq1, "Bloque 1");
            bloque1.listadetrabajadores.Add(per1);
            bloque1.listadetrabajadores.Add(per2);

            Persona per3 = new Persona("Consuelo", "Laso", 190715420, 1);
            Persona per4 = new Persona("Rene", "Jeira", 190782420, 1);
            Persona ebq2 = new Persona("Rene", "Jeira", 190782420, 2);
            Bloque bloque2 = new Bloque(ebq2, "Bloque 2");
            bloque2.listadetrabajadores.Add(per3);
            bloque2.listadetrabajadores.Add(per4);

            Persona per5 = new Persona("Juan", "Neira", 190792420, 1);
            Persona per6 = new Persona("Camila", "Joebel", 190312420, 1);
            Persona ebq3 = new Persona("Camila", "Joebel", 190312420, 2);
            Bloque bloque3 = new Bloque(ebq3, "Bloque 3");
            bloque3.listadetrabajadores.Add(per5);
            bloque3.listadetrabajadores.Add(per6);

            Persona per7 = new Persona("Juan", "Neira", 190792420, 1);
            Persona per8 = new Persona("Camila", "Joebel", 190312420,1);
            Persona ebq4 = new Persona("Camila", "Joebel", 190312420, 2);
            Bloque bloque4 = new Bloque(ebq4, "Bloque 4");
            bloque4.listadetrabajadores.Add(per7);
            bloque4.listadetrabajadores.Add(per8);

            Persona esecc1 = new Persona("Tomas", "Perez", 200998887, 3);
            Seccion seccion1 = new Seccion(esecc1, "Seccion1");
            seccion1.listadebloques.Add(bloque1);
            seccion1.listadebloques.Add(bloque2);

            Persona esecc2 = new Persona("Fernando", "Perez", 256788887, 3);
            Seccion seccion2 = new Seccion(esecc1, "Seccion2");
            seccion2.listadebloques.Add(bloque3);
            seccion2.listadebloques.Add(bloque4);

            Persona edep1 = new Persona("Gerardo", "Gonzalez", 206998887, 4);
            Departamento dep1 = new Departamento(edep1, "Dep1");
            dep1.listadesecciones.Add(seccion1);
            dep1.listadesecciones.Add(seccion2);

            Persona earea1 = new Persona("Delfina", "Buljubasich", 213335557, 5);
            Area area1 = new Area(earea1, "A1");
            area1.listadedep.Add(dep1);

            Persona ediv1 = new Persona("Boris", "Brejcha", 245553331, 6);
            Division div1 = new Division(ediv1, "Div1");
            div1.listadeareas.Add(area1);

            Persona ceo = new Persona("Cristobal", "Neira", 200712420, 7);
            Empresa empresa = new Empresa(per1, "8inc", 006960272);
            empresa.listadivisiones.Add(div1);
            
            Console.WriteLine("Bienvenido a la visualizacion de empresas!");
            Console.WriteLine("Quiere utilizar un archivo para cargar informacion de la empresa?");
            Console.WriteLine("[1] Si\n[2] No\n[3] Ver todas las [0] Salir");
            int p1 = Convert.ToInt32(Console.ReadLine());
            //Salir falta poner el while nomas
            if (p1 == 0)
            {

            }
            //Poner info
            else if (p1 == 2)
            {
                Console.WriteLine("Ingrese nombre de la empresa:");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese rut de la empresa (solo 9 numeros):");
                int rut = Convert.ToInt32(Console.ReadLine());
                Empresa emp = new Empresa(ceo,name, rut);
                FileStream fs = new FileStream("empresa.bit", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, emp);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    fs.Close();
                }
            }
            //Cargar Info
            else if (p1 == 1)
            {
                //try
                FileStream file = new FileStream("empresas.bin", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                empresas = (List<Empresa>)formatter.Deserialize(file);
                //catch
                //Finally file.close();
            }
            //Error
            else
            {
                "Error, valor no dentro del intervalo 0-2, vuelva a intentarlo!"
            }
        }
    }
}
