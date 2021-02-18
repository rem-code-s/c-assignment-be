﻿using System.ComponentModel.DataAnnotations;

namespace AccountApi.Dtos
{
    public class LoginDto
    {
        [MinLength(length: 3, ErrorMessage = "MinLength is 3 characters"), Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [MinLength(length: 6, ErrorMessage = "MinLength is 6 characters"), Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
