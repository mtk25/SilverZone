using System;
using System.Web.UI.WebControls;
using SilverZone.Domain.Carts;
using SilverZone.Web.Framework.Contexts;


namespace SilverZone.Web.Orders
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        private Cart _cart;
        public Cart Cart
        {
            get
            {
                if (_cart == null)
                {
                    _cart =  DomainContext.CurrentCart;
                }
                return _cart; 
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
            
        }

        private void LoadCart()
        {
            CartItems.DataSource = Cart.Items;
            CartItems.DataBind();
        }



        protected void CartItems_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                CartItem item = e.Item.DataItem as CartItem;

                if (item != null)
                {
                    Literal product =(Literal)e.Item.FindControl("Product");
                    product.Text = item.ProductId.ToString();

                    Literal quantity = (Literal)e.Item.FindControl("Quantity");
                    quantity.Text = item.Quantity.ToString();

                    Literal unitPrice = (Literal)e.Item.FindControl("UnitPrice");
                    unitPrice.Text = string.Format(unitPrice.Text, 2);

                    Literal total = (Literal)e.Item.FindControl("Total");
                    total.Text = string.Format(total.Text, 3);
                }


            }


        }


    }
}