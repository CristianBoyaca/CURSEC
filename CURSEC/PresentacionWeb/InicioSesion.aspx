<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="PresentacionWeb.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio Sesión</title>
    <link href="resources/css/bootstrap.min.css" rel="stylesheet" />
    <link href="resources/css/sweetalert.css" rel="stylesheet" />
    <script src="resources/js/bootstrap.min.js"></script>
    <script src="resources/js/sweetalert-dev.js"></script>
    <script src="resources/js/sweetalert.min.js"></script>
</head>
<body>
   
    <script type="text/javascript">
        function validar() {
            swal({
                title: '¡No puedes iniciar sesión!',
                text: 'No puedes dejar campos vacios',
                type: 'error'
            });
            return false;

        }
        function fallo() {
            swal({
                title: '¡No puedes iniciar sesión!',
                text: 'Credenciales incorrectas',
                type: 'error'
            });
            return false;

        }
    </script>

    <form id="form1" runat="server" style="text-align: center; margin-top: 40px">

        <asp:Label ID="lblRol" runat="server" Text="Rol:"></asp:Label>
        <asp:DropDownList ID="ddlRoles" runat="server" Style="margin-left: 77px; width: 176px; padding: 3px" />
        <br />
        <br />
        <asp:Label ID="lblIdentificacion" runat="server" Text="Identificación:"></asp:Label>
        <asp:TextBox ID="txtIdentificacion" runat="server" Style="margin-left: 20px" MaxLength="15" />
        <br />
        <br />
        <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:" />
        <asp:TextBox ID="txtContrasenia" runat="server" Style="margin-left: 26px" type="password" MaxLength="16" />
        <br />
        <br />
        <asp:Button ID="btnIniciar" CssClass="btn btn-primary" runat="server" Text="Iniciar Sesión" OnClick="btnIniciar_Click" />

    </form>
    
</body>
</html>
