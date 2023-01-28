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
    public class MuhasebeYonetimController : Controller
    {
        private dbmodel db = new dbmodel();

        // GET: MuhasebeYonetim
        public ActionResult Index()
        {
            return View(db.muhasebe.ToList());
        }

        // GET: MuhasebeYonetim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            muhasebe muhasebe = db.muhasebe.Find(id);
            if (muhasebe == null)
            {
                return HttpNotFound();
            }
            return View(muhasebe);
        }

        // GET: MuhasebeYonetim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MuhasebeYonetim/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "muhasebeid,ad,içerik,iletişim")] muhasebe muhasebe)
        {
            if (ModelState.IsValid)
            {
                db.muhasebe.Add(muhasebe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(muhasebe);
        }

        // GET: MuhasebeYonetim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            muhasebe muhasebe = db.muhasebe.Find(id);
            if (muhasebe == null)
            {
                return HttpNotFound();
            }
            return View(muhasebe);
        }

        // POST: MuhasebeYonetim/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "muhasebeid,ad,içerik,iletişim")] muhasebe muhasebe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(muhasebe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(muhasebe);
        }

        // GET: MuhasebeYonetim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            muhasebe muhasebe = db.muhasebe.Find(id);
            if (muhasebe == null)
            {
                return HttpNotFound();
            }
            return View(muhasebe);
        }

        // POST: MuhasebeYonetim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            muhasebe muhasebe = db.muhasebe.Find(id);
            db.muhasebe.Remove(muhasebe);
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
