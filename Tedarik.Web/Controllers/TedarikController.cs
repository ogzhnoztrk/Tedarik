using Microsoft.AspNetCore.Mvc;
using Tedarik.Entities.Concrete;
using Tedarik.Models.VMs.Tedarik;
using Tedarik.Web.Helpers;

namespace Tedarik.Web.Controllers
{
    public class TedarikController : Controller
    {
        public IActionResult Index()
        {
			try
			{
                var service = new HttpService<List<TedarikTableVm>, TedarikTableVm>();
                var tedarikTablo = service.GetAsync("TedarikClass/getTedarikTablolarById").Result;

                return View(tedarikTablo.Data);
            }
			catch (Exception e)
			{

				throw new Exception(e.Message);
			}
			finally
			{
				GC.Collect();
			}
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

		[HttpPost]
		public IActionResult UpsertTedarik(TedarikClass tedarik)
		{
			var tedarikService = new HttpService<TedarikClass, TedarikClass>();

			if (tedarik.Id == Guid.Empty)
			{
				//ekleme işlemi yapılacak

				var postTedarik = tedarikService.PostAsync("TedarikClass", tedarik).Result;
				if (postTedarik.StatusCode == 201)
				{
					return RedirectToAction("Index");
				}
				else
				{
					return BadRequest();
				}
			}
            else
            {
				//guncelleme yapılacak
				var putTedarik = tedarikService.PutAsync("TedarikClass", tedarik).Result;
				if (putTedarik.StatusCode == 200)
				{
					return RedirectToAction("Index");
				}
				else
				{
					return BadRequest();
				}
			}



           
		}

    }
}
