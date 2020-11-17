﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_POO
{
    public class Area : Division
    {
        /* Una empresa con mucho personal se divide en áreas y las áreas en departamentos.
         */

        private List<Departamento> Departamentos;
        
        public Area(string nombre, Persona encargado, List<Departamento> departamentos)
            : base(nombre, encargado)
        {
            Departamentos = departamentos;
        }

        public List<Departamento> Get_Deptos()
        {
            return Departamentos;
        }
    }
}
