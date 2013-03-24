using System;
using SilverZone.Web.Framework.Contexts;

namespace SilverZone.Web.Products
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DomainContext.Products.Repository.Get();
        }
    }
}