using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantManagementSystem.Controllers
{
    public class AccountPagesController : Controller
    {
        // GET: AccountPages
        public ActionResult CreateAnAccount()
        {
            return View();
        }



        public ActionResult Login()
        {
            return View();
        }



    }
}