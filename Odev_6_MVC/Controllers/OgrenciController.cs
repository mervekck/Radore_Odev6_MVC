using Microsoft.AspNetCore.Mvc;
using Odev_6_MVC.Models;

namespace Odev_6_MVC.Controllers
{
    public class OgrenciController : Controller
    {
        private static List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        public IActionResult Index()
        {
            return View(ogrenciListesi);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                ogrenciListesi.Add(ogrenci);
                TempData["Success"] = "Öğrenci Kaydı Başarılı ile Eklendi";
                return RedirectToAction("Index");
            }
            return View(ogrenci);
        }
    }
}
