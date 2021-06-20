using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantManagementSystem.Controllers
{
    public class ReservationController : ApiController
    {

        public bool AddReservation() {
           

            try
            {

                AccountsDbEntities1 a = new AccountsDbEntities1();

                reservation_table rs = new reservation_table();
             

                dbObj.FirstName = obj.FirstName;
                dbObj.LastName = obj.LastName;
                dbObj.Contact = obj.Contact;
                dbObj.Email = obj.Email;
                db.AccountsTables.Add(dbObj);
                db.SaveChanges();


                Console.WriteLine("IN the controller try");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("IN the controller catch");
                return false;
            }




            return true;
        }





    }
}
