using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Core.Business;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete;
using Tedarik.Entities.Concrete.Auth;
using Tedarik.Models.DTOs.Tedarik;

namespace Tedarik.Business.Abstract
{
    public interface ITedarikClassService : IBaseService<TedarikClass>
    {
        Result<List<TedarikTabloDto>> getTedarikTablolarById();
    }
}
