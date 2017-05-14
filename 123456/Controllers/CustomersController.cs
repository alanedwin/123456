using _123456.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _123456.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            if(User.IsInRole(RoleName.PortalManager))
            return View("List",customers);
            return View("ReadOnlyList", customers);
        }
        [Authorize(Roles = RoleName.PortalManager)]
        public ActionResult New(Customer customer)
        {
            return View("CustomerForm", customer);
        }

        [HttpPost]
        public ActionResult Save(Customer customer, HttpPostedFileBase file)
        {

            if (!ModelState.IsValid)
            {
                return View("CustomerForm",customer);
            }

            if (!object.ReferenceEquals(null, file))
            {
                if (file.ContentLength > 0)
                {
                    customer.Image = new byte[file.ContentLength];
                    file.InputStream.Read(customer.Image, 0, file.ContentLength);

                }
            }

            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.ForeName = customer.ForeName;
                customerInDb.Surname = customer.Surname;
                customerInDb.Telephone = customer.Telephone;
                if (!object.ReferenceEquals(null, customer.Image))
                    customerInDb.Image = customer.Image;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            if (customer.Image != null)
            {

                ViewBag.Base64String = "data:image/png;base64," + Convert.ToBase64String(customer.Image, 0, customer.Image.Length);
            }

            return View(customer);
        }

        public ActionResult Edit(int id, HttpPostedFileBase file)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer.Image != null)
            {

                ViewBag.Base64String = "data:image/png;base64," + Convert.ToBase64String(customer.Image, 0, customer.Image.Length);
            }

            if (customer == null)
                return HttpNotFound();

            return View("CustomerForm", customer);
        }


       



    }
}