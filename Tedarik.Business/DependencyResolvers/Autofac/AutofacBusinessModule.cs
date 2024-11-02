using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Business.Concrete.Auth;
using Tedarik.DataAccess.Repositories.Persistence;

namespace Tedarik.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerDependency();
            builder.RegisterType<KullaniciManager>().As<IKullaniciService>().InstancePerDependency();
            builder.RegisterType<AuthManager>().As<IAuthService>().InstancePerDependency();
            builder.RegisterType<ModulManager>().As<IModulService>().InstancePerDependency();
            builder.RegisterType<YetkiManager>().As<IYetkiService>().InstancePerDependency();

        }
    }
}
