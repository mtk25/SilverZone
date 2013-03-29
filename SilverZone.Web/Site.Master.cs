using System;
using SilverZone.Web.ShoppingCart.Controls;

namespace SilverZone.Web
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public NavCart NavigationCart
        {
            get { return NavCart; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}