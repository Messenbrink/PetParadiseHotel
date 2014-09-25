using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetParadiseHotel.Models;

namespace PetParadiseHotel.Infrastructure
{
    public class Repository
    {
        // create dictionary collection for prices, and define property to get the collection
        Dictionary<string, int> prices = new Dictionary<string, int>();
        public Dictionary<string, int> Prices { get { return prices; } }

        // create List with Reservations, and define property to get the List 
        List<Reservation> reservations = new List<Reservation>();
        public List<Reservation> Reservations { get { return reservations; } }
        public Repository()
        {

            // add prices to the dictionary, prices
            prices.Add("Dog", 180);
            prices.Add("Cat", 140);
            prices.Add("Snake", 120);
            prices.Add("Guinea pig", 75);
            prices.Add("Canary", 60);

            // create customers
            Customer c1 = new Customer(1, "Susan", "Peterson", "Borgergade 45", "8000", "Aarhus", "supe@xmail.dk", "21212121");
            Customer c2 = new Customer(2, "Brian", "Smith", "Algade 108", "8000", "Aarhus", "brsm@xmail.dk", "45454545");
            Reservation r1 = new Reservation(1, "Hamlet", new DateTime(2014, 9, 2), "Dog", new DateTime(2014, 9, 20), new DateTime(2014, 9, 20), c1);
            Reservation r2 = new Reservation(2, "Dog", new DateTime(2014, 9, 14), "Samson", new DateTime(2014, 9, 21), new DateTime(2014, 9, 21), c1);
            Reservation r3 = new Reservation(3, "Cat", new DateTime(2014, 9, 7), "Darla", new DateTime(2014, 9, 10), new DateTime(2014, 9, 10), c2);

            // add Reservations to list of Reservations with instance name reservations
            reservations.Add(r1);
            reservations.Add(r2);
            reservations.Add(r3);
        }
    }
}