﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Curso
    {
        // Propiedades
        public int IDCurso { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }
        public Profesor ProfesorEncargado { get; set; }

        // Constructor
        public Curso(int idCurso, string nombreCurso, string descripcion, Profesor profesorEncargado)
        {
            IDCurso = idCurso;
            NombreCurso = nombreCurso;
            Descripcion = descripcion;
            ProfesorEncargado = profesorEncargado;
        }

        // Métodos
        public string ObtenerInformacion()
        {
            return $"ID: {IDCurso}, Nombre del Curso: {NombreCurso}, Descripción: {Descripcion}, Profesor Encargado: {ProfesorEncargado.Nombre} {ProfesorEncargado.Apellido}";
        }

        public void ActualizarInformacion(string nuevoNombre, string nuevaDescripcion, Profesor nuevoProfesor)
        {
            NombreCurso = nuevoNombre;
            Descripcion = nuevaDescripcion;
            ProfesorEncargado = nuevoProfesor;
        }

        public void EliminarCurso()
        {
            // Implementa la lógica para eliminar un curso de la base de datos.
            // Por ejemplo: BaseDeDatos.EliminarCurso(IDCurso);
        }
    }
}
