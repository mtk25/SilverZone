<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShippingInformation.aspx.cs" Inherits="SilverZone.Web.Orders.ShippingInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Shipping Information</h1>
      <div class="form-horizontal">
          <asp:Label runat="server" ID="FirstName">First Name: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>

          <asp:Label runat="server" ID="LastName">Last Name: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>

          <asp:Label runat="server" ID="EmailAddress">Email address: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>

          <asp:Label runat="server" ID="Address">Address: </asp:Label>
           <asp:TextBox runat="server" ID="Line1"></asp:TextBox>
           <asp:TextBox runat="server" ID="Line2"></asp:TextBox>
          
          <asp:Label runat="server" ID="City">City: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox4"></asp:TextBox>
          
          <asp:Label runat="server" ID="State">State: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox5"></asp:TextBox>
          
          <asp:Label runat="server" ID="Country">Country: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox6"></asp:TextBox>
           
          <asp:Label runat="server" ID="ZipCode">ZipCode: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox7"></asp:TextBox>

          

      </div>
    
    

    
</asp:Content>
