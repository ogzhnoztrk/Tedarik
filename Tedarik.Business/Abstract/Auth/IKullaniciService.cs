using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Core.Business;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Business.Abstract.Auth
{
    public interface IKullaniciService : IBaseService<Kullanici>
    {
        Result<Kullanici> AktiflikDegistir(string id);
        //Result<Kullanici> UpdateWithDto(KullaniciGuncelleDto kullaniciGuncelleDto);
    }
}
