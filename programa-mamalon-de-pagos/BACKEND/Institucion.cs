using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Institucion
    {
        //Propiedades
        public string? IdInstitucion { get; set; }
        public string? Nombre { get; set; }
        public string? Rector { get; set; }
        public string? Direccion { get; set; }

        //Constructor
        public Institucion(string idInstitucion, string nombre, string rector, string direccion)
        {
            IdInstitucion = idInstitucion;
            Nombre = nombre;
            Rector = rector;
            Direccion = direccion;
        }
    }
}
