<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SilverZone.Web.Accounts.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:Login ID="LogIn" runat="server" OnLoggingIn="LogIn_LoggingIn">
          <LayoutTemplate>
                <fieldset>
                    <legend>Log in Form</legend>
                    <form class="form-horizontal">
                        <div class="control-group">
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName" CssClass="control-label">User name</asp:Label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="UserName" placeholder="Username" CssClass="input-small" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="The user name field is required." />
                                <div />
                            </div>
                            <div class="control-group">
                                <asp:Label ID="Label2" runat="server" AssociatedControlID="Password" CssClass="control-label">Password</asp:Label>
                                <div class="controls">
                                    <asp:TextBox runat="server" ID="Password" TextMode="Password" placeholder="Password" CssClass="input-small" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="The password field is required." />
                                </div>
                            </div>
                            <div class="controls">
                                <asp:Button ID="Button1" runat="server" CommandName="Login" Text="Log in" CssClass="btn btn-success" />
                            </div>
                    </form>
                </fieldset>
            </LayoutTemplate>


    </asp:Login>
   
</asp:Content>

