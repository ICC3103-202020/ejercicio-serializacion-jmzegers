using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Departamento : Division
    {
        //una empresa con mucho personal se divide en áreas y las áreas en departamentos

        private List<Seccion> Secciones;
        
        public Departamento(Persona encargado, List<Persona> empleados, List<Seccion> secciones) : base(encargado, empleados)
        {
            Secciones = secciones;
        }

        public List<Seccion> Get_Secciones()
        {
            return Secciones;
        }
    }
}
