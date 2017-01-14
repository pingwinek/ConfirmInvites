using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podaj swoje imię i nazwisko")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podaj swój email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Adres email jest niepoprawny")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj swój nr telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określ czy weźmiesz udział")]
        public bool? WillAttend { get; set; }
    }
}