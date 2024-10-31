﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.DataAccess.Repositories.Abstracts;

namespace Tedarik.DataAccess.Repositories.Persistence
{
    public interface IUnitOfWork
    {
        public IKullaniciRepository Kullanici{ get; }
        public IModulRepository Modul{ get; }
        public IYetkiRepository Yetki{ get; }
    }
}