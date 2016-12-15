<%@ Page Title="Consultar Usuario" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="PresentacionWeb.ConsultarUsuario" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="ContentNombre" ContentPlaceHolderID="cphNombre1" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-horizontal contenedor" style="margin-bottom: 80px; width: 1100px">
        <script type="text/javascript">
            function exito() {
                swal({ type: "success", title: "¡Actualizar usuario!", text: 'Se actualizo exitosamente el usuario', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
                return false;

            }
            function fallo() {
                swal({
                    title: '¡No puedes actualizar el usuario!',
                    text: 'Debes seleccionar un usuario y debes llenar los campos en *',
                    type: 'error'
                });
                return false;

            }

        </script>
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Consultar Usuario</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label for="identificacion" style="margin-left: 50px"><font color="red" size="4">*</font>Identificación:</label>
                    <asp:TextBox ID="txtIdentificacion" runat="server" Style="margin-left: 10px"  Enabled="False"></asp:TextBox>
                    <label for="primerNombre" style="margin-left: 10px"><font color="red" size="4">*</font>Primer Nombre:</label>
                    <asp:TextBox ID="txtPrimerNombre" runat="server" Style="margin-left: 20px"></asp:TextBox>
                    <label for="segundoNombre" style="margin-left: 10px"><font color="red" size="4"></font>Segundo Nombre:</label>
                    <asp:TextBox ID="txtSegundoNombre" runat="server" Style="margin-left: 10px"></asp:TextBox>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label for="primerApellido" style="margin-left: 50px"><font color="red" size="4">*</font>Primer Apellido:</label>
                    <asp:TextBox ID="txtPrimerApellido" runat="server"></asp:TextBox>
                    <label for="segundoApellido" style="margin-left: 10px"><font color="red" size="4"></font>Segundo Apellido:</label>
                    <asp:TextBox ID="txtSegundoApellido" runat="server"></asp:TextBox>
                    <label for="ciudadNacimiento"><font color="red" size="4">*</font>Ciudad De Nacimiento:</label>
                    <asp:DropDownList ID="ddlCiudad" runat="server" Style="padding: 3px; width: 160px"></asp:DropDownList>
                </div>


                <div class="form-group">
                    <label for="departamento" style="margin-left: 50px"><font color="red" size="4">*</font>Departamento:</label>
                    <asp:DropDownList ID="ddlDepartamento" runat="server" Style="margin-left: 10px; padding: 3px; width: 170px"></asp:DropDownList>
                    <label for="sexo" style="margin-left: 10px"><font color="red" size="4">*</font>Sexo:</label>
                    <asp:DropDownList ID="ddlSexo" runat="server" Style="margin-left: 90px; padding: 3px; width: 180px">
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
                    <label for="cargo" style="margin-left: 10px"><font color="red" size="4">*</font>Cargo:</label>
                    <asp:DropDownList ID="ddlCargo" runat="server" Style="margin-left: 100px; padding: 3px; width: 160px"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="fechaNacimiento" style="margin-left: 50px"><font color="red" size="4">*</font>F.Nacimiento:</label>
                    <asp:TextBox ID="txtFechaNacimiento" runat="server" Style="width: 188px"></asp:TextBox>
                    <label for="area" style="margin-left: 10px"><font color="red" size="4">*</font>Area:</label>
                    <asp:DropDownList ID="ddlArea" runat="server" Style="margin-left: 96px; padding: 3px; width: 180px"></asp:DropDownList>
                    <label for="entidad" style="margin-left: 10px"><font color="red" size="4">*</font>Entidad:</label>
                    <asp:DropDownList ID="ddlEntidad" runat="server" Style="margin-left: 20px; padding: 3px; width: 230px"></asp:DropDownList>
                </div>

                <div class="form-group">
                    &nbsp;
                </div>

                <!-- Button -->
                <div class="form-group">
                    <div class="col-md-4">
                        <asp:Button ID="btnActualizar" runat="server" class="btn btn-warning" Text="Actualizar" Style="margin-left: 550px" OnClick="btnActualizar_Click" />
                    </div>
                </div>
            </fieldset>

        </form>
    </div>
    <div style="margin-bottom: 100px">
        <asp:GridView ID="gvUsuarios" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged" PageSize="5" OnPageIndexChanging="gvUsuarios_PageIndexChanging">
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
