<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SilverZone.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.js"></script>
    <script src="/galleria/galleria-1.2.9.min.js"></script>
    
    <style>
    #galleria{ width: 700px; height: 400px; background: #000 }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 

   
        <div id="galleria">
            <img src="Pictures/Home/cheese.jpg" />
            <img src="Pictures/Home/chocolate.jpg" />
            <img src="Pictures/Home/green_tea.jpg"/>
            <img src="Pictures/Home/wine_and_cheese.jpg"/>
        </div>

    <script>
        Galleria.loadTheme('galleria/themes/classic/galleria.classic.min.js');
        Galleria.run('#galleria');
    </script>

</asp:Content>
