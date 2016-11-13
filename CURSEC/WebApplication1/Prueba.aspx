<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication1.Prueba" %>
<asp:Content ID="contenedor1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblRol" runat="server" Text="Rol:"></asp:Label>
    <asp:DropDownList ID="cmbRol" runat="server"></asp:DropDownList>
     <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
</asp:Content>

