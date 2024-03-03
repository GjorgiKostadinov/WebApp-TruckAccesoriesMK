using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppOfficial.Models
{
    public class Client
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Задолжително е вашето ИМЕ !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Задолжително е вашето ПРЕЗИМЕ !")]
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        

    }
}