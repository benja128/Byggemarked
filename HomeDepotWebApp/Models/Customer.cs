using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models {
    public class Customer {

        public String Username { get; set; }
        public String Password { get; set; }
        public int CustomerId { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
    }
}