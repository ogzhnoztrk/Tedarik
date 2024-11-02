using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tedarik.Business.Abstract;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.Entities.Concrete;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class TedarikClassController : ControllerBase
    {
        private readonly ITedarikClassService _service;
        public TedarikClassController(ITedarikClassService service)
        {
            _service = service;
        }

        [HttpPost]
        public Result<TedarikClass> Add(TedarikClass entity)
        {
            return _service.Add(entity);
        }

        [HttpGet]
        public Result<ICollection<TedarikClass>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public Result<TedarikClass> GetById(string id)
        {
            return _service.GetById(id);
        }

     
        [HttpPut]
        public Result<TedarikClass> Update(TedarikClass TedarikClass)
        {
            return _service.Update(TedarikClass);
        }


        [HttpDelete]
        public Result<TedarikClass> Add(string id)
        {
            return _service.Delete(id);
        }
      

    }
}
