using System;
using SilverZone.Domain.Impl.Products;

namespace SilverZone.Web.Products
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            new ProductRepository().Get();
        }
    }
}