using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.DataAccess.Context;
using Tedarik.DataAccess.Repositories.Abstracts;
using Tedarik.DataAccess.Repositories.BaseRepositories;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.DataAccess.Repositories.Concrete
{
    public class YetkiRepository : SqlRepositoryBase<Yetki>, IYetkiRepository
    {
        public YetkiRepository(SqlDbContext db) : base(db)
        {
        }
    }
}
