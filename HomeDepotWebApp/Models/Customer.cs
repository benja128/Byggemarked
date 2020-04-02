using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models {
    public class Customer {

        [DisplayName("Brugernavn")]
        [Required(ErrorMessage = "Indtast brugernavn")]
        public String Username { get; set; }
        [DisplayName("Kodeord")]
        [Required(ErrorMessage = "Indtast kodeord")]
        public String Password { get; set; }
        [DisplayName("Kunde nr")]
        public int CustomerId { get; set; }
        [DisplayName("Navn")]
        public String Name { get; set; }
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}