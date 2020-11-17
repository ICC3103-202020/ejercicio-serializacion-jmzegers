using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Lab_2_POO
{
    class Method_Storage
    {
        /* Defina un método estático para serializar la información de una empresa junto 
         * con sus divisiones y personal y un método estático que permita deserializar 
         * desde un archivo a una instancia de empresa.
         */

        public static void Info_Serializer(List<Empresa> e)
        {
            IFormatter empresa_formatter = new BinaryFormatter();
            Stream empresa_stream = new FileStream("../../empresa.bin",
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            empresa_formatter.Serialize(empresa_stream, e);
            empresa_stream.Close();
        }

        public static List<Empresa> Info_Deserializer()
        {
            IFormatter datos_empresa_formatter = new BinaryFormatter();

            Stream datos_empresa_stream = File.Open("/../../empresa.bin", 
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            try
            {
                List<Empresa> EmpresaList = 
                    (List<Empresa>)datos_empresa_formatter.Deserialize(datos_empresa_stream);
                datos_empresa_stream.Close();
                return EmpresaList;
            }
            catch
            {
                List<Empresa> EmpresaList = new List<Empresa>();
                datos_empresa_stream.Close();
                return EmpresaList;
            }
        }


        public string OptionFilter(List<string> options, string message, string answer)
        {
            if (options.Contains(answer) == false)
            {
                while (true)
                {
                    Console.WriteLine(message);
                    answer = Convert.ToString(Console.ReadLine());
                    try
                    {
                        options.Contains(answer);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Esta opción no es válida!");
                    }
                }
            }

            return answer;
        }

        public int RUT_Check(int RUT)
        {
            while (true)
            {
                if (RUT < 10000000 || RUT > 100000000)
                {
                    Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                    Console.WriteLine("Sin puntos ni guión");

                    while (true)
                    {
                        try
                        {
                            RUT = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lo que ha dado no es un RUT válido");
                            Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            return RUT;
        }

        public List<string> Random_Name_Creator()
        {
            List<string> nombres = new List<string>()
                { "Antonio", "Francisca", "Gonzalo", "Isabel",
                "Ignacio", "Lucía", "Agustín" };

            List<string> apellidos = new List<string>() { "Fernández", "Caraval", "Tapia",
                    "Antonelli", "Díaz" };

            Random random = new Random();

            int a1 = random.Next(0, 7);
            string random_name = nombres[a1];

            int a2 = random.Next(0, 5);
            string random_last_name = apellidos[a2];

            List<string> name = new List<string>() { random_name, random_last_name };

            return name;
        }

    }
}
