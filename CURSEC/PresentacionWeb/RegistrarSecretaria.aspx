<%@ Page Title="Registrar Secretaria" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="RegistrarSecretaria.aspx.cs" Inherits="PresentacionWeb.RegistrarSecretaria" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="nombre" ContentPlaceHolderID="cphNombre1" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>


<asp:Content ID="formulario" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Registro de secretaria!", text: 'Se registro exitosamente la secretaria', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }
        function fallo() {
            swal({
                title: '¡No puedes registrar la Secretaria!',
                text: 'No puedes dejar campos vacios',
                type: 'error'
            });
            return false;

        }
    </script>
    <div class="form-horizontal contenedor" style="margin-bottom: 80px">
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Registrar Secretaria</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="nombreScretaria"><font color="red" size="4">*</font>Nombre Secretaria:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombreSecretaria" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-md-4 control-label" for="curso"><font color="red" size="4">*</font>Nombre Secretario:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlSecretario" runat="server" class="form-control input-md"></asp:DropDownList>
                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="direccion"><font color="red" size="4">*</font>Dirección:</label><div class="col-md-4">
                        <asp:TextBox ID="txtDireccion" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="telefono"><font color="red" size="4">*</font>Teléfono:</label><div class="col-md-4">
                        <asp:TextBox ID="txtTelefono" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Registrar"></label>
                    <div class="col-md-4">
                       <asp:Button ID="btnRegistrar" runat="server"   class="btn btn-success" Text="Registar" OnClick="btnRegistrar_Click"/>
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
</asp:Content>
