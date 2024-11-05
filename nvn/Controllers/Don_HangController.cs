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
    public class Don_HangController : Controller
    {
        private quanlybanhangEntities db = new quanlybanhangEntities();

        // GET: Don_Hang
        public ActionResult Index()
        {
            var don_Hang = db.Don_Hang.Include(d => d.khach_hang);
            return View(don_Hang.ToList());
        }

        // GET: Don_Hang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_Hang don_Hang = db.Don_Hang.Find(id);
            if (don_Hang == null)
            {
                return HttpNotFound();
            }
            return View(don_Hang);
        }

        // GET: Don_Hang/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.khach_hang, "MaKH", "Ho_ten");
            return View();
        }

        // POST: Don_Hang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDH,MaKH,Ngay_dat,Tong_tien,Trang_thai")] Don_Hang don_Hang)
        {
            if (ModelState.IsValid)
            {
                db.Don_Hang.Add(don_Hang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.khach_hang, "MaKH", "Ho_ten", don_Hang.MaKH);
            return View(don_Hang);
        }

        // GET: Don_Hang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_Hang don_Hang = db.Don_Hang.Find(id);
            if (don_Hang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.khach_hang, "MaKH", "Ho_ten", don_Hang.MaKH);
            return View(don_Hang);
        }

        // POST: Don_Hang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDH,MaKH,Ngay_dat,Tong_tien,Trang_thai")] Don_Hang don_Hang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(don_Hang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.khach_hang, "MaKH", "Ho_ten", don_Hang.MaKH);
            return View(don_Hang);
        }

        // GET: Don_Hang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_Hang don_Hang = db.Don_Hang.Find(id);
            if (don_Hang == null)
            {
                return HttpNotFound();
            }
            return View(don_Hang);
        }

        // POST: Don_Hang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Don_Hang don_Hang = db.Don_Hang.Find(id);
            db.Don_Hang.Remove(don_Hang);
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
