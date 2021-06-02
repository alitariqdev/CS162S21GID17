using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Employee
    {
        public String EmployeeId { get; set; }
        public DateTime dateofJoining { get; set; }
        public Double Salary { get; set; }
    }
}