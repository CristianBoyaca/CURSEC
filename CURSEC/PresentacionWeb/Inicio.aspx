<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PresentacionWeb.Inicio" %>

<asp:Content ID="ContentNombre" runat="server" contentplaceholderid="cphNombre1">
    <asp:Label ID="lblNombre1" runat="server" ></asp:Label>
</asp:Content>
<asp:Content ID="ContentNombre2" runat="server" contentplaceholderid="cphNombre2">
    <asp:Label ID="lblNombre2" runat="server" ></asp:Label>
</asp:Content>
<asp:Content ID="ContentNombre3" runat="server" contentplaceholderid="cphNombre3">
    <asp:Label ID="lblNombre3" runat="server" ></asp:Label>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="container">
<form class="class="form-horizontal">
<div class="jumbotron" style="background-color:white" >
    <h1>Bienvenido al portal de CURSEC</h1>
</div>
</form>
</div>
</asp:Content>



