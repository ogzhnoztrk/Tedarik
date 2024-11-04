using Microsoft.AspNetCore.Mvc;
using Tedarik.Entities.Concrete;
using Tedarik.Web.Helpers;

namespace Tedarik.Web.Controllers
{
    public class TedarikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpsertTedarik(string? id)
		{
			if (id != null)
			{
				var tedarikService = new HttpService<TedarikClass, TedarikClass>();
				var tedarikResponse = tedarikService.GetAsync("TedarikClass/GetById?id=" + id).Result;

				if (!(tedarikResponse.Data is null))
				{
					return View(tedarikResponse);
				}
			}

			return View();
        }
    }
}
