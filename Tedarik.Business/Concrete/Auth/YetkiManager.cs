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
    public class YetkiManager : IYetkiService
    {
        private readonly IUnitOfWork _unitOfWork;
        public YetkiManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Result<Yetki> Add(Yetki entity)
        {
            return _unitOfWork.Yetki.Add(entity);

        }

        public Result<Yetki> Delete(string id)
        {

            return _unitOfWork.Yetki.Remove(_unitOfWork.Yetki.GetFirstOrDefault(x => x.Id == Guid.Parse(id)).Data);
        }

        public Result<IEnumerable<Yetki>> deleteAllByKullaniciId(string kullaniciId)
        {
            var yetkiler = _unitOfWork.Yetki.GetAll(x => x.KullaniciId == Guid.Parse(kullaniciId)).Data;

            return _unitOfWork.Yetki.RemoveRange(yetkiler);

        }

        public Result<ICollection<Yetki>> GetAll()
        {
            return _unitOfWork.Yetki.GetAll();
        }

        public Result<ICollection<Yetki>> getAllByKullaniciId(string kullaniciId)
        {

            return _unitOfWork.Yetki.GetAll(x => x.KullaniciId == Guid.Parse(kullaniciId));
        }

        public Result<Yetki> GetById(string id)
        {
            return _unitOfWork.Yetki.GetFirstOrDefault(x => x.Id == Guid.Parse(id));
        }

        public Result<Yetki> Update(Yetki entity)
        {
            var yetki = _unitOfWork.Yetki.GetFirstOrDefault(x => x.Id == entity.Id).Data;

            if (yetki != null)
            {
                yetki = entity;
            }
            return _unitOfWork.Yetki.Update(yetki);

        }
    }
}
