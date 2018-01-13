using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace adminWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Employee_Info objUser)
        {
            if (ModelState.IsValid)
            {
                using(projectEntities1 context = new projectEntities1())
                {
                    var obj = context.Employee_Info.Where(a=>a.Employee_Name.Equals(objUser.Employee_Name) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.Employee_Id.ToString();
                        Session["UserName"] = obj.Employee_Name.ToString();
                        return RedirectToAction("Dashboard");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult Dashboard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Employee(Employee_Info objUser)
        {
            using (projectEntities1 context = new projectEntities1())
            {
                
                string name = Session["UserName"].ToString();
                if (name == "admin")
                {
                    return RedirectToAction("../Employee_Info/Index");
                }
            }

            return RedirectToAction("Dashboard");
        }

        public ActionResult BookData()
        {
            projectEntities1 context = new projectEntities1();
            var bookingData = (from s in context.Show_Info
                               join b in context.Booking_Details on s.Show_Id equals b.Show_Id
                               join t in context.Theater_Info on s.Theater_Id equals t.Theater_Id
                               join m in context.Movie_Info on s.Movie_Id equals m.Movie_Id
                               where s.Show_Date == DateTime.Today
                               select new
                               {
                                   t.Theater_Id,
                                   t.Theater_Name,
                                   m.Movie_Name,
                                   s.Start_Time,
                                   t.Capacity
                               });
            return View(bookingData.ToList());
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Login");
        }
    }
}