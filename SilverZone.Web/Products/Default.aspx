<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SilverZone.Web.Products.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Products</h1>

    <asp:DropDownList runat="server" ID="ProductsDropDown">
        <asp:ListItem>-select-</asp:ListItem>
        <asp:ListItem>Milk</asp:ListItem>

    </asp:DropDownList>
    
    <br/>

    <table class="table table-striped table-bordered table-hover" style="width: 800px">
        <thead>
            <tr>
                <th>Product</th>
                <th>Price</th>
                <th>Weight</th>
                <th>In Stock</th>
                <th>Quantity</th>
                <th>&nbsp;</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox runat="server" ID="Quantity" Width="30px"/>
                </td>
                <td>
                    <asp:Button runat="server" ID="AddToCart" Text="Add to cart"/>
                </td>
                
            </tr>
        </tbody>
        
    </table>
</asp:Content>
