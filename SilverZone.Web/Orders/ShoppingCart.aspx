<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="SilverZone.Web.Orders.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Label runat="server">
            cart:
        </asp:Label>
        <asp:Literal runat="server" ID="CartId">2</asp:Literal>
    <br/>
    
    <asp:HyperLink runat="server" ID="ShippingInformationLink" NavigateUrl="ShippingInformation.aspx" >Shipping Information</asp:HyperLink>
   
</asp:Content>

