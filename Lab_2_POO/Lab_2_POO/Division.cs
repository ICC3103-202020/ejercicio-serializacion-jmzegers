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
        private string Nombre;
        private Persona Encargado;
        private List<Persona> Empleados;
        
        public Division(string name, Persona encargado)
        {
            Encargado = encargado;
            Nombre = name;
        }

        public string Get_Nombre()
        {
            return Nombre;
        }

        public Persona Get_Encargado()
        {
            return Encargado;
        }

    }
}
