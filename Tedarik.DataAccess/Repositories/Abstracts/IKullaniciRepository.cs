﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Core.DataAccess.Repository;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.DataAccess.Repositories.Abstracts
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
    }
}