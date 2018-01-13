using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using adminWebApplication;

namespace adminWebApplication.Controllers
{
    public class Theater_InfoController : Controller
    {
        private projectEntities1 db = new projectEntities1();

        // GET: Theater_Info
        public ActionResult Index()
        {
            return View(db.Theater_Info.ToList());
        }

        // GET: Theater_Info/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Theater_Info theater_Info = db.Theater_Info.Find(id);
            if (theater_Info == null)
            {
                return HttpNotFound();
            }
            return View(theater_Info);
        }

        // GET: Theater_Info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Theater_Info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Theater_Id,T_ID,Theater_Name,Capacity,Location")] Theater_Info theater_Info)
        {
            if (ModelState.IsValid)
            {
                db.Theater_Info.Add(theater_Info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(theater_Info);
        }

        // GET: Theater_Info/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Theater_Info theater_Info = db.Theater_Info.Find(id);
            if (theater_Info == null)
            {
                return HttpNotFound();
            }
            return View(theater_Info);
        }

        // POST: Theater_Info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Theater_Id,T_ID,Theater_Name,Capacity,Location")] Theater_Info theater_Info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theater_Info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theater_Info);
        }

        // GET: Theater_Info/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Theater_Info theater_Info = db.Theater_Info.Find(id);
            if (theater_Info == null)
            {
                return HttpNotFound();
            }
            return View(theater_Info);
        }

        // POST: Theater_Info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Theater_Info theater_Info = db.Theater_Info.Find(id);
            db.Theater_Info.Remove(theater_Info);
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
