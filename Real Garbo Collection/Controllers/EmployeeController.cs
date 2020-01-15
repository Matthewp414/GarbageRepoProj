using Microsoft.AspNet.Identity;
using Real_Garbo_Collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Garbo_Collection.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult GetPickUps()
        {
            var Id = User.Identity.GetUserId();
            ViewModel viewModel = new ViewModel();
            var employee = db.Employees.Where(e => e.ApplicationId == Id).FirstOrDefault();            
            var customers = db.People.Where(c => c.zip == employee.zip);
            viewModel.Customers = customers.ToList();
            ViewBag.Dropdown = new SelectList(new List<string> { "monday", "tuesday", "wensday", "thursday", "friday", "saturday", "sunday" });
            viewModel.ListOfDays = ViewBag.Dropdown;
            return View(viewModel);            
        }
        [HttpPost]
        public ActionResult GetPickUps(ViewModel viewModel)
        {
            var Id = User.Identity.GetUserId();
            ViewModel model = new ViewModel();
            model = viewModel;
            ViewBag.Dropdown = new SelectList(new List<string> { "monday", "tuesday", "wensday", "thursday", "friday", "saturday", "sunday" });

            model.ListOfDays = ViewBag.Dropdown;
            var employee = db.Employees.Where(e => e.ApplicationId == Id).FirstOrDefault();
            var customers = db.People.Where(c => c.PickUpdate.ToLower() == model.Day);
            model.Customers = customers.ToList();

            return View(model);
        }

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            ViewBag.Application = new SelectList(db.Users, "Id", "Email");
            return View();
           
        }

        
       
        // POST:Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,PickUpdate,StreetAddress,SuspendStart,SuspendEnd")] Employee customer)
        {
            if (ModelState.IsValid)
            {
                customer.ApplicationId = User.Identity.GetUserId();
                db.Employees.Add(customer);
                db.SaveChanges();
                return RedirectToAction("GetPickUp");
            }

            return View(customer);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
