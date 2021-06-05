using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int CreatedOn { get; set; }
        public String NotificationContent { get; set; }
    }
}