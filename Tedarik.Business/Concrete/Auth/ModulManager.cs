using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.DataAccess.Repositories.Persistence;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Business.Concrete.Auth
{
    public class ModulManager : IModulService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModulManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public Result<Modul> Add(Modul entity)
        {
            var isExist = _unitOfWork.Modul.GetFirstOrDefault(x => x.ModulNo == entity.ModulNo).Data;
            if (isExist is null)
            {
                entity.Id = Guid.NewGuid();

                return _unitOfWork.Modul.Add(entity);
            }
            throw new NotImplementedException();
        }

        public Result<Modul> Delete(string id)
        {
            return _unitOfWork.Modul.Remove(_unitOfWork.Modul.GetFirstOrDefault(x => x.Id == Guid.Parse(id)).Data);
        }

        public Result<ICollection<Modul>> GetAll()
        {
            return _unitOfWork.Modul.GetAll();
        }

        public Result<Modul> GetById(string id)
        {
            return _unitOfWork.Modul.GetFirstOrDefault(x => x.Id == Guid.Parse(id));
        }

        public Result<Modul> Update(Modul entity)
        {
            var modul = _unitOfWork.Modul.GetFirstOrDefault(x => x.Id == entity.Id).Data;
            if (modul == null)
            {
                // modul.ModulAdi = entity.ModulAdi;
                throw new NotImplementedException();
            }
            else if (_unitOfWork.Modul.GetAll(x => x.ModulNo == entity.ModulNo).Data.Count > 1)
            {
                throw new NotImplementedException();

            }
            modul.ModulNo = entity.ModulNo;
            modul.ModulAdi = entity.ModulAdi;
            return _unitOfWork.Modul.Update(modul);


            //
        }
    }
}
