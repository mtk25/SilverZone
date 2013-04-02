<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavCart.ascx.cs" Inherits="SilverZone.Web.ShoppingCart.Controls.NavCart" %>

<div class="shopping-cart">
    (<asp:Literal runat="server" ID="ItemCount"/>)
    <a href="/ShoppingCart/">
        <img src="/Pictures/cart.png" /></a>
    <br/>
    <asp:Literal runat="server" ID="Total" EnableViewState="False">{0:c2}</asp:Literal>
    


    
</div>

