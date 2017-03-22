using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Blog.App_Code;
using Blog.Models;

namespace Blog.Controllers
{
    [Secure]
    public class FilesController : Controller
    {
        DcDataContext dc = new DcDataContext();
        // GET: Files
        public ActionResult Index()
        {
            var files = dc.Files.Select(m => new Blog.Models.File { Id = m.Id, Name = m.Name, Type = m.Type }).OrderByDescending(m => m.Name).ToList();
            if (Request.IsAjaxRequest())
                return PartialView(files);
            return View(files);
        }

        // GET: Files/Create
        public ActionResult Upload()
        {
            return View();
        }

        // POST: Files/Create
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Upload(string Name, HttpPostedFileBase Parvandeh)
        {
            try
            {
                var _Bytes = new byte[Parvandeh.ContentLength];
                Parvandeh.InputStream.Read(_Bytes, 0, Parvandeh.ContentLength);

                dc.File_Insert(Name, _Bytes, Parvandeh.ContentType, Session["Username"].ToString());
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Upload failure";
                if (Request.IsAjaxRequest())
                    return PartialView();
                return View();
            }
        }

        // GET: Files/Edit/5
        public ActionResult Update(Guid? id)
        {
            var file = dc.Files.Where(x => x.Id == id).Select(m => new Blog.Models.File { Id = m.Id, Name = m.Name, Type = m.Type, Size = m.Size }).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(file);
            return View(file);
        }

        // POST: Files/Edit/5
        [HttpPost]
        public ActionResult Update(Guid? id, string Name, HttpPostedFileBase Parvandeh)
        {
            try
            {
                if (Parvandeh == null)
                {
                    dc.File_Update(id, Name, null);
                }
                else
                {
                    var _Bytes = new byte[Parvandeh.ContentLength];
                    Parvandeh.InputStream.Read(_Bytes, 0, Parvandeh.ContentLength);
                    dc.File_Update(id, Name, _Bytes);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Update failure";
                var file = dc.Files.Where(x => x.Id == id).Select(m => new Blog.Models.File { Id = m.Id, Name = m.Name, Type = m.Type, Size = m.Size }).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(file);
                return View(file);
            }
        }

        // GET: Files/Delete/5
        public ActionResult Drop(Guid? id)
        {
            var file = dc.Files.Where(x => x.Id == id).Select(m => new Blog.Models.File { Id = m.Id, Name = m.Name, Type = m.Type, Size = m.Size }).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(file);
            return View(file);
        }

        // POST: Files/Delete/5
        [HttpPost]
        public ActionResult Drop(Guid? id, FormCollection collection)
        {
            try
            {
                dc.File_Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Delete failure";
                var file = dc.Files.Where(x => x.Id == id).Select(m => new Blog.Models.File { Id = m.Id, Name = m.Name, Type = m.Type, Size = m.Size }).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(file);
                return View(file);
            }
        }
    }
}
