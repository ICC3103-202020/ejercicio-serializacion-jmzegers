using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Bloque : Division
    {
        //en particular, para los bloques existe además personal general.

        private readonly List<Persona> Personal_General;
        
        public Bloque(string nombre, Persona encargado, List<Persona> personal_general)
            : base(nombre, encargado)
        {
            Personal_General = personal_general;
        }

        public List<Persona> Get_Personal_General()
        {
            return Personal_General;
        }
    }
}
