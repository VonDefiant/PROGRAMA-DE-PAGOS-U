using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Facultades
    {
        //Propiedades
        public string? IdFacultad { get; set; }
        public string? Nombre { get; set; }
        public string? Decano { get; set; }
        public Institucion Institucion { get; set; }

        //Constructor
        public Facultades(string idFacultad, string nombre, string decano, Institucion institucion)
        {
            IdFacultad = idFacultad;
            Nombre = nombre;
            Decano = decano;
            Institucion = institucion;
        }
    }
}
