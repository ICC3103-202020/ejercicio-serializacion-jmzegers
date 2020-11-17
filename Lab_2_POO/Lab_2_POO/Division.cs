using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_2_POO
{
    /*Defina una clase llamada ”División” que tenga un nombre. De esta clase heredarán las clases
     * ”Área”, ”Departamento”, ”Sección” y ”Bloque”, tenga en cuenta las composiciones respectivas.
     */
    [Serializable]
    public class Division
    {
        private string nombre;
        private Persona encargado;

        public string Nombre { get => nombre; set => nombre = value; }
        public Persona Encargado { get => encargado; set => encargado = value; }

        public Division(string nombre, Persona encargado)
        {
            this.encargado = encargado;
            this.nombre = nombre;
        }

        public string Get_Nombre()
        {
            return nombre;
        }

        public Persona Get_Encargado()
        {
            return encargado;
        }

    }
}
