<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SilverZone.Web.Products.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <h1>Products</h1>

        <asp:DropDownList runat="server" ID="ProductCategories" OnSelectedIndexChanged="ProductCategories_SelectedIndexChanged" AutoPostBack="True"/>
           
        

        <br />

        <asp:Repeater runat="server" ID="Products" OnItemDataBound="Products_ItemDataBound">

            <%-- header--%>
            <HeaderTemplate>
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
                        <%--header end--%>
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
            <%-- footer--%>
            <FooterTemplate>
                </tbody>
    </table>
      <%--footer end--%>
            </FooterTemplate>
        </asp:Repeater>


      </div>

</asp:Content>
