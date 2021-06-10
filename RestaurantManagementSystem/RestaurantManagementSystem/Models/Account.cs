using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Account
    {
        public int Id { get; set; }
        public String Password { get; set; 
        }public String Username { get; set; }
        public String Address { get; set; }
        public String Status { get; set; }
    }
}