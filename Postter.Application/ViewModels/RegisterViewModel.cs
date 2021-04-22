﻿using System.ComponentModel.DataAnnotations;
namespace Postter.Application.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Не указан email")]
        public string Email { get; set; }
         
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Не указано имя пользователя")]
        public string Nickname { get; set; }
         
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}