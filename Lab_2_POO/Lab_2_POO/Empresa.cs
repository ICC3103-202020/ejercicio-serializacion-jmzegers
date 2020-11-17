using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Lab_2_POO
{
    [Serializable]
    public class Empresa
    {
        /*Defina una clase Empresa que tenga nombre y rut de la empresa.
        */

        private string Nombre_Empresa;
        private int Rut_Empresa;
        private List<Division> Divisiones;

        //Agregue a su empresa una lista de divisiones.
        public Empresa(string name, int rut)
        {
            name = Nombre_Empresa;
            rut = Rut_Empresa;
            List<Division> divisiones = Divisiones;
        }



        public string Get_Nombre()
        {
            return Nombre_Empresa;
        }

        public int Get_RUT()
        {
            return Rut_Empresa;
        }

        public List<Division> Get_Divisiones()
        {
            return Divisiones;
        }

        public static void Almacenar_Datos_Empresa(List<Empresa> e)
        {
            IFormatter empresa_formatter = new BinaryFormatter();
            Stream empresa_stream = new FileStream("../../empresa.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            empresa_formatter.Serialize(empresa_stream, e);
            empresa_stream.Close();
        }

        /* Si no existe dicho archivo, con manejo de excepciones, solicite los datos de la empresa como en
         * la Parte 1 y después su programa debe crear un departamento, una sección y dos bloques donde
         * cada división tenga un encargado único y en cada bloque deben haber 2 personas como parte del
         * personal.
         */
        public static List<Empresa> Cargar_Datos_Empresa()
        {
            Method_Storage ms = new Method_Storage();
            IFormatter datos_empresa_formatter = new BinaryFormatter();

            Stream datos_empresa_stream = File.Open("/../../empresa.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            try
            {
                List<Empresa> EmpresaList = (List<Empresa>)datos_empresa_formatter.Deserialize(datos_empresa_stream);
                datos_empresa_stream.Close();
                return EmpresaList;
            }
            catch
            {
                List<Empresa> EmpresaList = new List<Empresa>();
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

                Random random = new Random();

                //Nuevo departamento
                List<string> nombre_persona = ms.Random_Name_Creator();
                int rut = random.Next(10000000, 100000000);
                Persona encargado = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Profesor");
                List<Seccion> secciones = new List<Seccion>();
                Departamento nuevo_depto = new Departamento("Educación", encargado, secciones);

                //Nueva sección
                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                encargado = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Historiador");
                List<Bloque> bloques = new List<Bloque>();
                Seccion nueva_seccion = new Seccion("Investigación", encargado, bloques);

                //Nuevos bloques
                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                encargado = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Auxiliar Jefe");
                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                Persona empleado_1 = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Auxiliar");
                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                Persona empleado_2 = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Auxiliar");
                List<Persona> empleados_bloque_1 = new List<Persona>() { empleado_1, empleado_2 };
                Bloque bloque_1 = new Bloque("Limpieza", encargado, empleados_bloque_1);

                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                encargado = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Economista");
                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                Persona empleado_3 = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Contador");
                nombre_persona = ms.Random_Name_Creator();
                rut = random.Next(10000000, 100000000);
                Persona empleado_4 = new Persona(nombre_persona[0],
                    nombre_persona[1], rut, "Contador");
                List<Persona> empleados_bloque_2 = new List<Persona>() { empleado_3, empleado_4 };
                Bloque bloque_2 = new Bloque("Manejo de dinero", encargado, empleados_bloque_2);

                nueva_seccion.Get_Bloques().Add(bloque_1);
                nueva_seccion.Get_Bloques().Add(bloque_2);
                nuevo_depto.Get_Secciones().Add(nueva_seccion);
                nueva_empresa.Get_Divisiones().Add(nuevo_depto);

                List<Empresa> empresaList = new List<Empresa>();
                empresaList.Add(nueva_empresa);
                Almacenar_Datos_Empresa(empresaList);
                datos_empresa_stream.Close();
                return EmpresaList;
            }
        }

    }
}
