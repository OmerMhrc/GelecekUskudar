using GelecekUskudar.Models;
using GelecekUskudar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GelecekUskudar.Controllers
{
    public class MulakatController : Controller
    {
        [HttpGet]
        public IActionResult basvuru()
        {
            return View();
        }
        [HttpPost]
        public IActionResult basvuru(Ogrenci model)
        {
            bool referansMektubu = model.ReferansMektubu;
            bool niyetMektubu = model.NiyetMektubu;

            OgrenciRepository.addOgrenci(model);
            return RedirectToAction("basvuru");
        }

    }
}

/*public IActionResult basvuru(string Name, string Surname, int OgrenimDurumu, int OgrenciNotu, string OgretmenYorumu)
{
    if (Name == null || Surname == null)
    {

        var m = new Ogrenci
        {
            Name = "hkjhalk",
            Surname = "ghvjkh",
            OgrenimDurumu = 1,
            OgrenciNotu = 30,
            OgretmenYorumu = "fgdhjkkhjhgfhgjgjkhk",
        };

        OgrenciRepository.addOgrenci(m);
        return RedirectToAction("basvuru"); ;

    }

    else
    {
        var o = new Ogrenci
        {
            Name = Name,
            Surname = Surname,
            OgrenimDurumu = OgrenimDurumu,
            OgrenciNotu = OgrenciNotu,
            OgretmenYorumu = OgretmenYorumu,

        };
        OgrenciRepository.addOgrenci(o);
        return RedirectToAction("basvuru");
    }*/