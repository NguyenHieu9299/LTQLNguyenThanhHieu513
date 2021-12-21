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
    public class NhaCungCap513Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: NhaCungCap513
        public ActionResult Index()
        {
            return View(db.NhaCungCaps.ToList());
        }

        // GET: NhaCungCap513/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap513 nhaCungCap513 = db.NhaCungCaps.Find(id);
            if (nhaCungCap513 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap513);
        }

        // GET: NhaCungCap513/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap513/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap513 nhaCungCap513)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCaps.Add(nhaCungCap513);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap513);
        }

        // GET: NhaCungCap513/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap513 nhaCungCap513 = db.NhaCungCaps.Find(id);
            if (nhaCungCap513 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap513);
        }

        // POST: NhaCungCap513/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap513 nhaCungCap513)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap513).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap513);
        }

        // GET: NhaCungCap513/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap513 nhaCungCap513 = db.NhaCungCaps.Find(id);
            if (nhaCungCap513 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap513);
        }

        // POST: NhaCungCap513/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap513 nhaCungCap513 = db.NhaCungCaps.Find(id);
            db.NhaCungCaps.Remove(nhaCungCap513);
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
