using System;
using System.Linq;
using System.Web.UI.WebControls;
using SilverZone.Domain.Products;
using SilverZone.Web.Framework.Contexts;

namespace SilverZone.Web.Products
{
    public partial class Default : System.Web.UI.Page
    {
        public int SelectedCategoryId 
        {
            get
            { 
                int id;
                int.TryParse(ProductCategories.Text, out id);
                
                return id;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProductCategories();
                LoadProducts();
                
            }
            
        }

        private void LoadProductCategories()
        {
            var productCategories = DomainContext.Products.Repository.GetCategories();
            ProductCategories.Items.Clear();
            ProductCategories.Items.Add(new ListItem("-select-",string.Empty));
            ProductCategories.Items.AddRange((from pc in productCategories
                                              select new ListItem(pc.Name, pc.Id.ToString())).ToArray());
        }

        private void LoadProducts()
        {
            Products.DataSource = DomainContext.Products.Repository.Get(SelectedCategoryId);
            Products.DataBind();
        }

        protected void Products_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Product product = e.Item.DataItem as Product;

                if (product != null)
                {
                    Literal productName = (Literal)e.Item.FindControl("ProductName");
                    productName.Text = product.Name;

                    Literal price = (Literal)e.Item.FindControl("Price");
                    price.Text = product.Price.ToString();

                    Literal weight = (Literal)e.Item.FindControl("Weight");
                    weight.Text = product.Weight.ToString();

                    Literal inStock = (Literal)e.Item.FindControl("InStock");
                    inStock.Text = product.InStock.ToString();

                }
            }
        }

        protected void ProductCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

       
    }
}