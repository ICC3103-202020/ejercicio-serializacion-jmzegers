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
        private string nombre;
        private string apellido;
        private int rut;
        private string cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Rut { get => rut; set => rut = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public Persona(string nombre, string apellido, int rut, string cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.cargo = cargo;
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
            return Rut;
        }

        public string Get_Cargo()
        {
            return Cargo;
        }
    }
}
