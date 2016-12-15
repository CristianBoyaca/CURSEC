<%@ Page Title="Consultar Inscrición" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ConsultarInscripcion.aspx.cs" Inherits="PresentacionWeb.ConsultarInscripcion" validateRequest="false" enableEventValidation="false" %>

<asp:Content ID="Content6" ContentPlaceHolderID="cphNombre3" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Actualización inscripción curso!", text: 'Se actualizo exitosamente el curso', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }

        function exito1() {
            swal({ type: "success", title: "¡Eliminación inscripción curso!", text: 'Se ha eliminado exitosamente la inscripcion al curso', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }

        function fallo() {
            swal({
                title: '¡No se pudo actalizar la inscripción al curso!',
                text: 'Ya se encuentra inscrito en el mismo',
                type: 'error'
            });
            return false;

        }
        function fallo1() {
            swal({
                title: '¡Error!',
                text: 'Se debe seleccionar una inscripción',
                type: 'error'
            });
            return false;

        }
    </script>
    <div class="form-horizontal contenedor" style="margin-bottom: 80px">
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Consultar Inscripción</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="curso"><font color="red" size="4">*</font>Curso:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlCurso" runat="server" Style="padding: 3px; width: 170px"></asp:DropDownList>
                    </div>
                </div>



                <asp:TextBox ID="txtCodigo" runat="server" class="form-control input-md" Enabled="false" Visible="false"></asp:TextBox>


                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="inscribir"></label>
                    <div class="col-md-4">
                        <asp:Button runat="server" ID="btnActualizar" class="btn btn-warning" Text="Actualizar" OnClick="btnActualizar_Click" />
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger" Style="margin-left: 10px" OnClick="btnEliminar_Click" />
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
    <div style="margin-bottom:100px;margin-left:500px">
        <asp:GridView ID="gvCurso" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnPageIndexChanging="gvCurso_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="gvCurso_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NextPreviousFirstLast" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
</asp:Content>
