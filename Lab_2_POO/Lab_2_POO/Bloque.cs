using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    [Serializable]
    public class Bloque : Division
    {
        //en particular, para los bloques existe además personal general.

        private List<Persona> personal_General;
        public List<Persona> Personal_General { get => personal_General; set => personal_General = value; }

        public Bloque(string nombre, Persona encargado, List<Persona> personal_general)
            : base(nombre, encargado)
        {
            this.personal_General = personal_general;
        }

        

        public List<Persona> Get_Personal_General()
        {
            return Personal_General;
        }
    }
}
