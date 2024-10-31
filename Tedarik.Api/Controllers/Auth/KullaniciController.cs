using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _service;
        public KullaniciController(IKullaniciService service)
        {
            _service = service;
        }

        [HttpPost]
        public Result<Kullanici> Add(Kullanici entity)
        {
            return _service.Add(entity);
        }

        [HttpGet]
        public Result<ICollection<Kullanici>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public Result<Kullanici> GetById(string id)
        {
            return _service.GetById(id);
        }

        //[HttpPut]
        //public Result<Kullanici> Update(KullaniciGuncelleDto kullaniciGuncelleDto)
        //{
        //    return _service.UpdateWithDto(kullaniciGuncelleDto);
        //}
        //[HttpPut("AktiflikDegistir")]
        //public Result<Kullanici> AktiflikDegistir(string sicilNo)
        //{
        //    return _service.AktiflikDegistir(sicilNo);
        //}


        [HttpDelete]
        public Result<Kullanici> Add(string id)
        {
            return _service.Delete(id);
        }


    }
}
