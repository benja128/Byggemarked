using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;


namespace HomeDepotWebApp.Controllers
{
    public class HomeController : Controller
    {
        private HomeDepotContext db = new HomeDepotContext();
        private static Rent rent;

        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public ActionResult UserAuth(Customer req) {
            var customer = db.Customers.Where(c => c.Username.Equals(req.Username) && c.Password.Equals(req.Password)).First();
            if (customer != null) {
                rent = new Rent();
                rent.Customer = customer;
                return RedirectToAction("Overview");
            } else {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Overview() {
            List<Tool> tools = db.Tools.ToList();
            return View(tools);
        }

        public ActionResult Book(int id) {
            Tool tool = db.Tools.Find(id);
            rent.RentTool = tool;
            return View("Book", rent);
        }

        [HttpPost]
        public ActionResult BookConfirm(int Days, string PickUp) {
            rent.Days = Days;
            rent.PickUp = PickUp;
            rent.Status = Status.Reserveret;
            db.Rents.Add(rent);
            db.SaveChanges();
            return View(rent);
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}