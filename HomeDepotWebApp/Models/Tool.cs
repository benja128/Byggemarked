using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models
{
    public class Tool
    {
        [DisplayName("Værktøjs id")]
        public int Id { get; set; }
        [DisplayName("Navn")]
        public String Name { get; set; }
        [DisplayName("Beskrivelse")]
        public String Description { get; set; }
        [DisplayName("Depositum")]
        public double Depos { get; set; }
        [DisplayName("Dags pris")]
        public double DayPrice { get; set; }
    }
}