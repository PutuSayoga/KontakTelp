using KontakTelpon.Models;
using KontakTelpon.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontakTelpon.Controllers
{
    public class KontakController : Controller
    {
        private readonly IKontakRepo _repo;

        public KontakController(IKontakRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_repo.GetAllKontak());
        }

        [HttpGet]
        public IActionResult UpSert(int? id)
        {
            if (id != null)
            {
                var kontak = _repo.GetKontakById(id ?? -1);
                if (kontak != null)
                {
                    return View(kontak);
                }
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(Kontak item)
        {
            _repo.UpdateKontak(item);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Create(Kontak item)
        {
            _repo.AddNewKontak(item);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _repo.DeleteKontakById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
