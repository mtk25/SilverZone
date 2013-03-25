using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using SilverZone.Domain.Carts;
using SilverZone.Domain.Orders;
using SilverZone.Domain.Products;
using SilverZone.Domain.Users;

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

        public static IUsersContainer Users
        {
            get
            {
                return Container.Resolve<IUsersContainer>();
            }
        }

        public static ICartsContainer Carts
        {
            get
            {
                return Container.Resolve<ICartsContainer>();
            }
        }

        public static IOrdersContainer Orders
        {
            get
            {
                return Container.Resolve<IOrdersContainer>();
            }
        }


        static DomainContext()
        {
            Container = new UnityContainer()
                .LoadConfiguration();
        }
    }
}