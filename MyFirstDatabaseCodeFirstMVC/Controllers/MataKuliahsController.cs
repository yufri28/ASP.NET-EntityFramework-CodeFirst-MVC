using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFirstDatabaseCodeFirstMVC.Context;
using MyFirstDatabaseCodeFirstMVC.Models;

namespace MyFirstDatabaseCodeFirstMVC.Controllers
{
    public class MataKuliahsController : Controller
    {
        private ProductManagementContext db = new ProductManagementContext();

        // GET: MataKuliahs
        public ActionResult Index()
        {
            return View(db.MataKuliahs.ToList());
        }

        // GET: MataKuliahs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MataKuliah mataKuliah = db.MataKuliahs.Find(id);
            if (mataKuliah == null)
            {
                return HttpNotFound();
            }
            return View(mataKuliah);
        }

        // GET: MataKuliahs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MataKuliahs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KodeMk,NamaMk,JumlahSks")] MataKuliah mataKuliah)
        {
            if (ModelState.IsValid)
            {
                db.MataKuliahs.Add(mataKuliah);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mataKuliah);
        }

        // GET: MataKuliahs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MataKuliah mataKuliah = db.MataKuliahs.Find(id);
            if (mataKuliah == null)
            {
                return HttpNotFound();
            }
            return View(mataKuliah);
        }

        // POST: MataKuliahs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KodeMk,NamaMk,JumlahSks")] MataKuliah mataKuliah)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mataKuliah).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mataKuliah);
        }

        // GET: MataKuliahs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MataKuliah mataKuliah = db.MataKuliahs.Find(id);
            if (mataKuliah == null)
            {
                return HttpNotFound();
            }
            return View(mataKuliah);
        }

        // POST: MataKuliahs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MataKuliah mataKuliah = db.MataKuliahs.Find(id);
            db.MataKuliahs.Remove(mataKuliah);
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
