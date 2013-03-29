<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SilverZone.Web.ShoppingCart.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink runat="server" ID="ShippingInformationLink" NavigateUrl="ShippingInformation.aspx" >Shipping Information</asp:HyperLink>
    
    <div class="page-header">
        <h1>Shopping cart</h1>
    </div>

    <asp:Repeater runat="server" ID="CartItems" OnItemDataBound="CartItems_ItemDataBound">
        <HeaderTemplate>
            <table class="table table-striped table-bordered table-hover">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Quantity</th>
                        <th>Price per 1 item</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Literal runat="server" ID="Product" />
                </td>
                <td>
                    <asp:Literal runat="server" ID="Quantity" />
                </td>
                <td>
                    <asp:Literal runat="server" ID="UnitPrice">
                        {0:c2}
                    </asp:Literal>
                </td>
                <td>
                    <asp:Literal runat="server" ID="Total">
                         {0:c2}
                    </asp:Literal>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
                </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>

   <asp:Button runat="server" ID="CheckOut" Text="Proceed to checkout" CssClass="btn btn-success"/>
</asp:Content>

