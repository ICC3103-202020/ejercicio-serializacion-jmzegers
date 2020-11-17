using System;
using System.Collections.Generic;
using System.Text;



namespace Lab_2_POO
{
    [Serializable]
    public class Area : Division
    {
        /* Una empresa con mucho personal se divide en áreas y las áreas en departamentos.
         */

        private List<Departamento> departamentos;
        public List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }

        public Area(string nombre, Persona encargado, List<Departamento> departamentos)
            : base(nombre, encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
            this.departamentos = departamentos;
        }

        public List<Departamento> Get_Deptos()
        {
            return Departamentos;
        }
    }
}
