
using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using Caliburn.Metro;
using PolarisPro.ViewModel;
using Caliburn.Metro.Autofac;
using Autofac;

namespace PolarisPro.BootStrapper
{
    //Basic AppBootstrapper

    public class AppBootstrapper : CaliburnMetroAutofacBootstrapper<AppViewModel>

    {
        protected override void ConfigureContainer(ContainerBuilder builder)
        {


            builder.RegisterType<AppWindowManager>().As<IWindowManager>().SingleInstance();

            var assembly = typeof(AppViewModel).Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(item => item.Name.EndsWith("ViewModel") && item.IsAbstract == false)
                .AsSelf()
                .SingleInstance();

        }


    }

}
