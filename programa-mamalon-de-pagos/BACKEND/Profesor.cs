﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Profesor
    {
        // Propiedades
        public int IDProfesor { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public List<string> Asignaturas { get; set; }

        // Constructor
        public Profesor(int idProfesor, string nombreCompleto, string direccion, string correoElectronico, string telefono)
        {
            IDProfesor = idProfesor;
            NombreCompleto = nombreCompleto;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Asignaturas = new List<string>();
        }

        // Método para asignar cursos al profesor
        public void AsignarAsignatura(string asignatura)
        {
            Asignaturas.Add(asignatura);
        }

        // Método para obtener la lista de asignaturas del profesor
        public List<string> ObtenerAsignaturas()
        {
            return Asignaturas;
        }
        // Método para actualizar información del profesor
        public void ActualizarInformacion(string nuevoNombre, string nuevoApellido, string nuevaDireccion, string nuevoCorreo, string nuevoTelefono)
        {
            NombreCompleto = nuevoNombre;;
            Direccion = nuevaDireccion;
            CorreoElectronico = nuevoCorreo;
            Telefono = nuevoTelefono;
        }
    }
}