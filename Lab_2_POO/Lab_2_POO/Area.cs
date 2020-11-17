using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Area : Division
    {
        /* Una empresa con mucho personal se divide en áreas y las áreas en departamentos.
         */

        private List<Departamento> Departamentos;
        
        public Area(Persona encargado, List<Persona> empleados, List<Departamento> departamentos)
            : base(encargado, empleados)
        {
            Departamentos = departamentos;
        }

        public List<Departamento> Get_Deptos()
        {
            return Departamentos;
        }
    }
}
