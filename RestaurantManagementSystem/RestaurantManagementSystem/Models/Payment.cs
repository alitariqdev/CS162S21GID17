using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public Double Amount { get; set; }
        public Double Tax { get; set; }
    }
}