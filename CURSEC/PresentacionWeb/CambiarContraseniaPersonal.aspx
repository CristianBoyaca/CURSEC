<%@ Page Title="Cambiar Contraseña" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="CambiarContraseniaPersonal.aspx.cs" Inherits="PresentacionWeb.CambiarContraseniaPersonal" validateRequest="false" enableEventValidation="false"%>

<asp:Content ID="ContentNombre" ContentPlaceHolderID="cphNombre3" runat="server">
    <asp:Label ID="lblNombre" runat="server" ></asp:Label>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Cambio Contraseña!", text: 'Se realizo el cambio de contraseña exitosamente', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }
        function fallo() {
            swal({
                title: '¡No puedes cambiar la contraseña!',
                text: 'La nueva contraseña debe coincidir con la confirmación de contraseña y no puede estar vacio',
                type: 'error'
            });
            return false;

        }
    </script>
    <div class="form-horizontal contenedor" style="margin-bottom: 80px">
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Cambiar Contraseña</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="nuevaContrasenia"><font color="red" size="4">*</font>Nueva Contrasenia:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNuevaContrasenia" runat="server" class="form-control input-md" type="password" MaxLength="16"></asp:TextBox>
                    </div>
                </div>

               

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="confirmarContrasenia><font color="red" size="4">*</font>Confirmar Contrasenia:</label><div class="col-md-4">
                        <asp:TextBox ID="txtConfirmarContrasenia" runat="server" class="form-control input-md" type="password" MaxLength="16"></asp:TextBox>
                    </div>
                </div>

              

                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="cambiar"></label>
                    <div class="col-md-4">
                       <asp:Button ID="btnCambiarContrasenia" runat="server"   class="btn btn-warning" Text="Cambiar Contraseña" OnClick="btnCambiarContrasenia_Click"/>
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
</asp:Content>
