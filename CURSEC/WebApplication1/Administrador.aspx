<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication1.Administrador" %>
<asp:Content ID="contenido" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenido Administrador</h1>
    <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="btnCerrarSesion_Click" />
<asp:Label ID="lblSecretaria" runat="server" Text="Nombre Secretaria:"></asp:Label>
    <asp:TextBox ID="txtNombreSecretaria" runat="server" Label="" server=""></asp:TextBox>
    <asp:Label ID="lblSecretario" runat="server" Text="Secretario:"></asp:Label>
    <asp:DropDownList ID="cmbSecretario" runat="server"></asp:DropDownList>
    <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
</asp:Content>