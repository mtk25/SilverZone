using System;

namespace SilverZone.Web.Orders
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShippingInformationLink.NavigateUrl += "?id=" + CartId.Text;
        }


    }
}