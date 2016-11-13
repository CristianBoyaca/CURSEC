<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication1.Usuario" %>

<asp:Content ID="contenido" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenido Usuario</h1>
    <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
      <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="btnCerrarSesion_Click" />
</asp:Content>
