<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PresentacionWeb.Inicio" validateRequest="false" enableEventValidation="false" %>

<asp:Content ID="nombre1" ContentPlaceHolderID="cphNombre1" runat="server">
    <asp:Label ID="lblNombre1" runat="server" Text="Label"></asp:Label>
</asp:Content>

<asp:Content ID="nombre2" ContentPlaceHolderID="cphNombre2" runat="server">
    <asp:Label ID="lblNombre2" runat="server" Text="Label"></asp:Label>
</asp:Content>

<asp:Content ID="nombre3" ContentPlaceHolderID="cphNombre3" runat="server">
    <asp:Label ID="lblNombre3" runat="server" Text="Label"></asp:Label>
</asp:Content>

<asp:Content ID="Content8" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
<form class="class="form-horizontal">
<div class="jumbotron" style="background-color:white" >
    <h1>Bienvenido al portal de CURSEC</h1>
</div>
</form>
</div>

</asp:Content>

