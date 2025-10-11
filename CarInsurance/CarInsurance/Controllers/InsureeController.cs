using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private CarInsuranceEntities db = new CarInsuranceEntities();

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
                // --- QUOTE CALCULATION LOGIC ---
                decimal quoteTotal = 50.00m; // 1. Start with a base of $50 / month

                // Calculate Age from DateOfBirth
                var today = DateTime.Today;
                var age = today.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth.Date > today.AddYears(-age))
                {
                    age--; // Adjust age if birthday hasn't occurred this year
                }

                // 2. AGE-BASED ADDITIONS
                if (age <= 18)
                {
                    quoteTotal += 100m; // 18 or under, add $100
                }
                else if (age >= 19 && age <= 25)
                {
                    quoteTotal += 50m;  // 19 to 25, add $50
                }
                else if (age >= 26)
                {
                    quoteTotal += 25m;  // 26 or older, add $25
                }

                // 3. CAR YEAR ADDITIONS
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quoteTotal += 25m; // Before 2000 or after 2015, add $25
                }

                // 4. CAR MAKE/MODEL ADDITIONS
                if (insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
                {
                    quoteTotal += 25m; // Porsche adds $25

                    // Check for 911 Carrera (additional $25)
                    if (insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                    {
                        quoteTotal += 25m;
                    }
                }

                // 5. SPEEDING TICKETS
                // Add $10 for every speeding ticket
                quoteTotal += insuree.SpeedingTickets * 10m;

                // 6. DUI PENALTY (25% increase)
                if (insuree.DUI)
                {
                    // Increase by 25% (multiply by 1.25)
                    quoteTotal *= 1.25m;
                }

                // 7. COVERAGE TYPE PENALTY (50% increase)
                if (insuree.CoverageType) // Assuming 'True' means full coverage
                {
                    // Increase by 50% (multiply by 1.50)
                    quoteTotal *= 1.50m;
                }

                // Set the calculated amount and save
                insuree.Quote = quoteTotal;


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

        // --- ADMIN VIEW ACTION ---
        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            // Retrieve ALL Insuree records (all quotes)
            var insurees = db.Insurees.ToList();

            // Pass the full list to the Admin view for review
            return View(insurees);
        }
        // --- END ADMIN VIEW ACTION ---

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
