<%@ Page Title="Calificar Curso" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="CalificarCurso.aspx.cs" Inherits="PresentacionWeb.CalificarCurso" validateRequest="false" enableEventValidation="false" %>


<asp:Content ID="Content6" ContentPlaceHolderID="cphNombre3" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Calificar Curso!", text: 'Se califico exitosamente el curso', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }
        function fallo() {
            swal({
                title: '¡Calificar Curso!',
                text: 'No se pudo calificar el curso exitosamente',
                type: 'error'
            });
            return false;

        }
    </script>
    <div class="form-horizontal contenedor" style="margin-bottom: 80px">
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Calificar Curso</legend>

               

                <div class="form-group">
                    <label class="col-md-4 control-label" for="curso"><font color="red" size="4">*</font>Curso:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlCurso" runat="server" class="form-control input-md"></asp:DropDownList>
                    </div>
                </div>

               
                <div class="form-group">
                    <label class="col-md-4 control-label" for="calificacion"><font color="red" size="4">*</font>Calificación:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlCalificacion" runat="server" class="form-control input-md">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Registrar"></label>
                    <div class="col-md-4">
                       <asp:Button ID="btnCalificarCurso" runat="server"   class="btn btn-success" Text="Calificar" OnClick="btnCalificarCurso_Click"/>
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
</asp:Content>
