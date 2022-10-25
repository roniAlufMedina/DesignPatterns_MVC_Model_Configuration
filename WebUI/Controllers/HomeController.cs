using Microsoft.AspNetCore.Mvc;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View(new StokListesi());
        }

        public IActionResult Yeni()
        {
            return View(new YeniÜrün());
        }

        [HttpPost]
        public IActionResult Yeni(YeniÜrün yeni)
        {
            if (ModelState.IsValid)
            {
                yeni.Kaydet();
                return RedirectToAction("Index");
            }
            else
            {
                return View(yeni);
            }

        }    
        public IActionResult HareketEkle()
        {
            return View(new HareketEkle());
        }

        [HttpPost]
        public IActionResult HareketEkle(HareketEkle yeni)
        {
            if (ModelState.IsValid)
            {
                yeni.Kaydet();
                return RedirectToAction("Index");
            }
            else
            {
                return View(yeni);
            }

        }
}

}