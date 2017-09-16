﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required, MaxLength(256)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
