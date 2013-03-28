using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace SilverZone.Web.Orders
{
    public partial class ShippingInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          GetMonths(); 
          GetYear();
        }

        public void GetMonths()
        {
            for (int i = 1; i < 13; i++)
            {
                DateTime month = new DateTime(1900,i,1);
                Month.Items.Add( new ListItem(month.ToString("MMMM"),i.ToString()));
            }
        }

        public void GetYear()
        {
            int count=0;
            const int start = 2013;
            
            for (int i = start; i < 2021; i++)
            {
                DateTime year = new DateTime(i,3,1);
                Year.Items.Add( new ListItem(year.ToString("yyyy"),i.ToString()));
            }

        }




    }
}