using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Models;
using Tedarik.DataAccess.Repositories.Persistence;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Business.Concrete.Auth
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly IUnitOfWork _unitOfWork;
        public KullaniciManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Result<Kullanici> Add(Kullanici entity)
        {
            if (_unitOfWork.Kullanici.GetFirstOrDefault(x => x.KullaniciPosta == entity.KullaniciPosta).Data != null)
            {
                return new Result<Kullanici>((int)HttpStatusCode.UnprocessableEntity, "Kullanıcı Mevcut", null);
            }
            entity.Id = Guid.NewGuid();
            return _unitOfWork.Kullanici.Add(entity);
        }

        public Result<Kullanici> AktiflikDegistir(string id)
        {
            try
            {
                var kullanici = _unitOfWork.Kullanici.GetFirstOrDefault(x => x.Id == Guid.Parse(id)).Data;
                if (kullanici.AktifMi)
                {
                    kullanici.AktifMi = false;
                }
                else
                {
                    kullanici.AktifMi = true;
                }


                return _unitOfWork.Kullanici.Update(kullanici);

            }
            catch (Exception e)
            {

                return new Result<Kullanici>((int)HttpStatusCode.OK, e.Message, null);
            }


        }

        public Result<Kullanici> Delete(string id)
        {
            return _unitOfWork.Kullanici.Remove(_unitOfWork.Kullanici.GetFirstOrDefault(x => x.Id == Guid.Parse(id)).Data);
        }

        public Result<ICollection<Kullanici>> GetAll()
        {
            return _unitOfWork.Kullanici.GetAll();
        }

        public Result<Kullanici> GetById(string id)
        {
            return _unitOfWork.Kullanici.GetFirstOrDefault(x => x.Id == Guid.Parse(id));
        }

        public Result<Kullanici> Update(Kullanici kullanici)
        {

            return _unitOfWork.Kullanici.Update(kullanici);

        }

        //public Result<Kullanici> UpdateWithDto(KullaniciGuncelleDto kullanici)
        //{
        //    var kullaniciDb = _unitOfWork.Kullanici.GetFirstOrDefault(x => x.KullaniciSicilNo == kullanici.KullaniciSicilNo).Data;

        //    if (!(kullaniciDb is null))
        //    {

        //        kullaniciDb.KullaniciAdi = kullanici.KullaniciAdi;
        //        kullaniciDb.KullaniciSoyadi = kullanici.KullaniciSoyadi;
        //        kullaniciDb.KullaniciSicilNo = kullanici.KullaniciSicilNo;
        //        kullaniciDb.KullaniciAdres = kullanici.KullaniciAdres;
        //        kullaniciDb.PersonelMi = kullanici.PersonelMi;
        //        kullaniciDb.KullaniciMi = kullanici.KullaniciMi;

        //        kullaniciDb.KullaniciPosta = kullanici.KullaniciPosta;

        //    }

        //    return _unitOfWork.Kullanici.Update(kullaniciDb);

        //}

    }
}
