using Microsoft.AspNetCore.Mvc;

namespace Tedarik.Web.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            //burada formlar gosterilecek ve içerisiine girip her bolum kenditarafını dolduracak
            return View();
        }

        public IActionResult Form()
        {
            return RedirectToAction("Index");
        }
        public IActionResult FormUpsert()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult FormUpsert(string biseyler)
        {
            return RedirectToAction("Index");
        }

    }
}
