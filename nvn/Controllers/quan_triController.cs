using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nvn.Models;

namespace nvn.Controllers
{
    public class quan_triController : Controller
    {
        private quanlybanhangEntities db = new quanlybanhangEntities();

        // GET: quan_tri
        public ActionResult Index()
        {
            return View(db.quan_tri.ToList());
        }

        // GET: quan_tri/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            quan_tri quan_tri = db.quan_tri.Find(id);
            if (quan_tri == null)
            {
                return HttpNotFound();
            }
            return View(quan_tri);
        }

        // GET: quan_tri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: quan_tri/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tai_khoan,Mat_khau,Trang_thai")] quan_tri quan_tri)
        {
            if (ModelState.IsValid)
            {
                db.quan_tri.Add(quan_tri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quan_tri);
        }

        // GET: quan_tri/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            quan_tri quan_tri = db.quan_tri.Find(id);
            if (quan_tri == null)
            {
                return HttpNotFound();
            }
            return View(quan_tri);
        }

        // POST: quan_tri/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tai_khoan,Mat_khau,Trang_thai")] quan_tri quan_tri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quan_tri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quan_tri);
        }

        // GET: quan_tri/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            quan_tri quan_tri = db.quan_tri.Find(id);
            if (quan_tri == null)
            {
                return HttpNotFound();
            }
            return View(quan_tri);
        }

        // POST: quan_tri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            quan_tri quan_tri = db.quan_tri.Find(id);
            db.quan_tri.Remove(quan_tri);
            db.SaveChanges();
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
