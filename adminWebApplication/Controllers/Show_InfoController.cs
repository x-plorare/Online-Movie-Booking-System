using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using adminWebApplication;

namespace adminWebApplication.Controllers
{
    public class Show_InfoController : Controller
    {
        private projectEntities1 db = new projectEntities1();

        // GET: Show_Info
        public async Task<ActionResult> Index()
        {
            var show_Info = db.Show_Info.Include(s => s.Movie_Info).Include(s => s.Theater_Info).Include(s => s.Employee_Info);
            return View(await show_Info.ToListAsync());
        }

        // GET: Show_Info/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show_Info show_Info = await db.Show_Info.FindAsync(id);
            if (show_Info == null)
            {
                return HttpNotFound();
            }
            return View(show_Info);
        }

        // GET: Show_Info/Create
        public ActionResult Create()
        {
            ViewBag.Movie_Id = new SelectList(db.Movie_Info, "Movie_Id", "M_ID");
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID");
            ViewBag.Employee_Id = new SelectList(db.Employee_Info, "Employee_Id", "E_ID");
            return View();
        }

        // POST: Show_Info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Show_Id,S_ID,Theater_Id,Movie_Id,Show_Date,Start_Time,Price,Employee_Id")] Show_Info show_Info)
        {
            if (ModelState.IsValid)
            {
                db.Show_Info.Add(show_Info);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Movie_Id = new SelectList(db.Movie_Info, "Movie_Id", "M_ID", show_Info.Movie_Id);
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID", show_Info.Theater_Id);
            ViewBag.Employee_Id = new SelectList(db.Employee_Info, "Employee_Id", "E_ID", show_Info.Employee_Id);
            return View(show_Info);
        }

        // GET: Show_Info/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show_Info show_Info = await db.Show_Info.FindAsync(id);
            if (show_Info == null)
            {
                return HttpNotFound();
            }
            ViewBag.Movie_Id = new SelectList(db.Movie_Info, "Movie_Id", "M_ID", show_Info.Movie_Id);
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID", show_Info.Theater_Id);
            ViewBag.Employee_Id = new SelectList(db.Employee_Info, "Employee_Id", "E_ID", show_Info.Employee_Id);
            return View(show_Info);
        }

        // POST: Show_Info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Show_Id,S_ID,Theater_Id,Movie_Id,Show_Date,Start_Time,Price,Employee_Id")] Show_Info show_Info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(show_Info).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Movie_Id = new SelectList(db.Movie_Info, "Movie_Id", "M_ID", show_Info.Movie_Id);
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID", show_Info.Theater_Id);
            ViewBag.Employee_Id = new SelectList(db.Employee_Info, "Employee_Id", "E_ID", show_Info.Employee_Id);
            return View(show_Info);
        }

        // GET: Show_Info/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show_Info show_Info = await db.Show_Info.FindAsync(id);
            if (show_Info == null)
            {
                return HttpNotFound();
            }
            return View(show_Info);
        }

        // POST: Show_Info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Show_Info show_Info = await db.Show_Info.FindAsync(id);
            db.Show_Info.Remove(show_Info);
            await db.SaveChangesAsync();
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
