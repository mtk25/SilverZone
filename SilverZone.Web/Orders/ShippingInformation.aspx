<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShippingInformation.aspx.cs" Inherits="SilverZone.Web.Orders.ShippingInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Shipping Information</h1>
      <div class="form-horizontal">
          <asp:Label runat="server" ID="FirstNameShippingInfo">First Name: </asp:Label>
           <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>

          <asp:Label runat="server" ID="LastNameShippingInfo">Last Name: </asp:Label>
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

    <br/>

    <h1>Payment Information</h1>
      <div class="form-horizontal">
          <asp:Label runat="server" ID="FirstName">First Name: </asp:Label>
          <asp:TextBox runat="server" ID="Name"/>

          <asp:Label runat="server" ID="LastName">Last Name: </asp:Label>
          <asp:TextBox runat="server" ID="Name2"/>

          <asp:Label runat="server" ID="Card">Card Type: </asp:Label>
           <asp:DropDownList runat="server" ID="CardType"/>

          <asp:Label runat="server" ID="CardNumber">Card Number: </asp:Label>
          <asp:TextBox runat="server" ID="Number"/>
           
          
          <asp:Label runat="server" ID="Expiration">Expires: </asp:Label>
           <asp:DropDownList runat="server" ID="Month">
             
           </asp:DropDownList>
           <asp:DropDownList runat="server" ID="Year">
               
           </asp:DropDownList>
          
          <asp:Label runat="server" ID="SecurityCode">Security Code: </asp:Label>
          <asp:TextBox runat="server" ID="Code"/>
          
          <asp:Label runat="server" ID="ShippingAddress">Use my shipping address: </asp:Label>
          <asp:CheckBox runat="server" ID="ShippingAddressConfirm"/>
         

          

      </div>
    
    <asp:Button runat="server" ID="Continue"/>

    
</asp:Content>
