using System.Web.Mvc;
using LandingPage.Models;

namespace LandingPage.Controllers
{
    public class ContactoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new ContactoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Enviado = true;

            return View(model);
        }
    }
}