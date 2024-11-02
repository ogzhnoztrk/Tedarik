using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Entities.Concrete;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.DataAccess.Context
{
    public class SqlDbContext : DbContext
    {

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Modul> Moduller{ get; set; }
        public DbSet<Yetki> Yetkiler{ get; set; }
        public DbSet<TedarikClass> Tedarikler{ get; set; }



    }
}
