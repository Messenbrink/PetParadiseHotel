using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetParadiseHotel.Models
{
    public class Employee : Person
    {
        [Display(Name = "Initials")]
        public string Initials { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}