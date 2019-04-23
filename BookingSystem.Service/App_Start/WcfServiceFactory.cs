using BookingSystem.DataAccess;
using BookingSystem.Service.Operations;
using System.Configuration;
using Unity;
using Unity.Injection;
using Unity.Wcf;

namespace BookingSystem.Service
{
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IBookingService, BookingService>();
            container.RegisterType<IBookingSystemRepository, BookingSystemRepository>(new InjectionConstructor(ConfigurationManager.AppSettings["BookingSystemEntities"]));
        }
    }
}