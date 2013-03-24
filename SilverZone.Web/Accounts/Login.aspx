<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SilverZone.Web.Accounts.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:Login ID="LogIn" runat="server" OnLoggingIn="LogIn_LoggingIn">
          <LayoutTemplate>
                <fieldset>
                    <legend>Log in Form</legend>
                    <ul>
                        <li>
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName">User name</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName"  ErrorMessage="The user name field is required." />
                        </li>
                        <li>
                            <asp:Label ID="Label2" runat="server" AssociatedControlID="Password">Password</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password"  ErrorMessage="The password field is required." />
                        </li>
                    </ul>
                    <asp:Button ID="Button1" runat="server" CommandName="Login" Text="Log in" />
                </fieldset>
            </LayoutTemplate>

    </asp:Login>
   
</asp:Content>

