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
    public class iletişimYonetimController : Controller
    {
        private dbmodel db = new dbmodel();

        // GET: iletişimYonetim
        public ActionResult Index()
        {
            return View(db.iletişim.ToList());
        }

        // GET: iletişimYonetim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            iletişim iletişim = db.iletişim.Find(id);
            if (iletişim == null)
            {
                return HttpNotFound();
            }
            return View(iletişim);
        }

        // GET: iletişimYonetim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: iletişimYonetim/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iletişimid,adres,mail,telefon,fax,mobil")] iletişim iletişim)
        {
            if (ModelState.IsValid)
            {
                db.iletişim.Add(iletişim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iletişim);
        }

        // GET: iletişimYonetim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            iletişim iletişim = db.iletişim.Find(id);
            if (iletişim == null)
            {
                return HttpNotFound();
            }
            return View(iletişim);
        }

        // POST: iletişimYonetim/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iletişimid,adres,mail,telefon,fax,mobil")] iletişim iletişim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iletişim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iletişim);
        }

        // GET: iletişimYonetim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            iletişim iletişim = db.iletişim.Find(id);
            if (iletişim == null)
            {
                return HttpNotFound();
            }
            return View(iletişim);
        }

        // POST: iletişimYonetim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            iletişim iletişim = db.iletişim.Find(id);
            db.iletişim.Remove(iletişim);
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
