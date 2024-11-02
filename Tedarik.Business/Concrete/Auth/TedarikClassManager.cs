using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Business.Abstract;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.DataAccess.Repositories.Persistence;
using Tedarik.Entities.Concrete;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Business.Concrete.Auth
{
    public class TedarikClassManager : ITedarikClassService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TedarikClassManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public Result<TedarikClass> Add(TedarikClass entity)
        {
         
                
            entity.Id = Guid.NewGuid(); 
                return _unitOfWork.TedarikClass.Add(entity);
          
        }

        public Result<TedarikClass> Delete(string id)
        {
            return _unitOfWork.TedarikClass.Remove(_unitOfWork.TedarikClass.GetFirstOrDefault(x => x.Id == Guid.Parse(id)).Data);
        }

        public Result<ICollection<TedarikClass>> GetAll()
        {
            return _unitOfWork.TedarikClass.GetAll();
        }

        public Result<TedarikClass> GetById(string id)
        {
            return _unitOfWork.TedarikClass.GetFirstOrDefault(x => x.Id == Guid.Parse(id));
        }

        public Result<TedarikClass> Update(TedarikClass entity)
        {
           return _unitOfWork.TedarikClass.Update(entity);
        }
    }
}
