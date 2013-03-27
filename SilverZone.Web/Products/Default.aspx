<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SilverZone.Web.Products.Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="page-header">
     <h1>Products</h1>
    </div>
    <div class="span8">
         <asp:DropDownList runat="server" ID="ProductCategories" OnSelectedIndexChanged="ProductCategories_SelectedIndexChanged" AutoPostBack="True" />
    
    <asp:Repeater runat="server" ID="Products" OnItemDataBound="Products_ItemDataBound">
        <HeaderTemplate>
            <table class="table table-striped table-bordered table-hover">
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
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Literal runat="server" ID="ProductName" />
                </td>
                <td>$<asp:Literal runat="server" ID="Price" />
                </td>
                <td>
                    <asp:Literal runat="server" ID="Weight" />gr
                </td>
                <td>
                    <asp:Literal runat="server" ID="InStock" />
                </td>
                <td>
                    <asp:TextBox runat="server" ID="Quantity" Width="30px" />
                </td>
                <td>
                    <asp:Button runat="server" ID="AddToCart" Text="Add to cart" CssClass="btn btn-success" />
                </td>

            </tr>
        </ItemTemplate>
        <FooterTemplate>
                </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>

    </div>
   
</asp:Content>
