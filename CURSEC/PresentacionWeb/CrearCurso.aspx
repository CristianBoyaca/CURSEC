<%@ Page Title="Crear Curso" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="CrearCurso.aspx.cs" Inherits="PresentacionWeb.CrearCurso" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphNombre2" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Registro de curso!", text: 'Se registro exitosamente el curso', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
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
                <legend style="text-align: center; margin: 50px">Crear Curso</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="entidad"><font color="red" size="4">*</font>Entidad:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlEntidad" runat="server" class="form-control input-md"></asp:DropDownList> 
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-md-4 control-label" for="descripcion"><font color="red" size="4">*</font>Descripcion:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtDescripcion" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="valor"><font color="red" size="4">*</font>Valo
                        *Ñlk:</label><div class="col-md-4">
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
                       <asp:Button ID="btnRegistrar" runat="server"   class="btn btn-success" Text="Registar" />
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
    <script type="text/javascript">
        var input = $('#ContentPlaceHolder1_txtHoraInicio').clockpicker({
            placement: 'bottom',
            align: 'left',
            autoclose: true,
            'default': 'now'
        });
    </script>
</asp:Content>
