using System;
using System.Linq;
using SilverZone.Domain.Carts;
using SilverZone.Web.Framework.Contexts;

namespace SilverZone.Web.ShoppingCart.Controls
{
    public partial class NavCart : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayCart();
            }
            
        }

        public void DisplayCart()
        {
           Cart cart = DomainContext.CurrentCart;


            ItemCount.Text = cart.Items.Sum(x => x.Quantity).ToString();

            Total.Text = string.Format(Total.Text, cart.Total);
        }
    }
}