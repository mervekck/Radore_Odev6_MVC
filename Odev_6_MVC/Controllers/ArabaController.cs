using Microsoft.AspNetCore.Mvc;
using Odev_6_MVC.Models;

namespace Odev_6_MVC.Controllers
{
    public class ArabaController : Controller
    {
        private static List<Araba> arabaListesi = new List<Araba>();
        public IActionResult Index()
        {
            return View(arabaListesi);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Araba araba)
        {
            if (ModelState.IsValid)
            {
                arabaListesi.Add(araba);
                TempData["Success"] = "Araba Kaydı Başarılı ile Eklendi";
                return RedirectToAction("Index");
            }
            return View(araba);
        }
    }
}
