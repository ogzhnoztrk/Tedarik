using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulController : ControllerBase
    {
        private readonly IModulService _service;
        public ModulController(IModulService service)
        {
            _service = service;
        }
        [HttpPost]
        public Result<Modul> Add(Modul entity)
        {
            return _service.Add(entity);
        }

        [HttpGet]
        public Result<ICollection<Modul>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public Result<Modul> GetById(string id)
        {
            return _service.GetById(id);
        }

        [HttpPut]
        public Result<Modul> Update(Modul modul)
        {

            return _service.Update(modul);
        }


        [HttpDelete]
        public Result<Modul> Add(string id)
        {
            return _service.Delete(id);
        }


    }
}
