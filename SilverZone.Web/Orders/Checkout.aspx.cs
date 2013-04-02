using System;
using System.Web.UI.WebControls;
using SilverZone.Domain.Carts;
using SilverZone.Domain.Common;
using SilverZone.Web.Framework.Contexts;

namespace SilverZone.Web.Orders
{
    public partial class Checkout : System.Web.UI.Page
    {
        private Cart _cart;
        private Cart Cart
        {
            get
            {
                if(_cart == null)
                {
                    _cart = DomainContext.CurrentCart;
                    if (_cart == null)
                    {
                        throw new NullReferenceException("Cart");
                    }
                }
                return _cart;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetMonths();
                GetYear();
            }
            
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            Cart.ShippingInfo = GetShippingInfo();

            Cart.PaymentInfo= GetPaymentInfo();

            Response.Redirect("OrderSummary.aspx");
        }



        private PaymentInfo GetPaymentInfo()
        {
            PaymentInfo paymentInfo = new PaymentInfo();

            paymentInfo.FirstName = FirstName.Text;
            paymentInfo.LastName = LastName.Text;
            paymentInfo.CreditCard.CardType = (CreditCardType)Enum.Parse(typeof(CreditCardType), Card.Text);
            paymentInfo.CreditCard.CardNumber = CardNumber.Text;
            paymentInfo.CreditCard.Month = int.Parse(Month.Text);
            paymentInfo.CreditCard.Year = int.Parse(Year.Text);
            paymentInfo.CreditCard.SecurityCode = SecurityCode.Text;

            return paymentInfo;
        }

        private ShippingInfo GetShippingInfo()
        {
            ShippingInfo shippingInfo = new ShippingInfo();

            shippingInfo.FirstName = FirstNameShippingInfo.Text;
            shippingInfo.LastName = LastNameShippingInfo.Text;
            shippingInfo.Address.AddressLine1 = Address.Text;
            shippingInfo.Address.AddressLine2 = AddressLine2.Text;
            shippingInfo.Address.City = City.Text;
            shippingInfo.Address.State = State.Text;
            shippingInfo.Address.Country = Country.Text;
            shippingInfo.Address.ZipCode = ZipCode.Text;

            return shippingInfo;

        }

        public void GetYear()
        {
            const int start = 2013;

            for (int i = start; i < 2021; i++)
            {
                DateTime year = new DateTime(i, 3, 1);
                Year.Items.Add(new ListItem(year.ToString("yyyy"), i.ToString()));
            }

        }

        public void GetMonths()
        {
            for (int i = 1; i < 13; i++)
            {
                DateTime month = new DateTime(1900, i, 1);
                Month.Items.Add(new ListItem(month.ToString("MM-MMM"), i.ToString()));
            }
        }

    }
}