using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpListContactClassAdoNET.Classes;

namespace TpIHMAnnuaireAspNETCore.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            // Création d'une list de contact vide
            List<Contact> contacts = new();
            // Je rempli ma liste grace à la méthode GetAll qui nous retourne une liste de contact
            contacts = Contact.GetAll();
            // Je retourne la liste à la vue
            return View(contacts);
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            // Création d'un cotact vide
            Contact contact = new();
            //contact.Id = id; 
            contact = contact.Get(id).Item2;
            return View(contact);
        }

        // GET: ContactController/Create
        public ActionResult Create(int? id)
        {
            Contact c = new();
            if (id != null && c.Get((int)id).Item1)
            {
                ViewData["Title"] = "Update Contacts";
                c = c.Get((int)id).Item2;
            }
            else
            {
                ViewData["Title"] = "Add Contacts";
                c.DateOfBirth = DateTime.Now;
            }            
            return View(c);
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact contact)
        {
            try
            {
                if (contact.Id == 0)
                {
                    contact.Id = contact.Add();
                    ViewBag.success = "Contact Ajouté";
                    return View(contact);
                }
                else
                {
                    if (contact.Update())
                    {
                        ViewBag.success = "Contact mis à jour";
                        return View(contact);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.errors = ex.Message;
                return View();
            }
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Title"] = "UpdateContact Contacts";
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            // Création d'un cotact vide
            Contact contact = new();
            //contact.Id = id; 
            contact = contact.Get(id).Item2;
            if (contact.Delete().Item1)
            {
                ViewBag.Success = contact.Delete().Item2 ;
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: ContactController/Delete/5
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
