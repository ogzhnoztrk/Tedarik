using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.DataAccess.Context;
using Tedarik.DataAccess.Repositories.Abstracts.Auth;
using Tedarik.DataAccess.Repositories.BaseRepositories;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.DataAccess.Repositories.Concrete.Auth
{
    public class KullaniciRepository : SqlRepositoryBase<Kullanici>, IKullaniciRepository
    {
        public KullaniciRepository(SqlDbContext db) : base(db)
        {
        }
    }
}
