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
    public interface IYetkiService : IBaseService<Yetki>
    {
        Result<ICollection<Yetki>> getAllByKullaniciId(string kullaniciId);
        Result<IEnumerable<Yetki>> deleteAllByKullaniciId(string kullaniciId);

    }
}
