using System;
using System.Web.UI.WebControls;
using SilverZone.Domain.Products;
using SilverZone.Web.Framework.Contexts;

namespace SilverZone.Web.Products
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Products.DataSource =DomainContext.Products.Repository.Get();
                Products.DataBind();
        }

        protected void Products_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Product product = e.Item.DataItem as Product;

                if (product != null)
                {
                    Literal productName = e.Item.FindControl("ProductName") as Literal;
                    productName.Text = product.Name;

                    Literal price = e.Item.FindControl("Price") as Literal;
                    price.Text = product.Price.ToString();

                    Literal weight = e.Item.FindControl("Weight") as Literal;
                    weight.Text = product.Weight.ToString();

                    Literal inStock = e.Item.FindControl("InStock") as Literal;
                    inStock.Text = product.InStock.ToString();

                }
            }


        }

       
    }
}