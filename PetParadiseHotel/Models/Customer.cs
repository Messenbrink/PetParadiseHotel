using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetParadiseHotel.Models
{
    public class Customer : Person
    {
        [Display(Name = "Address")]
        public string Address { get; set; }

        [RegularExpression(@"\d{4}")]
        [StringLength(4)]
        [Display(Name = "Zipcode")]
        public string Zipcode { get; set; }

        [RegularExpression(@"[A-Za-zØøÅåÆæ]")]
        [Display(Name = "City")]
        [StringLength(50, MinimumLength = 2)]
        public string City { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [RegularExpression(@"\d{8}")]
        [StringLength(8)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}