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
    public class ImagesController : Controller
    {
        DcDataContext dc = new DcDataContext();
        // GET: Groups

        public ActionResult Index()
        {
            ViewBag.Title = "Images";
            var result = dc.Images.Select(m => new Image
            {
                Id=m.Id,
                Admin_Username = m.Admin_Username,
                Alt = m.Alt,
                Description = m.Description,
                Url = m.Url
            }).Where(m => m.Admin_Username == Session["Username"].ToString());
            return View(result.ToList());
        }
        public ActionResult Create()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                dc.Image_Insert(collection["Alt"], collection["Description"], collection["Url"], Session["Username"].ToString());
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error in image creation";
                if (Request.IsAjaxRequest())
                    return PartialView();
                else return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(Guid? id)
        {
            var image = dc.Images.Where(x => x.Id == id).Select(m => new Image
            {
                Id = m.Id,
                Admin_Username = m.Admin_Username,
                Alt = m.Alt,
                Description = m.Description,
                Url = m.Url
            }).FirstOrDefault(); if (Request.IsAjaxRequest())
                return PartialView(image);
            return View(image);
        }

        // POST: Test/Edit/5
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                dc.Image_Update(id, collection["Alt"].ToString(),  collection["Description"], collection["Url"]);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error while updating the image";
                var image = dc.Images.Where(x => x.Id == id).Select(m => new Image
                {
                    Id = m.Id,
                    Admin_Username = m.Admin_Username,
                    Alt = m.Alt,
                    Description = m.Description,
                    Url = m.Url
                }).FirstOrDefault(); if (Request.IsAjaxRequest())
                    return PartialView(image);
                return View(image);
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(Guid id)
        {
            ViewBag.Message = "Are you sure to delete this image?";
            var image = dc.Images.Where(x => x.Id == id).Select(m => new Image
            {
                Id = m.Id,
                Admin_Username = m.Admin_Username,
                Alt = m.Alt,
                Description = m.Description,
                Url = m.Url
            }).FirstOrDefault();

            if (Request.IsAjaxRequest())
                return PartialView(image);
            return View(image);

        }

        // POST: Test/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                dc.Image_Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error in image delete";
                var image = dc.Images.Where(x => x.Id == id).Select(m => new Image
                {
                    Id = m.Id,
                    Admin_Username = m.Admin_Username,
                    Alt = m.Alt,
                    Description = m.Description,
                    Url = m.Url
                }).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(image);
                return View(image);

            }
        }
    }
}