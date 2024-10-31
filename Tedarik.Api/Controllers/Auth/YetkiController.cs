using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class YetkiController : ControllerBase
    {
        private readonly IYetkiService _service;
        public YetkiController(IYetkiService service)
        {
            _service = service;
        }

        [HttpPost]
        public Result<Yetki> Add(Yetki entity)
        {
            return _service.Add(entity);
        }

        [HttpGet]
        public Result<ICollection<Yetki>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public Result<Yetki> GetById(string id)
        {
            return _service.GetById(id);
        }

        [HttpGet("getAllByKullaniciId")]
        public Result<ICollection<Yetki>> getAllByKullaniciId(string kullaniciId)
        {
            return _service.getAllByKullaniciId(kullaniciId);
        }
        [HttpPut]
        public Result<Yetki> Update(Yetki Yetki)
        {
            return _service.Update(Yetki);
        }


        [HttpDelete]
        public Result<Yetki> Add(string id)
        {
            return _service.Delete(id);
        }
        [HttpDelete("deleteAllByKullaniciId")]
        public Result<IEnumerable<Yetki>> deleteAllByKullaniciId(string kullaniciId)
        {
            return _service.deleteAllByKullaniciId(kullaniciId);

        }

    }
}
