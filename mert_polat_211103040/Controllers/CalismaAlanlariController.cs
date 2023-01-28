using mert_polat_211103040.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace mert_polat_211103040.Controllers
{
    public class CalismaAlanlariController : Controller
    {
		// GET: CalismaAlanlari
		private dbmodel db = new dbmodel();

		// GET: CalismaAlanlariYonetim
		public ActionResult Index()
		{
			return View(db.çalışmaAlanlari.ToList());
		}

		// GET: CalismaAlanlariYonetim/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			çalışmaAlanlari iletisim = db.çalışmaAlanlari.Find(id);
			if (iletisim == null)
			{
				return HttpNotFound();
			}
			return View(iletisim);
		}

		// GET: CalismaAlanlariYonetim/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: CalismaAlanlariYonetim/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "calismaid,baslik,içerik")] çalışmaAlanlari çalışmaAlanlari)
		{
			if (ModelState.IsValid)
			{
				db.çalışmaAlanlari.Add(çalışmaAlanlari);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(çalışmaAlanlari);
		}

		// GET: CalismaAlanlariYonetim/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}	
			çalışmaAlanlari çalışmaAlanlari = db.çalışmaAlanlari.Find(id);
			if (çalışmaAlanlari == null)
			{
				return HttpNotFound();
			}
			return View(çalışmaAlanlari);
		}

		// POST: CalismaAlanlariYonetim/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "calismaid,baslik,içerik")] çalışmaAlanlari çalışmaAlanlari)
		{
			if (ModelState.IsValid)
			{
				db.Entry(çalışmaAlanlari).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(çalışmaAlanlari);
		}

		// GET: CalismaAlanlariYonetim/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			çalışmaAlanlari çalışmaAlanlari = db.çalışmaAlanlari.Find(id);
			if (çalışmaAlanlari == null)
			{
				return HttpNotFound();
			}
			return View(çalışmaAlanlari);
		}

		// POST: CalismaYonetim/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			iletişim iletisim = db.iletişim.Find(id);
			db.iletişim.Remove(iletisim);
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
