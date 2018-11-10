﻿using System.ComponentModel.DataAnnotations;

namespace DziennikTreningowy.DTO
{
    public class UserLoginDTO
    {
        /// <summary>
        /// Nazwa użytkownika
        /// </summary>
        [Required]
        public string Username { get; set; }
        /// <summary>
        /// Hasło użytkownika
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
