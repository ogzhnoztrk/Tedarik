using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.DataAccess.Context;
using Tedarik.DataAccess.Repositories.Abstracts;
using Tedarik.DataAccess.Repositories.Concrete;

namespace Tedarik.DataAccess.Repositories.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlDbContext _db;
        public UnitOfWork(SqlDbContext db)
        {
            _db = db;
            Kullanici = new KullaniciRepository(_db);
            Modul = new ModulRepository(_db);
            Yetki = new YetkiRepository(_db);
        }
        public IKullaniciRepository Kullanici { get; private set; }
        public IModulRepository Modul{ get; private set; }
        public IYetkiRepository Yetki{ get; private set; }

    }
}
