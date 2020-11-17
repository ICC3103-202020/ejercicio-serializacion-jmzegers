using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_2_POO
{
    [Serializable]
    public class Persona
    {
        /* Además defina una clase ”Persona” que tenga la información básica del personal (nombre, apellido,
         * rut, cargo).
         */
        private string Nombre;
        private string Apellido;
        private int RUT;
        private string Cargo;

        public Persona(string nombre, string apellido, int rut, string cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            RUT = rut;
            Cargo = cargo;
        }

        public string Get_Nombre()
        {
            return Nombre;
        }

        public string Get_Apellido()
        {
            return Apellido;
        }

        public int Get_RUT()
        {
            return RUT;
        }

        public string Get_Cargo()
        {
            return Cargo;
        }
    }
}
