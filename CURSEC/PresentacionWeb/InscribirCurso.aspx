<%@ Page Title="Inscribir Curso" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="InscribirCurso.aspx.cs" Inherits="PresentacionWeb.InscribirCurso" validateRequest="false" enableEventValidation="false" %>
<asp:Content ID="Content6" ContentPlaceHolderID="cphNombre3" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Inscripción Curso!", text: 'Se inscribio exitosamente al curso', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }
        function fallo() {
            swal({
                title: '¡No se pudo inscribir al curso!',
                text: 'Ya se encuentra inscrito en el mismo',
                type: 'error'
            });
            return false;

        }
    </script>
    <div class="form-horizontal contenedor" style="margin-bottom: 80px">
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Inscribir Curso</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="curso"><font color="red" size="4">*</font>Curso:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlCurso" runat="server" style="padding:3px;width:170px"></asp:DropDownList>
                    </div>
                </div>


                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="identificacion"><font color="red" size="4">*</font>Identificación:</label><div class="col-md-4">
                        <asp:TextBox ID="txtIdentificacion" runat="server" class="form-control input-md" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="inscribir"></label>
                    <div class="col-md-4">
                        <asp:Button runat="server"  id="btnInscribirse" class="btn btn-success" Text="Inscribirse" OnClick="btnInscribirse_Click"   />
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
 
</asp:Content>
