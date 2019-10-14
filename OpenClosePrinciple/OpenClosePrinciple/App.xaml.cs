using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace OpenClosePrinciple
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();

            var applicationContext = new ApplicationContext() { IsAdmin = true };
            builder.RegisterInstance(applicationContext)
                .AsSelf();

            return builder.Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = BuildContainer();

            MainWindow = container.Resolve<ISettingsWindowWindow>() as Window;

            MainWindow.Show();
        }        
    }
}
