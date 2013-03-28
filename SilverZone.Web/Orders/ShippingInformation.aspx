<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShippingInformation.aspx.cs" Inherits="SilverZone.Web.Orders.ShippingInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
  

    <fieldset>
        <legend>Shipping Information</legend>
        <div class="form-horizontal">
            <div class="control-group">
                <asp:Label runat="server" ID="FirstNameShippingInfo" CssClass="control-label">First Name:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="TextBox1" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="LastNameShippingInfo" CssClass="control-label">Last Name:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="TextBox2" />
                </div>
            </div>
            <div class="control-group">
                <asp:Label runat="server" ID="Address" CssClass="control-label">Address:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="Line1" />
                </div>
                <div class="controls">
                    <asp:TextBox runat="server" ID="Line2" /></div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="City" CssClass="control-label">City:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="TextBox4" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="State" CssClass="control-label">State:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="TextBox5" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="Country" CssClass="control-label">Country:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="TextBox6" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="ZipCode" CssClass="control-label">ZipCode: </asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="TextBox7" />
                </div>
            </div>
        </div>
    </fieldset>

    <br/>
  
    <fieldset>
        <legend>Payment Information</legend>
        <div class="form-horizontal">
            <div class="control-group">
                <asp:Label runat="server" ID="FirstName" CssClass="control-label">First Name:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="Name" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="LastName" CssClass="control-label">Last Name:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="Name2" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="Card" CssClass="control-label">Card Type:</asp:Label>
                <div class="controls">
                    <asp:DropDownList runat="server" ID="CardType" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="CardNumber" CssClass="control-label">Card Number:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="Number" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="Expiration" CssClass="control-label">Expires:</asp:Label>
                <div class="controls">
                    <asp:DropDownList runat="server" ID="Month" />
                </div>
                <div class="controls">
                    <asp:DropDownList runat="server" ID="Year" /></div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="SecurityCode" CssClass="control-label">Security Code:</asp:Label>
                <div class="controls">
                    <asp:TextBox runat="server" ID="Code" />
                </div>
            </div>

            <div class="control-group">
                <asp:Label runat="server" ID="ShippingAddress" CssClass="control-label">Use my shipping address: </asp:Label>
                <div class="controls">
                    <asp:CheckBox runat="server" ID="ShippingAddressConfirm" />
                </div>
            </div>

        </div>
    </fieldset>
    
    <asp:Button runat="server" ID="Continue" CssClass="btn btn-success" Text="Continue"/>

    
</asp:Content>
