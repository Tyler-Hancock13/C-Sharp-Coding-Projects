using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Admin()
        {
            var insurees = db.Insurees;
            var insureeVms = new List<InsureeVm>();
            
            foreach(var insuree in insurees)
            {
                var insureeVm = new InsureeVm();
                insureeVm.FirstName = insuree.FirstName;
                insureeVm.LastName = insuree.LastName;
                insureeVm.EmailAddress = insuree.EmailAddress;
                insureeVm.Quote = insuree.Quote;
                insureeVms.Add(insureeVm);
            }

            return View(insureeVms);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50;

            quote = CheckInsureeAge(insuree.DateOfBirth.Year, quote);
            quote = CheckCarYear(insuree.CarYear, quote);
            quote = CheckCarMakeAndModel(insuree.CarMake.ToLower(), insuree.CarModel.ToLower(), quote);
            quote = CheckSpeedingTickets(insuree.SpeedingTickets, quote);
            quote = CheckForDUI(insuree.DUI, quote);
            quote = CheckCoverageType(insuree.CoverageType, quote);

            insuree.Quote = quote;
            return insuree.Quote;
        }

        private decimal CheckInsureeAge(int yearBorn, decimal quote)
        {
            int insureeAge = DateTime.Now.Year - yearBorn;

            if (insureeAge < 18)
            {
                quote += 100;
            }
            else if (insureeAge > 18 && insureeAge < 25)
            {
                quote += 50;
            }
            else
            {
                quote += 25;
            }

            return quote;
        }

        private decimal CheckCarYear(int carYear, decimal quote)
        {

            if (carYear < 2000)
            {
                quote += 25;
            }
            else if (carYear > 2015)
            {
                quote += 25;
            }

            return quote;
        }

        private decimal CheckCarMakeAndModel(string carMake, string carModel, decimal quote)
        {
            if (carMake == "porsche")
            {
                quote += 25;

                if (carModel == "911 carrera")
                {
                    quote += 25;
                }
            }

            return quote;
        }

        private decimal CheckSpeedingTickets(int tickets, decimal quote)
        {
            for(int i = 0; i < tickets; i++)
            {
                quote += 10;
            }

            return quote;
        }

        private decimal CheckForDUI(bool dui, decimal quote)
        {
            if(dui == true)
            {
                decimal newQuote = quote * 0.25m;
                quote += newQuote;
            }

            return quote;
        }

        private decimal CheckCoverageType(bool coverageType, decimal quote)
        {
            if(coverageType == true)
            {
                decimal newQuote = quote * 0.5m;
                quote += newQuote;
            }

            return quote;
        }
    }
}
