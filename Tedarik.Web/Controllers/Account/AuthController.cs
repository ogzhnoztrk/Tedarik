using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Tedarik.Models.VMs;
using Tedarik.Web.Core.Controllers;
using Tedarik.Web.Helpers;

namespace Tedarik.Web.Controllers.Account
{
    public class AuthController : BaseController
    {
        public IActionResult Login()
        {
            //çerezler içerisinde jwt var mı kontrol et
            if (Request.Cookies["jwt"] != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = (handler.ReadToken(Request.Cookies["jwt"]) as JwtSecurityToken);
                var exp = jsonToken.Claims.First(q => q.Type.Equals("exp")).Value;
                var ticks = long.Parse(exp);
                var tokenDate = DateTimeOffset.FromUnixTimeSeconds(ticks).UtcDateTime;
                var now = DateTime.Now.ToUniversalTime();
                // JWT'yi çözme eğer jwt suresi dolmamış ise direk yonlendir
                if ((tokenDate >= now))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Response.Cookies.Delete("jwt");
                }
            }


            return View();
        }
        [HttpPost]
        public IActionResult Login(KullaniciGirisVm kullaniciGirisVm)
        {
            var loginService = new HttpService<string, KullaniciGirisVm>();
            var result = loginService.PostAsync("Auth/login", kullaniciGirisVm).Result;


            if (result.StatusCode == 400)
            {
                return View();
            }
            if (result.StatusCode == 200)
            {
                Response.Cookies.Append("jwt", result.Data, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = DateTime.UtcNow.AddHours(6)
                });
                return RedirectToAction("Index", "Home");
            }




            return View();
        }

    }
}
//kullanici login oldu
//string olarak bir token geldi --
//tokeni cookie olarak kayıt ettik
//bir base controller yazdık ve tokeni viewbag olarak gömdük
//her isteğimizde viewbag olarak gömdüğümüz tokeni kullanıcağız
//tokeni parçaladık içerisinden string olarak gelen modulnumaralarını aldık
//modul numaraları ("101, 102") olarak geldi
//kullanıcı yetkilendirmesi koymak istediğimiz yerlere if blokları koyup oranın kodunu içeriyor mu kontrol ettirdik