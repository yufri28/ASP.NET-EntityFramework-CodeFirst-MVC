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
    public class NilaisController : Controller
    {
        private ProductManagementContext db = new ProductManagementContext();

        // GET: Nilais
        public ActionResult Index()
        {
            var nilais = db.Nilais.Include(n => n.Mahasiswa).Include(n => n.MataKuliah).Include(n => n.Semester);
            return View(nilais.ToList());
        }

        // GET: Nilais/Details/5
        public ActionResult Details(string Nim, string KodeMk, string KodeSemester)
        {
            if ((Nim == null && KodeMk == null) && KodeSemester == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nilai nilai = db.Nilais.Find(Nim, KodeMk, KodeSemester);
            if (nilai == null)
            {
                return HttpNotFound();
            }
            return View(nilai);
        }

        // GET: Nilais/Create
        public ActionResult Create()
        {
            ViewBag.Nim = new SelectList(db.Mahasiswas, "Nim", "Nama");
            ViewBag.KodeMk = new SelectList(db.MataKuliahs, "KodeMk", "NamaMk");
            ViewBag.KodeSemester = new SelectList(db.Semesters, "KodeSemester", "NamaSemester");
            return View();
        }

        // POST: Nilais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nim,KodeSemester,KodeMk,NilaiAngka,NilaiHuruf")] Nilai nilai)
        {
            if (ModelState.IsValid)
            {
                db.Nilais.Add(nilai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Nim = new SelectList(db.Mahasiswas, "Nim", "Nama", nilai.Nim);
            ViewBag.KodeMk = new SelectList(db.MataKuliahs, "KodeMk", "NamaMk", nilai.KodeMk);
            ViewBag.KodeSemester = new SelectList(db.Semesters, "KodeSemester", "NamaSemester", nilai.KodeSemester);
            return View(nilai);
        }

        // GET: Nilais/Edit/5
        public ActionResult Edit(string Nim, string KodeMk, string KodeSemester)
        {
            if ((Nim == null && KodeMk == null) && KodeSemester == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nilai nilai = db.Nilais.Find(Nim,KodeMk,KodeSemester);
            if (nilai == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nim = new SelectList(db.Mahasiswas, "Nim", "Nama", nilai.Nim);
            ViewBag.KodeMk = new SelectList(db.MataKuliahs, "KodeMk", "NamaMk", nilai.KodeMk);
            ViewBag.KodeSemester = new SelectList(db.Semesters, "KodeSemester", "NamaSemester", nilai.KodeSemester);
            return View(nilai);
        }

        // POST: Nilais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nim,KodeSemester,KodeMk,NilaiAngka,NilaiHuruf")] Nilai nilai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nilai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Nim = new SelectList(db.Mahasiswas, "Nim", "Nama", nilai.Nim);
            ViewBag.KodeMk = new SelectList(db.MataKuliahs, "KodeMk", "NamaMk", nilai.KodeMk);
            ViewBag.KodeSemester = new SelectList(db.Semesters, "KodeSemester", "NamaSemester", nilai.KodeSemester);
            return View(nilai);
        }

        // GET: Nilais/Delete/5
        public ActionResult Delete(string Nim, string KodeMk, string KodeSemester)
        {
            if ((Nim == null && KodeMk == null) && KodeSemester == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nilai nilai = db.Nilais.Find(Nim, KodeMk, KodeSemester);
            if (nilai == null)
            {
                return HttpNotFound();
            }
            return View(nilai);
        }

        // POST: Nilais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string Nim, string KodeMk, string KodeSemester)
        {
            Nilai nilai = db.Nilais.Find(Nim, KodeMk, KodeSemester);
            db.Nilais.Remove(nilai);
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
