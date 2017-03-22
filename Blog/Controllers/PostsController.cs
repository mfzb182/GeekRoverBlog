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
    public class PostsController : Controller
    {
        DcDataContext dc = new DcDataContext();
        // GET: Post
        public ActionResult Index(int id = 10)
        {
            return View(dc.Posts.OrderByDescending(m => m.Id).Take(id).ToList());
        }

        // GET: Post/Details/5
        public ActionResult Details(Guid id)
        {
            var Post = dc.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(Post);
            return View(Post);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                dc.Post_Insert(collection["Title"], collection["Abstract"], collection["Body"], Guid.Parse(collection["Group"]), Session["Username"].ToString());
                return RedirectToAction("Index");
            }
            catch
            {
                if (Request.IsAjaxRequest())
                    return PartialView();
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(Guid id)
        {
            var Post = dc.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(Post);
            return View(Post);
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                dc.Post_Update(id, collection["Title"], collection["Abstract"], collection["Body"], Guid.Parse(collection["Group"]));
                return RedirectToAction("Index");
            }
            catch
            {
                var Post = dc.Posts.Where(x => x.Id == id).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(Post);
                return View(Post);
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(Guid id)
        {
            var Post = dc.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (Request.IsAjaxRequest())
                return PartialView(Post);
            return View(Post);
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                dc.Post_Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                var Post = dc.Posts.Where(x => x.Id == id).FirstOrDefault();
                if (Request.IsAjaxRequest())
                    return PartialView(Post);
                return View(Post);
            }
        }
    }
}
