﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleFinanceiro.Entidades
{
    public class Usuario
    {
        [Required, Key]
        public int IdUsuario { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}