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
    public class Employee_InfoController : Controller
    {
        private projectEntities1 db = new projectEntities1();

        // GET: Employee_Info
        public async Task<ActionResult> Index()
        {
            var employee_Info = db.Employee_Info.Include(e => e.Theater_Info);
            return View(await employee_Info.ToListAsync());
        }

        // GET: Employee_Info/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Info employee_Info = await db.Employee_Info.FindAsync(id);
            if (employee_Info == null)
            {
                return HttpNotFound();
            }
            return View(employee_Info);
        }

        // GET: Employee_Info/Create
        public ActionResult Create()
        {
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID");
            return View();
        }

        // POST: Employee_Info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Employee_Id,E_ID,Employee_Name,Theater_Id,Password,Email,Phone_No,Address")] Employee_Info employee_Info)
        {
            if (ModelState.IsValid)
            {
                db.Employee_Info.Add(employee_Info);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID", employee_Info.Theater_Id);
            return View(employee_Info);
        }

        // GET: Employee_Info/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Info employee_Info = await db.Employee_Info.FindAsync(id);
            if (employee_Info == null)
            {
                return HttpNotFound();
            }
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID", employee_Info.Theater_Id);
            return View(employee_Info);
        }

        // POST: Employee_Info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Employee_Id,E_ID,Employee_Name,Theater_Id,Password,Email,Phone_No,Address")] Employee_Info employee_Info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_Info).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Theater_Id = new SelectList(db.Theater_Info, "Theater_Id", "T_ID", employee_Info.Theater_Id);
            return View(employee_Info);
        }

        // GET: Employee_Info/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Info employee_Info = await db.Employee_Info.FindAsync(id);
            if (employee_Info == null)
            {
                return HttpNotFound();
            }
            return View(employee_Info);
        }

        // POST: Employee_Info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Employee_Info employee_Info = await db.Employee_Info.FindAsync(id);
            db.Employee_Info.Remove(employee_Info);
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
