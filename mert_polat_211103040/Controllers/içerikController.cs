using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mert_polat_211103040.DAL;

namespace mert_polat_211103040.Controllers
{
    public class içerikController : Controller
    {
        private dbmodel db = new dbmodel();

        // GET: içerik
        public ActionResult Index()
        {
            return View(db.içerik.ToList());
        }

        // GET: içerik/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            içerik içerik = db.içerik.Find(id);
            if (içerik == null)
            {
                return HttpNotFound();
            }
            return View(içerik);
        }

        // GET: içerik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: içerik/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "kariyerid,içerik1")] içerik içerik)
        {
            if (ModelState.IsValid)
            {
                db.içerik.Add(içerik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(içerik);
        }

        // GET: içerik/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            içerik içerik = db.içerik.Find(id);
            if (içerik == null)
            {
                return HttpNotFound();
            }
            return View(içerik);
        }

        // POST: içerik/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "kariyerid,içerik1")] içerik içerik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(içerik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(içerik);
        }

        // GET: içerik/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            içerik içerik = db.içerik.Find(id);
            if (içerik == null)
            {
                return HttpNotFound();
            }
            return View(içerik);
        }

        // POST: içerik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            içerik içerik = db.içerik.Find(id);
            db.içerik.Remove(içerik);
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
