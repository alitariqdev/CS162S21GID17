using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public Double Amount { get; set; }
        public Double Tax { get; set; }
    }
}