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
using Tedarik.Models.DTOs.Tedarik;

namespace Tedarik.Business.Concrete
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

        public Result<List<TedarikTabloDto>> getTedarikTablolarById()
        {
            try
            {
                var tedarikler = _unitOfWork.TedarikClass.GetAll().Data;
                var tedarikDtos = new List<TedarikTabloDto>();

                foreach (var t in tedarikler)
                {
                    tedarikDtos.Add(new TedarikTabloDto
                    {
                        Id = t.Id,
                        AlimEmriProjeNo = t.AlimEmriProNo,
                        AlimMuhtarasiNo = t.AlimMuhNo,
                        Kategori = t.Kategori,
                        KisimMiktari = t.KisimMiktari,
                        KisimNumarasi = t.KisimNumarasi,
                        Kuvvet = t.Kuvvet,
                        MalzemeAdi = t.MalzemeAdi,
                        OlcuBirimi = t.OlcuBirimi,
                        ProjeYili = t.ProjeYili,
                        Sno = t.SNo,
                        SozlesmeNo = t.SozlesmeNo,
                        TaksitSayisi = t.TaksitSayisi
                    });
                }
                return new Result<List<TedarikTabloDto>>(200, "Veri Geirildi", tedarikDtos);
            }
            catch (Exception e)
            {
                return new Result<List<TedarikTabloDto>>(200, e.Message, null);

              
            }
            finally
            {
                GC.Collect();
            }

           
        }

        public Result<TedarikClass> Update(TedarikClass entity)
        {
            return _unitOfWork.TedarikClass.Update(entity);
        }
    }
}
