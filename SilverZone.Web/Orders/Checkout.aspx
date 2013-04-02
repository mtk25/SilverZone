<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="SilverZone.Web.Orders.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
  

    <div>
        <div style="float: left">
            <fieldset>
                <legend>Shipping Information</legend>
                <div class="form-horizontal">
                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">First Name:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="FirstNameShippingInfo"/>
                            <asp:RequiredFieldValidator ID="FirstNamedValidator" runat="server" ControlToValidate="FirstNameShippingInfo" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">Last Name:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="LastNameShippingInfo" />
                            <asp:RequiredFieldValidator ID="LastNameValidator" runat="server" ControlToValidate="LastNameShippingInfo" ErrorMessage="Required!" />
                        </div>
                    </div>
                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">Address Line 1:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="Address" />
                             <asp:RequiredFieldValidator ID="AddressValidator1" runat="server" ControlToValidate="Address" ErrorMessage="Required!" />
                        </div>
                        <asp:Label runat="server" CssClass="control-label">Address Line 2:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="AddressLine2" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">City:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="City" />
                             <asp:RequiredFieldValidator ID="CityValidator" runat="server" ControlToValidate="City" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">State:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="State" />
                            <asp:RequiredFieldValidator ID="StateValidator" runat="server" ControlToValidate="State" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server"  CssClass="control-label">Country:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="Country" />
                             <asp:RequiredFieldValidator ID="CountryValidator" runat="server" ControlToValidate="Country" ErrorMessage="Required!"/>
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">ZipCode: </asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="ZipCode" />
                            <asp:RequiredFieldValidator ID="ZipCodeValidator" runat="server" ControlToValidate="ZipCode" ErrorMessage="Required!" />
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>

        <br />

        <div style="float: right">
            <fieldset>
                <legend>Payment Information</legend>
                <div class="form-horizontal">
                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">First Name:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="FirstName" />
                            <asp:RequiredFieldValidator ID="FirstNameValidator" runat="server" ControlToValidate="FirstName" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">Last Name:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="LastName" />
                            <asp:RequiredFieldValidator ID="LastNameValidator1" runat="server" ControlToValidate="LastName" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">Card Type:</asp:Label>
                        <div class="controls">
                            <asp:DropDownList runat="server" ID="Card" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">Card Number:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="CardNumber" />
                            <asp:RequiredFieldValidator ID="CardNumberValidator" runat="server" ControlToValidate="CardNumber" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" ID="Expiration" CssClass="control-label">Expires:</asp:Label>
                        <div class="controls">
                            <asp:DropDownList runat="server" ID="Month" CssClass="span1" />
                            <asp:DropDownList runat="server" ID="Year" CssClass="span1" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" CssClass="control-label">Security Code:</asp:Label>
                        <div class="controls">
                            <asp:TextBox runat="server" ID="SecurityCode" />
                             <asp:RequiredFieldValidator ID="SecurityCodeValidator" runat="server" ControlToValidate="SecurityCode" ErrorMessage="Required!" />
                        </div>
                    </div>

                    <div class="control-group">
                        <asp:Label runat="server" ID="ShippingAddress" CssClass="control-label">Use my shipping address: </asp:Label>
                        <div class="controls">
                            <asp:CheckBox runat="server" ID="ShippingAddressConfirm" />
                        </div>
                    </div>
                    <asp:Button runat="server" ID="Button1" CssClass="btn btn-success" Text="Continue" OnClick="Continue_Click" />
                </div>
            </fieldset>
        </div>
    </div>
 
  
    
</asp:Content>
