using Emir.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        private IUrunService _urunService;
        public HomeController(IUrunService urunService)
        {
            _urunService = urunService;
        } 
        public ActionResult Index(int kategoryId)
        {

            var urun = _urunService.GetAll();
            UrunVM model = new UrunVM()
            {
                Urunler = urun.ToList(),   
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}