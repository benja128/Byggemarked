using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models {
    public class Rent {

        public int Id { get; set; }
        public Tool RentTool { get; set; }
        public Customer Customer { get; set; }
        public String PickUp { get; set; }
        public int Days { get; set; }
        public Boolean Status { get; set; }
    }
}