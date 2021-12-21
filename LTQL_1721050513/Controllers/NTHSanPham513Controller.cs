using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050513.Models;

namespace LTQL_1721050513.Controllers
{
    public class NTHSanPham513Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: NTHSanPham513
        public ActionResult Index()
        {
            var sanPhams = db.SanPhams.Include(n => n.NhaCungCap);
            return View(sanPhams.ToList());
        }

        // GET: NTHSanPham513/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTHSanPham513 nTHSanPham513 = db.SanPhams.Find(id);
            if (nTHSanPham513 == null)
            {
                return HttpNotFound();
            }
            return View(nTHSanPham513);
        }

        // GET: NTHSanPham513/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: NTHSanPham513/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NTHSanPham513 nTHSanPham513)
        {
            if (ModelState.IsValid)
            {
                db.SanPhams.Add(nTHSanPham513);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap", nTHSanPham513.MaNhaCungCap);
            return View(nTHSanPham513);
        }

        // GET: NTHSanPham513/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTHSanPham513 nTHSanPham513 = db.SanPhams.Find(id);
            if (nTHSanPham513 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap", nTHSanPham513.MaNhaCungCap);
            return View(nTHSanPham513);
        }

        // POST: NTHSanPham513/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NTHSanPham513 nTHSanPham513)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nTHSanPham513).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap", nTHSanPham513.MaNhaCungCap);
            return View(nTHSanPham513);
        }

        // GET: NTHSanPham513/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTHSanPham513 nTHSanPham513 = db.SanPhams.Find(id);
            if (nTHSanPham513 == null)
            {
                return HttpNotFound();
            }
            return View(nTHSanPham513);
        }

        // POST: NTHSanPham513/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NTHSanPham513 nTHSanPham513 = db.SanPhams.Find(id);
            db.SanPhams.Remove(nTHSanPham513);
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
