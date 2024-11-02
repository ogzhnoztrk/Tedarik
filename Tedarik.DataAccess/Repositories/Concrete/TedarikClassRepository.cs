

using Tedarik.DataAccess.Context;
using Tedarik.DataAccess.Repositories.Abstracts;
using Tedarik.DataAccess.Repositories.BaseRepositories;
using Tedarik.Entities.Concrete;

namespace Tedarik.DataAccess.Repositories.Concrete
{
    public class TedarikClassRepository : SqlRepositoryBase<TedarikClass>, ITedarikClassRepository
    {
        public TedarikClassRepository(SqlDbContext db) : base(db)
        {
        }
    }
}
