using System.Web.Mvc;
using LandingPage.Models;

namespace LandingPage.Controllers
{
    public class CotizacionController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new CotizacionViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CotizacionViewModel model)
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