using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using SilverZone.Domain.Products;

namespace SilverZone.Web.Framework.Contexts
{
    internal static class DomainContext
    {
        public static IUnityContainer Container;

        public static IProductsContainer Products
        {
            get
            {
                return Container.Resolve<IProductsContainer>();
            }
        }

        static DomainContext()
        {
            Container = new UnityContainer()
                .LoadConfiguration();
        }
    }
}