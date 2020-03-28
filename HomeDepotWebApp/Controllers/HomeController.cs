using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeDepotWebApp.Controllers
{
    public class HomeController : Controller
    {
        private HomeDepotContext db = new HomeDepotContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer req) {
            var customer = db.Customers.Where(c => c.Username.Equals(req.Username) && c.Password.Equals(req.Password)).FirstOrDefault();
            if(customer == null) {
                return RedirectToAction("Index");
            } else {
                return View("Overview", customer);
            }

        }

        public ActionResult Overview(Customer customer) {
            List<Tool> tools = db.Tools.ToList();
            return View(tools);
        }


        public ActionResult Book(Customer customer, int id) {
            Rent rent = new Rent();
            rent.Customer = customer;
            rent.RentTool = db.Tools.Find(id);
            return View("BookConfirm", rent);
        }

        [HttpPost]
        public ActionResult BookConfirm(Rent rent) {
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