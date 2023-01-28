using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mert_polat_211103040.DAL;

namespace mert_polat_211103040.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Anasayfa()
        {

			//IndexModel m = new IndexModel();
			//m.avukatlars;
			//m.çalışmaAlanlaris;
			//m.hakkimizdas;
			//m.içeriks;
			//m.iletişims;
			//m.muhasebes;
			//m.sabits;
			
			return View();
			
        }

        //public class IndexModel
        //{

        //    public List<avukatlar> avukatlars { get; set; }
        //    public List<çalışmaAlanlari> çalışmaAlanlaris { get; set; }
        //    public List<hakkimizda> hakkimizdas { get; set; }   
        //    public List<içerik> içeriks { get; set; }   
        //    public List<iletişim> iletişims { get; set; }
        //    public List<muhasebe> muhasebes { get; set; }
        //    public List<sabit>  sabits { get; set; }

        //}

        
    }
}