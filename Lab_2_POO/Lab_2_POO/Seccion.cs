using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Seccion : Division
    {
        private List<Bloque> Bloques;
        
        public Seccion(string nombre, Persona encargado, List<Bloque> bloques)
            : base(nombre, encargado)
        {
            Bloques = bloques;
        }

        public List<Bloque> Get_Bloques()
        {
            return Bloques;
        }
    }
}
