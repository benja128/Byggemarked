using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models {
    public class Rent {
        [DisplayName("Booking id")]
        public int Id { get; set; }
        [DisplayName("Værktøj")]
        public virtual Tool RentTool { get; set; }
        [DisplayName("Kunde")]
        public virtual Customer Customer { get; set; }
        [DisplayName("Afhentningstidpunkt")]
        public String PickUp { get; set; }
        [DisplayName("Antal dage")]
        public int Days { get; set; }
        [DisplayName("Booking status")]
        public Status Status { get; set; }
    }

    public enum Status {
        Reserveret, Udleveret, TilbageLeveret
    }
}