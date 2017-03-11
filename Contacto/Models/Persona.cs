﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contacto.Models
{
    public class Persona
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*$")]
        [StringLength(32)]
        public string Telefono { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El {0} no puede superar {1} caracteres")]
        public string Comentario { get; set; }

        public IEnumerable<Mujeres> ListMujeres { get; set; }

        public Hombre guagua { get; set; }
    }

    public class Hombre {
        public int CantidadJuegosPlay { get; set; }
    }

    public class Mujeres {
        public int NumeroZapato { get; set; }
    }
}