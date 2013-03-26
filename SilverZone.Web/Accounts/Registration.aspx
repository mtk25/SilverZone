<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SilverZone.Web.Accounts.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:TextBox ID="FirstName" placeholder="First Name" runat="server"/> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="FirstName"  ErrorMessage="Required field!" />
    <br/>
    <br/>
    <asp:TextBox ID="Lastname" placeholder="Last Name" runat="server"/> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Lastname"  ErrorMessage="Required field!" />
    <br/>
    <br/> 
    <asp:TextBox ID="Email" placeholder="Email Address" runat="server"/> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Email"  ErrorMessage="Required field!" />
    <br/>
    <br/>
    <asp:TextBox ID="Username" placeholder="User name" runat="server"/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Username"  ErrorMessage="Required field!" />
    <br/>
    <br/>
    <asp:TextBox ID="Password" placeholder="Password" runat="server" TextMode="Password"/> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Password"  ErrorMessage="Required field!" />
    <br/>
    <br/>
    <asp:TextBox ID="PasswordConfirm" placeholder="Confirm Password" runat="server" TextMode="Password"/> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="PasswordConfirm"  ErrorMessage="Required field!" />
    <br/>
    <br/>
    <asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click" CssClass="btn btn-success"/>
    
    
    <asp:Literal runat="server" ID="ErrorMessage"/>

</asp:Content>
