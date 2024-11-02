using Microsoft.AspNetCore.Mvc;
using Tedarik.Entities.Concrete.Auth;
using Tedarik.Web.Core.Controllers;
using Tedarik.Web.Helpers;

namespace Tedarik.Web.Controllers.Account
{
    public class ModulController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var list = new List<Modul>();

            var service = new HttpService<List<Modul>, Modul>();
            var modulResponse = service.GetAsync("Modul").Result;

            if (modulResponse.StatusCode == 200)
            {
                return View(modulResponse.Data);
            }



            return View(list);
        }

        public async Task<IActionResult> ModulUpsert(string? id)
        {

            if (id == null)
            {
                return View();
            }
            else
            {
                var list = new Modul();

                var service = new HttpService<Modul, Modul>();
                var modulResponse = service.GetAsync("Modul/getAllByKullaniciId?kullaniciId=" + id).Result;

                if (modulResponse.StatusCode == 200)
                {
                    list = modulResponse.Data;
                }



                return View(list);
            }

        }

        [HttpPost]
        public async Task<IActionResult> ModulUpsert(Modul modul)
        {
            //eğer gelen id 0 ise ekleme yap

            if (modul.Id is null)
            {

                modul.Id = Guid.Empty;
                var service = new HttpService<Modul, Modul>();
                var response = service.PostAsync("Modul", modul).Result;
            }
            else
            {

                var service = new HttpService<Modul, Modul>();
                var a = service.PutAsync("Modul", modul).Result;


            }


            return RedirectToAction("Index");

        }

    }
}