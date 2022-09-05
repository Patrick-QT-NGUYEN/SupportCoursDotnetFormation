using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpListContactAspNetCore_FrontOnly.Interface;
using TpListContactClassAdoNET.Classes;

namespace TpIHMAnnuaireAspNETCore.Controllers
{
    public class ContactController : Controller
    {
        private IWebHostEnvironment _env;

        private IUpload _upload;

        public ContactController(IWebHostEnvironment env, IUpload upload)
        {
            _env = env;
            _upload = upload;
        }

        // GET: ContactController
        public ActionResult Index(string? search)
        {
            List<Contact> contacts = search == null ? Contact.GetAll() : Contact.SearchContact(search);
            return View(contacts);
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            Contact contact = new();
            contact = contact.Get(id).Item2;
            return View(contact);
        }

        // GET: ContactController/Create
        public IActionResult Form(int? id)
        {
            Contact contact = new();
            if (id != null)
            {
                ViewData["title"] = "Update Contact";
                contact = contact.Get((int)id).Item2;
            }
            else
            {
                ViewData["title"] = "Add Contact";
                contact.DateOfBirth = DateTime.Now;
            }
            return View(contact);
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitForm(Contact contact, IFormFile avatar)
        {
            if (contact.Id > 0)
            {
                contact.Update();
            }
            else
            {
                contact.Url = _upload.Upload(avatar);
                contact.Add();
            }
            //on peut faire une redirection vers l'action index
            return RedirectToAction("Index", "Contact");
        }

        public IActionResult ConfirmDelete(int id)
        {
            Contact contact = new();
            contact = contact.Get(id).Item2;
            return View(contact);
        }

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            Contact contact = new();
            contact = contact.Get(id).Item2;
            return View(contact != null ? contact.Delete().Item1 : false);
        }
    }
}
