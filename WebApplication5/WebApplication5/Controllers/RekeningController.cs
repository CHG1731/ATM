using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class RekeningController : Controller
    {
        private OP3Context db = new OP3Context();

        // GET: Rekening
        public ActionResult Index()
        {
            return View(db.Rekening.ToList());
        }

        // GET: Rekening/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rekening rekening = db.Rekening.Find(id);
            if (rekening == null)
            {
                return HttpNotFound();
            }
            return View(rekening);
        }

        // GET: Rekening/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rekening/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RekeningID,Balans,RekeningType")] Rekening rekening)
        {
            if (ModelState.IsValid)
            {
                db.Rekening.Add(rekening);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rekening);
        }

        // GET: Rekening/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rekening rekening = db.Rekening.Find(id);
            if (rekening == null)
            {
                return HttpNotFound();
            }
            return View(rekening);
        }

        // POST: Rekening/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RekeningID,Balans,RekeningType")] Rekening rekening)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rekening).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rekening);
        }

        // GET: Rekening/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rekening rekening = db.Rekening.Find(id);
            if (rekening == null)
            {
                return HttpNotFound();
            }
            return View(rekening);
        }

        // POST: Rekening/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rekening rekening = db.Rekening.Find(id);
            db.Rekening.Remove(rekening);
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
