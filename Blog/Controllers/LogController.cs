using Blog.App_Code;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult In()
        {
            return View();
        }

        [HttpPost]
        public ActionResult In(string Username, string Password)
        {

            DcDataContext dc = new DcDataContext();
            if (dc.Admin_Login(Username, Password).Count() > 0)
            {
                Session["Username"] = Username;
                Session["Password"] = Password;
            }
            else
            {
                ViewBag.Message = "Invalid username or password";
                return View();
            }
            return RedirectToAction("Index", "Admin");
        }
        [Secure]
        public ActionResult Out()
        {
            Session["Username"] = null;
            Session["Password"] = null;
            return RedirectToAction("In", "Log");
        }
    }
}