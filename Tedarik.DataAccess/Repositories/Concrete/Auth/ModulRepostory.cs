﻿using System;
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
    public class ModulRepository : SqlRepositoryBase<Modul>, IModulRepository
    {
        public ModulRepository(SqlDbContext db) : base(db)
        {
        }
    }
}
