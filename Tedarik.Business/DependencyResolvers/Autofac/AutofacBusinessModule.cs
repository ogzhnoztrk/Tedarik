﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.DataAccess.Repositories.Persistence;

namespace Tedarik.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerDependency();

        }
    }
}
