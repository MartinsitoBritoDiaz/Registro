﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Matricula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Sexo { get; set; }
        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            FechaNacimiento = DateTime.Now;
            Sexo = 0;
            Balance = 0;
        }
    }
}
