using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        //Method for generating quote value. Runs whenever a insurer is entered into the system or if the information of an insurer is edited. 

        public void GenerateQuote(Table insurer)
        {
            // This has the initial insuranceQuote value and calculates the insurer's age. 
            int insuranceQuote = 50;
            var insurerTimeSpanAge = (DateTime.Now - insurer.DateOfBirth);
            int insurerIntAge = Convert.ToInt32(insurerTimeSpanAge.Days) / 365;


            //This block holds all the different criteria that adjust the monthly insurance quote. 
            if (insurerIntAge <= 18) { insuranceQuote += 100; }
            if (insurerIntAge >= 19 && insurerIntAge <= 25) { insuranceQuote += 50; }
            if (insurerIntAge > 25) { insuranceQuote += 25; }
            if (insurer.CarYear < 2000) { insuranceQuote += 25; }
            if (insurer.CarYear > 2015) { insuranceQuote += 25; }
            if (insurer.CarMake == "Porsche") { insuranceQuote += 25; }
            if (insurer.CarMake == "Porsche" && insurer.CarModel == "911 Carrera") { insuranceQuote += 25; }
            insuranceQuote += insurer.SpeedingTickets * 10;
            if (insurer.DUI) { insuranceQuote += insuranceQuote / 4; }
            if (insurer.CoverageType) { insuranceQuote += insuranceQuote / 2; }

            //Setting the generated insurerQuote as the specific insurer.Quote on the object and saving the changes made. 
            insurer.Quote = insuranceQuote;
            db.SaveChanges();

        }

        public ActionResult Admin()
        {
            List<Table> insurerList = db.Tables.ToList();           
            return View(insurerList);
        }
        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                GenerateQuote(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            GenerateQuote(table);
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                GenerateQuote(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            GenerateQuote(table);
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
