using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public String Status { get; set; }
        public int capacity { get; set; }
    }
}