using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Departamento : Division
    {
        //una empresa con mucho personal se divide en áreas y las áreas en departamentos

        private List<Seccion> Secciones;
        
        public Departamento(string nombre, Persona encargado, List<Seccion> secciones)
            : base(nombre, encargado)
        {
            Secciones = secciones;
        }

        public List<Seccion> Get_Secciones()
        {
            return Secciones;
        }
    }
}
