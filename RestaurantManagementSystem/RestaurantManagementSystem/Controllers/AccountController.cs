using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantManagementSystem.Controllers
{
    public class AccountPageController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
    }
}