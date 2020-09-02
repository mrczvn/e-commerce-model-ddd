﻿using Domain.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Base : Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}