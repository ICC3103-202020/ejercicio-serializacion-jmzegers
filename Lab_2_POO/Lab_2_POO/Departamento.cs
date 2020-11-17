using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    [Serializable]
    public class Departamento : Division
    {
        //una empresa con mucho personal se divide en áreas y las áreas en departamentos

        private List<Seccion> secciones;
        public List<Seccion> Secciones { get => secciones; set => secciones = value; }

        public Departamento(string nombre, Persona encargado, List<Seccion> secciones)
            : base(nombre, encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
            this.secciones = secciones;
        }

        public List<Seccion> Get_Secciones()
        {
            return secciones;
        }
    }
}
