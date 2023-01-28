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
	public class AvukatYonetimController : Controller
	{
		private dbmodel db = new dbmodel();

		// GET: AvukatYonetim
		public ActionResult Index()
		{
			return View(db.avukatlar.ToList());
		}

		// GET: AvukatYonetim/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			avukatlar anasayfa = db.avukatlar.Find(id);
			if (anasayfa == null)
			{
				return HttpNotFound();
			}
			return View(anasayfa);
		}

		// GET: AvukatYonetim/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: AvukatYonetim/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "avukatid,içerik,isim")] avukatlar anasayfa)
		{
			if (ModelState.IsValid)
			{
				db.avukatlar.Add(anasayfa);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(anasayfa);
		}

		// GET: AvukatYonetim/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			avukatlar anasayfa = db.avukatlar.Find(id);
			if (anasayfa == null)
			{
				return HttpNotFound();
			}
			return View(anasayfa);
		}

		// POST:	AvukatYonetim/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "avukatid,içerik,isim")] avukatlar anasayfa)
		{
			if (ModelState.IsValid)
			{
				db.Entry(anasayfa).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(anasayfa);
		}

		// GET: AvukatYonetim/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			avukatlar anasayfa = db.avukatlar.Find(id);
			if (anasayfa == null)
			{
				return HttpNotFound();
			}
			return View(anasayfa);
		}

		// POST: AnasayfaYonetim/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			avukatlar anasayfa = db.avukatlar.Find(id);
			db.avukatlar.Remove(anasayfa);
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