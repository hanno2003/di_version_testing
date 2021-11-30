using Autofac;
using Microsoft.Extensions.Logging;
using Autofac.Core;
using WebApplication1.Controllers;
using WebApplication1.Services;

namespace WebApplication1
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            // It was then registered with Autofac using the Populate method. All of this starts
            // with the services.AddAutofac() that happens in Program and registers Autofac
            // as the service provider.
            builder.Register(c => new ValuesService(c.Resolve<ILogger<ValuesService>>()))
                .As<IValuesService>()
                .InstancePerLifetimeScope();

            //builder.Register<ITesting>(c => new TestingV1());
            //builder.RegisterType<TestingV1>().Keyed("V1", typeof(ITesting));
            //builder.RegisterType<TestingV2>().Keyed("V2", typeof(ITesting));

            builder.RegisterType<HttpContextVersionService>().As<IVersionService>();
            builder.RegisterVersioned<TestingV1>();
            builder.RegisterVersioned<TestingV2>();
            builder.RegisterVersioned<WeatherForecastController>();
        }
    }
}
