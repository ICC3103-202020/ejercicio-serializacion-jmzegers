using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    [Serializable]
    public class Seccion : Division
    {
        private List<Bloque> bloques;
        public List<Bloque> Bloques { get => bloques; set => bloques = value; }

        public Seccion(string nombre, Persona encargado, List<Bloque> bloques)
            : base(nombre, encargado)
        {
            this.bloques = bloques;
        }

        public List<Bloque> Get_Bloques()
        {
            return Bloques;
        }
    }
}
