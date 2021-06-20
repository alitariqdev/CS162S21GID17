using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantManagementSystem.Controllers
{
    public class AccountController : ApiController
    {

        [HttpPost]
        public bool AddAccount(Account obj)
        {
            try
            {

                AccountsDbEntities db = new AccountsDbEntities();
                AccountsTable dbObj = new AccountsTable();
            
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
        }


        [HttpGet]
        public List<Account> AllAccounts()
        {
            List<Account> list = new List<Account>();

            AccountsDbEntities db = new AccountsDbEntities();
             
            var dbList = db.AccountsTables.ToList();

            foreach (var dbObj in dbList)
            {


                Account acc = new Account();
                acc.Email = dbObj.Email;
                acc.FirstName = dbObj.FirstName;
                acc.LastName = dbObj.LastName;
                acc.Contact = dbObj.Contact;
                list.Add(acc);
            }
                return list;
        }
    }
}
