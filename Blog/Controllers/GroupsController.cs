using Blog.App_Code;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicProduction.Controllers
{
    [Secure]
    public class GroupsController : Controller
    {
        DcDataContext dc = new DcDataContext();
        // GET: Groups

        public ActionResult Index()
        {
            ViewBag.Title = "Groups";
            return View(dc.Groups.ToList());
        }
        public ActionResult Create()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                dc.Group_Insert(collection["Name"]);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error in group creation";
                if (Request.IsAjaxRequest())
                    return PartialView();
                else return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(Guid? id)
        {
            var group = dc.Groups.Where(x => x.Id == id).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(group);
            return View(group);
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                dc.Group_Update(id, collection["Name"].ToString());
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error while updating the group";
                var group = dc.Groups.Where(x => x.Id == id).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(group);
                return View(group);
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(Guid id)
        {
            ViewBag.Message = "Are you sure to delete this group?";
            var group = dc.Groups.Where(x => x.Id == id).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(group);
            return View(group);

        }

        // POST: Test/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                dc.Group_Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error in group delete";
                var group = dc.Groups.Where(x => x.Id == id).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(group);
                return View(group);

            }
        }
    }
}