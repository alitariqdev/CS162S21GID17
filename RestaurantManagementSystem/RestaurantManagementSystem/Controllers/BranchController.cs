using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantManagementSystem.Controllers
{
    public class BranchController : Controller
    {
        // GET: Branch
        public ActionResult AddBranch()
        {
            return View();
        }  public ActionResult ListOfBranches()
        {
            return View();
        } public ActionResult ReservationPage()
        {
            return View();
        }
    }
}