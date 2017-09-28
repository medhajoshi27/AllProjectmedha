using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week6.Model;

namespace week6.Modules
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType(typeof(week6Context)).As(typeof(IContext)).InstancePerLifetimeScope();
    }
}