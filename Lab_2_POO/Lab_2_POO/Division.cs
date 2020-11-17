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
        private Persona Encargado;
        private List<Persona> Empleados;
        
        public Division(Persona encargado, List<Persona> empleados)
        {
            Encargado = encargado;
            Empleados = empleados;
        }

        public Persona Get_Encargado()
        {
            return Encargado;
        }

        public List<Persona> Get_Empleados()
        {
            return Empleados;
        }
    }
}
