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

        public static List<Empresa> Cargar_Datos_Empresa()
        {
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
                datos_empresa_stream.Close();
                return EmpresaList;
            }
        }

    }
}
