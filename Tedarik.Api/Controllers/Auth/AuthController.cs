using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tedarik.Api.Attributes;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;
using Tedarik.Models.DTOs.Kullanici;

namespace Tedarik.Api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        //[CustomAuthorize("101")]

        public Result<Kullanici> Post(KullaniciKayitDto kullaniciKayitDto)
        {
            return _authService.Register(kullaniciKayitDto);
        }

        [HttpPost("login")]//kullanıcılar ulaşabilir
        public Result<string> login(KullaniciGirisDto kullaniciGirisDto)
        {
            var login = _authService.Login(kullaniciGirisDto);

            if (login.StatusCode == 400)
            {
                return new Result<string>(400, "Giriş Yapılamadı", "Giriş Yapılırken Bir Sorun Oluştu");
            }

            //burada token oluşturulacak ve token döndürülecek

            return _authService.GenerateToken(login.Data);
        }

    }
}
