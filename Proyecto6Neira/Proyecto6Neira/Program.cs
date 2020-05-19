using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto6Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona per1 = new Persona("Tomas", "Neira", 190712420, 1);
            Persona per2 = new Persona("Rocio", "Roberira", 190352426, 1);
            Persona ebq1 = new Persona("Michael", "Jackson", 133712426, 2);
            Bloque bloque1 = new Bloque(ebq1, "Bloque 1");
            bloque1.listadetrabajadores.Add(per1);
            bloque1.listadetrabajadores.Add(per2);

            Persona per3 = new Persona("Consuelo", "Laso", 134655420, 1);
            Persona per4 = new Persona("Rene", "Jeira", 102082420, 1);
            Persona ebq2 = new Persona("John", "Cena", 19982420, 2);
            Bloque bloque2 = new Bloque(ebq2, "Bloque 2");
            bloque2.listadetrabajadores.Add(per3);
            bloque2.listadetrabajadores.Add(per4);

            Persona per5 = new Persona("Juan", "Neira", 190792420, 1);
            Persona per6 = new Persona("Camila", "Joebel", 190312420, 1);
            Persona ebq3 = new Persona("Lana", "Rhodes", 190312420, 2);
            Bloque bloque3 = new Bloque(ebq3, "Bloque 3");
            bloque3.listadetrabajadores.Add(per5);
            bloque3.listadetrabajadores.Add(per6);

            Persona per7 = new Persona("Pedro", "Mancilla", 190792420, 1);
            Persona per8 = new Persona("Javier", "Flores", 190312420,1);
            Persona ebq4 = new Persona("Roberto", "Firminio", 190312420, 2);
            Bloque bloque4 = new Bloque(ebq4, "Bloque 4");
            bloque4.listadetrabajadores.Add(per7);
            bloque4.listadetrabajadores.Add(per8);

            Persona esecc1 = new Persona("Tomas", "Perez", 200998887, 3);
            Seccion seccion1 = new Seccion(esecc1, "Seccion1");
            seccion1.listadebloques.Add(bloque1);
            seccion1.listadebloques.Add(bloque2);

            Persona esecc2 = new Persona("Fernando", "Perez", 256788887, 3);
            Seccion seccion2 = new Seccion(esecc2, "Seccion2");
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

            Empresa empresa2 = empresa;

            Console.WriteLine("Bienvenido a la visualizacion de empresa!");
            int a = 0;
            while(a==0)
            {
                int o = 0;
                while (o == 0)
                {
                    Console.WriteLine("Quiere hacer con la informacion de la empresa?");
                    Console.WriteLine("[1] Cargar Informacion\n[2] No Cargar Informacion\n[0] Salir");
                    try
                    {
                        o = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Error:" + e.Message);
                        Console.WriteLine("Ingrese valor entre 0-2!");
                    }
                }
                int p1 = o; 
                if (p1 == 1)
                {
                    try
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Stream file = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Empresa empresas2 = (Empresa)formatter.Deserialize(file);
                        file.Close();
                        Console.WriteLine("Leyendo informacion empresa...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Empresa: " + empresa2.nombre+ " Rut: "+empresa2.rut);
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in empresa2.listadivisiones)
                        {

                            Console.WriteLine("Division: " + item.nombre_division+" Encargado: " + item.EncargadoD.nombre+ " " + item.EncargadoD.apellido);
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in empresa2.listadivisiones)
                        {

                            foreach (var item2 in item.listadeareas)
                            {

                                Console.WriteLine("Area: " + item2.nombre_area+" Encargado: " + item2.EncargadoA.nombre+ " " +item2.EncargadoA.apellido);
                            }
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in empresa2.listadivisiones)
                        {

                            foreach (var item2 in item.listadeareas)
                            {
                                foreach (var item3 in item2.listadedep)
                                {
                                    Console.WriteLine("Departamento: " + item3.nombre_departamento+" Encargado: " + item3.EncargadoD.nombre+ " " +item3.EncargadoD.apellido );
                                }
                            }
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in empresa2.listadivisiones)
                        {
                            foreach (var item2 in item.listadeareas)
                            {
                                foreach (var item3 in item2.listadedep)
                                {
                                    foreach (var item4 in item3.listadesecciones)
                                    {
                                        Console.WriteLine("Seccion: " + item4.nombre_seccion+" Encargado: " + item4.EncargadoS.nombre+" "+item4.EncargadoS.apellido);
                                    }
                                }
                            }
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in empresa2.listadivisiones)
                        {
                            foreach (var item2 in item.listadeareas)
                            {
                                foreach (var item3 in item2.listadedep)
                                {
                                    foreach (var item4 in item3.listadesecciones)
                                    {
                                        foreach (var item5 in item4.listadebloques)
                                        {
                                            Console.WriteLine("Bloque: " + item5.nombre_bloque+" Encargado: " + item5.EncargadoB.nombre +" "+ item5.EncargadoB.apellido);
                                        }
                                    }
                                }
                            }
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in empresa2.listadivisiones)
                        {
                            foreach (var item2 in item.listadeareas)
                            {
                                foreach (var item3 in item2.listadedep)
                                {
                                    foreach (var item4 in item3.listadesecciones)
                                    {
                                        foreach (var item5 in item4.listadebloques)
                                        {
                                            Console.WriteLine(item5.nombre_bloque);
                                            Console.WriteLine("Encargado: " + item5.EncargadoB);
                                            foreach (var item6 in item5.listadetrabajadores)
                                            {
                                                Thread.Sleep(1000);
                                                Console.WriteLine("Trabajador: " + item6.nombre+" "+item6.apellido + ", Rut: " + item6.rut);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (FileNotFoundException ez)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + ez.Message);
                        Thread.Sleep(3000);
                        Console.WriteLine("Ingrese estos datos para crear una empresa y serializarla:");
                        Console.WriteLine("Ingrese nombre de la empresa:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese rut de la empresa (solo 9 numeros):");
                        int rut = 0;
                        try
                        {
                            rut = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException ep)
                        {
                            Console.WriteLine("Error:" + ep.Message);
                            Console.WriteLine("Ingrese solo numeros!");
                            Console.WriteLine("Ingrese rut de la empresa (solo numeros):");
                        }
                        rut = Convert.ToInt32(Console.ReadLine());
                        empresa2.nombre = name;
                        empresa2.rut = rut;
                        Console.WriteLine("Empresa creada!");
                        Thread.Sleep(3000);
                        FileStream file = new FileStream("empresa.bin", FileMode.Create);
                        IFormatter bf = new BinaryFormatter();
                        bf.Serialize(file, empresa2);
                        file.Close();
                        Console.WriteLine("Empresa serializada!");
                        Thread.Sleep(3000);

                        Console.WriteLine("Empresa serializada!");
                        Thread.Sleep(2000);
                    }
                    finally
                    {
                        Console.WriteLine("Datos cargados!");
                        
                    }
                    

                }
                else if (p1 == 2)
                {
                    Console.WriteLine("Ingrese estos datos para crear una empresa:");
                    Console.WriteLine("Ingrese nombre de la empresa:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Ingrese rut de la empresa (solo numeros):");
                    int rut = 0;
                    try
                    {
                        rut = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("Error:" + e.Message);
                        Console.WriteLine("Ingrese solo numeros!");
                        Console.WriteLine("Ingrese rut de la empresa (solo numeros):");
                    }
                    rut = Convert.ToInt32(Console.ReadLine());
                    empresa2.nombre = name;
                    empresa2.rut = rut;
                    Console.WriteLine("Empresa creada!");
                    Thread.Sleep(3000);
                    FileStream file = new FileStream("empresa.bin", FileMode.Create);
                    IFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, empresa2);
                    file.Close();
                    Console.WriteLine("Empresa serializada!");
                    Thread.Sleep(3000);
                    
                }
                else if (p1 == 0)
                {
                    a = 6;
                }
                else
                {
                    Console.WriteLine("Valor no dentro de 1-2");
                    Console.WriteLine("Vuelva a intentarlo!");
                }
            }
            Console.WriteLine("Gracias por preferirnos!");
            Console.WriteLine("Vuelva pronto!");
        }
    }
}
