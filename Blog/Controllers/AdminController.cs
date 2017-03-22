using Blog.App_Code;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicProduction.Controllers
{
    public class AdminController : Controller
    {
        DcDataContext dc = new DcDataContext();

        [Secure]
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome " + Session["Username"];
            return View();
        }


        public ActionResult Password()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else return View();
        }
        [HttpPost]
        public ActionResult Password(FormCollection collection)
        {
            try
            {
                if (collection["Password"] != collection["confirm"])
                {
                    ViewBag.Message = "Password and it's confirm didn't match";
                }
                else
                {
                    dc.Admin_UpdatePassword(Session["username"].ToString(), collection["prev"], collection["password"]);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ViewBag.Message = "There was a database error";
            }


            if (Request.IsAjaxRequest())
                return PartialView();
            else return View();
        }
        public ActionResult Pic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Pic(FormCollection collection, HttpPostedFileBase parvandeh)
        {
            var _Bytes = new byte[parvandeh.ContentLength];
            parvandeh.InputStream.Read(_Bytes, 0, parvandeh.ContentLength);
            dc.Admin_UpdatePic(Session["Username"].ToString(), _Bytes);
            ViewBag.Message = "Your profile picture updated";
            return View();
        }
    }
}