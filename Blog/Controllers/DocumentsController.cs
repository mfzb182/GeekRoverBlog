using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class DocumentsController : Controller
    {
        DcDataContext dc = new DcDataContext();
        public ActionResult Download(Guid id)
        {
            try {
                File file;
                file = dc.Files.Where(y => y.Id == id).FirstOrDefault();

                if (id == null) return HttpNotFound();

                var _Bytes = new byte[file.Size];
                _Bytes = file.Content.ToArray();

                return File(_Bytes, file.Type, file.Name);
            }
            catch
            {
                return HttpNotFound();
            }
        }
        public ActionResult ProfilePic(string id)
        {
            try
            {
                Admin file;
                file = dc.Admins.Where(y => y.Username == id).FirstOrDefault();

                if (id == null) return HttpNotFound();

                var _Bytes = new byte[file.ProfilePic.Length];
                _Bytes = file.ProfilePic.ToArray();

                return File(_Bytes, "image", id);
            }
            catch
            {
                return HttpNotFound();
            }
        }


        public ActionResult Post(Guid id)
        {
            var post = dc.Posts.Where(x => x.Id == id);
            if (Request.IsAjaxRequest())
                return PartialView("Post", post.Select(m => new Blog.Models.Post { Body = m.Body }).FirstOrDefault());
            else
                return View(post.FirstOrDefault());
        }
        public ActionResult Group(Guid id)
        {
            ViewBag.Title = dc.Groups.Where(m => m.Id == id).FirstOrDefault().Name;

            if (Request.IsAjaxRequest())
                return PartialView();
            return View();
        }
        public ActionResult Author(string id)
        {
            ViewBag.Title = dc.Admins.Where(m => m.Username == id).FirstOrDefault().Fullname;
            if (Request.IsAjaxRequest())
                return PartialView();
            return View();
        }
    }
}
