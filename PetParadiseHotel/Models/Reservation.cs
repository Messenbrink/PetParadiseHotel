using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string PetName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Specie { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
    }
}