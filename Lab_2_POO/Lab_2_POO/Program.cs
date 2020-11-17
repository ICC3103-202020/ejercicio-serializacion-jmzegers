using System;
using System.Collections.Generic;

namespace Lab_2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* En su método Main, pregunte al usuario si quiere utilizar un archivo para cargar la información
             * de la empresa
             * 
             * Actualice el Main, de tal manera que cuando se lea el archivo de ”empresa.bin”, recorra la
             * estructura de la empresa imprimiendo en consola el nombre de cada división con su encargado
             * hasta llegar a los bloques e imprimir el nombre del personal del bloque.

             * Finalmente debe serializar la empresa en un archivo con nombre ”empresa.bin”.
             */

            Method_Storage ms = new Method_Storage();

            string message = "Desea utilizar un archivo para cargar la información de su empresa? [Y/N]";
            Console.WriteLine(message);
            List<string> options = new List<string>() { "Y", "N" };
            string answer = Convert.ToString(Console.ReadLine());

            string right_answer = ms.OptionFilter(options, message, answer);

            /*Si el usuario indica que si, entonces utilice BinaryFormatter para leer los datos de la empresa
             * del archivo ”empresa.bin”. Si el archivo no existe, con manejo de excepciones, solicite los datos al
             * usuario y escriba el archivo como en el párrafo anterior.
             */

            if (right_answer == "Y")
            {
                List<Empresa> EmpresaList = Empresa.Cargar_Datos_Empresa();
                
                if(EmpresaList.Count == 0)
                {
                    Console.WriteLine("Este archivo no existe!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Por favor, ingrese el nombre de su empresa");
                    string nombre_empresa = Convert.ToString(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                    Console.WriteLine("Sin puntos ni guión");
                    int rut_empresa;
                    while (true)
                    {
                        try
                        {
                            rut_empresa = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lo que ha dado no es un RUT válido");
                            Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                        }
                    }

                    int right_RUT = ms.RUT_Check(rut_empresa);
                    Empresa nueva_empresa = new Empresa(nombre_empresa, right_RUT);
                    List<Empresa> empresaList = new List<Empresa>();
                    Empresa.Almacenar_Datos_Empresa(empresaList);
                }

                /* Cuando se lea el archivo de ”empresa.bin”, recorra la 
                 * estructura de la empresa imprimiendo en consola el 
                 * nombre de cada división con su encargado hasta llegar 
                 * a los bloques e imprimir el nombre del personal del bloque.
                 */
                else
                {
                    foreach (Empresa e in EmpresaList)
                    {
                        Console.WriteLine(e.Get_Nombre());
                        List<Division> lista_divisiones = e.Get_Divisiones();
                        foreach (Area a in lista_divisiones)
                        {
                            Console.WriteLine(a.Get_Nombre());
                            foreach (Departamento depto in a.Get_Deptos())
                            {
                                Console.WriteLine(depto.Get_Nombre());
                                foreach (Seccion seccion in depto.Get_Secciones())
                                {
                                    Console.WriteLine(seccion.Get_Nombre());
                                    foreach (Bloque bloque in seccion.Get_Bloques())
                                    {
                                        Console.WriteLine(bloque.Get_Nombre());
                                        foreach (Persona empleado in bloque.Get_Personal_General())
                                        {
                                            Console.WriteLine(empleado.Get_Nombre());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                

            }
            


            /* Si el usuario indica que no, entonces solicite al usuario que ingrese el nombre y rut de
             * la empresa y guarde estos datos en un archivo llamado ”empresa.bin” utilizando BinaryFormatter.
            */
            else if (right_answer == "N")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Por favor, ingrese el nombre de su empresa");
                string nombre_empresa = Convert.ToString(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                Console.WriteLine("Sin puntos ni guión. Si es K, escriba un cero");
                int rut_empresa;
                while (true)
                {
                    try
                    {
                        rut_empresa = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Lo que ha dado no es un RUT válido");
                        Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                        Console.WriteLine("Sin puntos ni guión. Si es K, escriba un cero");
                    }
                }

                int right_RUT = ms.RUT_Check(rut_empresa);
                Empresa nueva_empresa = new Empresa(nombre_empresa, right_RUT);
                List<Empresa> empresaList = new List<Empresa>();
                Empresa.Almacenar_Datos_Empresa(empresaList);
            }
        }
    }
}
