using Microsoft.AspNetCore.Mvc;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;
using Tedarik.Models.VMs.Kullanici;
using Tedarik.Web.Core.Controllers;
using Tedarik.Web.Helpers;

namespace Tedarik.Web.Controllers.Account
{
    public class KullaniciController : BaseController
    {

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public IActionResult KullaniciModulEkle(string id)
        {
            //moduller gelecek yanlarında tikler olacak ve sayfanın altında kaydet dedğimde kullanıcıya onları kaydedecek
            var modulService = new HttpService<List<Modul>, Modul>();
            var YetkiService = new HttpService<List<Yetki>, Yetki>();
            var moduller = modulService.GetAsync("Modul").Result;
            var yetki = YetkiService.GetAsync("Yetki/getAllByKullaniciId?kullaniciId=" + id).Result;


            var vm = new ModulEkleVM
            {
                KullaniciId = id,
                Moduller = moduller.Data,
                ModulIdListe = null,
                ModulVarMi = moduller.Data is null ? false : true,
                Yetkiler = yetki.Data

            };

            return View(vm);
        }




        [HttpPost]
        public Result<Yetki> KullaniciModulEkle([FromBody] ModulEkleVM modulEkleVm)
        {
            //önce var olan değerleri sil
            var yetkiSilService = new HttpService<ICollection<Modul>, Modul>();
            var silResult = yetkiSilService.DeleteAsync("Yetki/deleteAllByKullaniciId?kullaniciId=" + modulEkleVm.KullaniciId).Result;
            var result = new Result<Yetki>();
            if (silResult.StatusCode == 200)
            {
                var modulEkleService = new HttpService<Yetki, Yetki>();

                foreach (var modulId in modulEkleVm.ModulIdListe)
                {
                    var yetki = new Yetki
                    {
                        KullaniciId = Guid.Parse(modulEkleVm.KullaniciId),
                        ModulId = Guid.Parse(modulId),
                        Id = Guid.Empty,
                       
                    };
                    result = modulEkleService.PostAsync("Yetki", yetki).Result;
                }
            }
            return result;
        }

    }
}
