﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos
{
    public class Estudiante
    {
        // Propiedades(Puede que falte alguna, pero estas serian las mas importantes)
        public int Carnet { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string CarreraGrado { get; set; }
        public string Seccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string? Jornada { get; set; }

        // Constructor
        public Estudiante(int carnet, string nombreCompleto, DateTime fechaDeNacimiento, string carreragrado, string seccion, string correoElectronico, string telefono, string jornada)
        {
            Carnet = carnet;
            NombreCompleto = nombreCompleto;
            FechaDeNacimiento = fechaDeNacimiento;
            CarreraGrado = carreragrado;
            Seccion = seccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Jornada = jornada;
        }
        //Metodo para actualizar la info
        public void ActualizarInformacion(string nuevoNombre, string nuevoApellido,DateTime nuevaFechaDeNacimiento, string nuevaCarreraGrado, string nuevaSeccion, string nuevoCorreo, string nuevoTelefono, string nuevaJornada)
        {
            NombreCompleto = nuevoNombre;
            FechaDeNacimiento = nuevaFechaDeNacimiento;
            CarreraGrado = nuevaCarreraGrado;
            Seccion = nuevaSeccion;
            CorreoElectronico = nuevoCorreo;
            Telefono = nuevoTelefono;
            Jornada = nuevaJornada;
        }
    }

}
