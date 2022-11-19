﻿namespace TaskAuthenticationAuthorization.Models
{ 
using System.ComponentModel.DataAnnotations;
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}