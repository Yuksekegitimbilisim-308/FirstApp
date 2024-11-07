using FirstApp.Entity;
using FirstApp.Managers;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class PersonelController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Personel> result = PersonelManager.GetAllPersonels();
            return View(result);
        }
        [HttpGet]
        public IActionResult AddPersonel()
        {
            Personel personel = new();
            return View(personel);
        }
        [HttpPost]
        public IActionResult AddPersonel(Personel personel)
        {
            PersonelManager.AddPersonel(personel);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult EditPersonel(int id)
        {
            var personel = PersonelManager.GetPersonelById(id);
            PersonelEditViewModel model = new()
            {
                Personel = personel,
                PageTitle = "Personel Güncelleme Sayfası",
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPersonel(Personel personel)
        {
            PersonelManager.UpdatePersonel(personel);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult DeletePersonel(int id)
        {
            PersonelManager.RemovePersonel(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
