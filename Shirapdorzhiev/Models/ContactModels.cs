﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.ComponentModel.DataAnnotations;

namespace Shirapdorzhiev.Models
{
    public class ContactModels
    {
        [Required(ErrorMessage ="Необходимо ваше имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Необходима фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Необходим ваш Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите текст, пожалуйста")]
        public string Comment { get; set; }
    }


}