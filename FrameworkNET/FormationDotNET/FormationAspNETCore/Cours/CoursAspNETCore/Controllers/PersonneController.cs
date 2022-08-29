using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoursAspNETCore.Models;

namespace CoursAspNETCore.Controllers
{
    public class PersonneController : Controller
    {
        // GET: PersonneController
        public ActionResult Index()
        {
            ViewData["Title"] = "Personne Index";
            ViewBag.data = new Personne()
            {
                Nom = "Sinclar",
                Prenom = "Bob",
                Email = "bob@gmail.com"
            };
            Personne.Personnes = new();
            Personne p = new()
            {
                Nom = "Di Persio",
                Prenom = "Anthony",
                Email = "anthony@utopios.net",
            };
            Personne.Personnes.Add(p);
            p = new()
            {
                Nom = "Abadi",
                Prenom = "Ihab",
                Email = "ihab@utopios.net",
            };
            Personne.Personnes.Add(p);
            p = new()
            {
                Nom = "Abadi",
                Prenom = "Marine",
                Email = "marine@utopios.net",
            };
            Personne.Personnes.Add(p);
            return View(Personne.Personnes);
        }

        // GET: PersonneController/Details/5
        public ActionResult Details(int id)
        {
            Personne p = new();
            p = Personne.Find(id);
            return View(p);
        }

        // GET: PersonneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
