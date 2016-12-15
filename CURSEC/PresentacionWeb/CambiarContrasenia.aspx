<%@ Page Title="Cambiar Contraseña" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="CambiarContrasenia.aspx.cs" Inherits="PresentacionWeb.CambiarContrasenia" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="ContentNombre" ContentPlaceHolderID="cphNombre1" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Cambio de contraseña!", text: 'Se actualizo exitosamente la contraseña', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }
        function fallo() {
            swal({
                title: '¡No se pudo cambiar la contraseña!',
                text: 'Se debe seleccionar un usuario y digitar una contraseña',
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
                    <label class="col-md-4 control-label" for="identificacion"><font color="red" size="4">*</font>Identificacion:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtIdentificacion" runat="server" class="form-control input-md" Enabled="false"></asp:TextBox>
                    </div>
                </div>


                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="contrasenia"><font color="red" size="4">*</font>Contraseña:</label><div class="col-md-4">
                        <asp:TextBox ID="txtContrasenia" runat="server" class="form-control input-md" type="password" MaxLength="16"></asp:TextBox>
                    </div>
                </div>

                <!-- Button -->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="actualizar"></label>
                    <div class="col-md-4">
                        <asp:Button ID="btnCambiarContrasenia" runat="server" class="btn btn-warning" Text="Cambiar Contraseña" OnClick="btnCambiarContrasenia_Click" />
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
    <div style="margin-bottom: 100px;margin-left:500px">
        <asp:GridView ID="gvUsuarios" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnPageIndexChanging="gvUsuarios_PageIndexChanging" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged" PageSize="5">
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
