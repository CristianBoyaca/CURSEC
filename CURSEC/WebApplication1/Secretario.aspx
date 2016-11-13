<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Secretario.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication1.Secretario" %>
<asp:Content ID="contenido" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenido Secretario</h1>
    <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
      <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="btnCerrarSesion_Click" />
    
</asp:Content>
