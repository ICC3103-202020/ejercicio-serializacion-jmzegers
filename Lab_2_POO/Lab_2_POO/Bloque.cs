using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Bloque : Division
    {
        //en particular, para los bloques existe además personal general.

        private List<Persona> Personal_General;
        
        public Bloque(Persona encargado, List<Persona> empleados, List<Persona> personal_general)
            : base(encargado, empleados)
        {
            Personal_General = personal_general;
        }

        public List<Persona> Get_Personal_General()
        {
            return Personal_General;
        }
    }
}
