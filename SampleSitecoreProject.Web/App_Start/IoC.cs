using Castle.MicroKernel.Registration;
using Castle.Windsor;

using sample = Website;

namespace SampleSitecoreProject.Web.App_Start.SitecoreMvcContrib
{
    public class IoC
    {
        public static void Configure(WindsorContainer container)
        {
            // Add your registration code here...

            // container.Register(
            //              Component.For<sample.Interfaces.IFooService>().ImplementedBy<sample.Services.ConcreteFooService>().LifestyleTransient()
            //              );
        }
    }
}