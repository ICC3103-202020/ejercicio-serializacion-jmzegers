using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Seccion : Division
    {
        private List<Bloque> Bloques;
        
        public Seccion(Persona encargado, List<Persona> empleados, List<Bloque> bloques) : base(encargado, empleados)
        {
            Bloques = bloques;
        }

        public List<Bloque> Get_Bloques()
        {
            return Bloques;
        }
    }
}
