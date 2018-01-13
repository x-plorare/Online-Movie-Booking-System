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
    public class Movie_InfoController : Controller
    {
        private projectEntities1 db = new projectEntities1();

        // GET: Movie_Info
        public async Task<ActionResult> Index()
        {
            return View(await db.Movie_Info.ToListAsync());
        }

        // GET: Movie_Info/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie_Info movie_Info = await db.Movie_Info.FindAsync(id);
            if (movie_Info == null)
            {
                return HttpNotFound();
            }
            return View(movie_Info);
        }

        // GET: Movie_Info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie_Info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Movie_Id,M_ID,Movie_Name,Movie_Description,Movie_Rating")] Movie_Info movie_Info)
        {
            if (ModelState.IsValid)
            {
                db.Movie_Info.Add(movie_Info);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(movie_Info);
        }

        // GET: Movie_Info/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie_Info movie_Info = await db.Movie_Info.FindAsync(id);
            if (movie_Info == null)
            {
                return HttpNotFound();
            }
            return View(movie_Info);
        }

        // POST: Movie_Info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Movie_Id,M_ID,Movie_Name,Movie_Description,Movie_Rating")] Movie_Info movie_Info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie_Info).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(movie_Info);
        }

        // GET: Movie_Info/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie_Info movie_Info = await db.Movie_Info.FindAsync(id);
            if (movie_Info == null)
            {
                return HttpNotFound();
            }
            return View(movie_Info);
        }

        // POST: Movie_Info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Movie_Info movie_Info = await db.Movie_Info.FindAsync(id);
            db.Movie_Info.Remove(movie_Info);
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
