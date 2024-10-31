using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;
using Tedarik.Models.DTOs.Kullanici;

namespace Tedarik.Business.Abstract.Auth
{
    public interface IAuthService
    {
        Result<Kullanici> Register(KullaniciKayitDto userRegisterDto);
        Result<Kullanici> Login(KullaniciGirisDto kullaniciGirisDto);
        Result<string> GenerateToken(Kullanici kullanici);

    }
}
