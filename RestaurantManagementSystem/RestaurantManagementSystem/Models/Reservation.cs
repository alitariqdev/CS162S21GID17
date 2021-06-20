using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Reservation : Person
    {
        
        public String ReservationId { get; set; }
        public String PeopleCount { get; set; }
        public DateTime TimeOfReservation { get; set; }
        public String Message { get; set; }
        public String StatusOfReservation { get; set; }
    }
}