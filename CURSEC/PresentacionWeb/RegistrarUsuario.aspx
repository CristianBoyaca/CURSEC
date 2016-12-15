<%@ Page Title="Registrar Usuario" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="PresentacionWeb.RegistrarUsuario" validateRequest="false" enableEventValidation="false" %>

<asp:Content ID="ContentNombre" ContentPlaceHolderID="cphNombre1" runat="server">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>

<asp:Content ID="formulario" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="form-horizontal contenedor" style="margin-bottom: 80px;width:1100px">
         <script type="text/javascript">
        function exito() {
            swal({ type: "success", title: "¡Registro de usuario!", text: 'Se registro exitosamente el usuario', confirmButtonText: "Aceptar", showConfirmButton: true, allowOutsideClick: true, }, function () { window.location.href = "Inicio.aspx"; });
            return false;

        }
        function fallo() {
            swal({
                title: '¡No puedes registrar el usuario!',
                text: 'Debes llenar todos los campos en *',
                type: 'error'
            });
            return false;

        }
        function fallo1() {
            swal({
                title: '¡Usuario ya se encuentra registrado!',
                type: 'error'
            });
            return false;

        }
    </script>
        <form id="form1">
            <fieldset>

                <!-- Form Name -->
                <legend style="text-align: center; margin: 50px">Registrar Usuario</legend>
               
                <!-- Text input-->
                <div class="form-group">
                    <label  for="identificacion" style="margin-left:50px"><font color="red" size="4">*</font>Identificación:</label>
                        <asp:TextBox ID="txtIdentificacion" runat="server" style="margin-left:10px" ></asp:TextBox>
                    <label  for="primerNombre" style="margin-left:10px"><font color="red" size="4">*</font>Primer Nombre:</label>
                        <asp:TextBox ID="txtPrimerNombre" runat="server" style="margin-left:20px"></asp:TextBox>
                    <label  for="segundoNombre" style="margin-left:10px"><font color="red" size="4"></font>Segundo Nombre:</label>
                        <asp:TextBox ID="txtSegundoNombre" runat="server" style="margin-left:10px"></asp:TextBox>
                </div>

                   <!-- Text input-->
                <div class="form-group">
                    <label  for="primerApellido" style="margin-left:50px"><font color="red" size="4">*</font>Primer Apellido:</label>
                        <asp:TextBox ID="txtPrimerApellido" runat="server"></asp:TextBox>
                    <label  for="segundoApellido" style="margin-left:10px"><font color="red" size="4"></font>Segundo Apellido:</label>
                        <asp:TextBox ID="txtSegundoApellido" runat="server" ></asp:TextBox>
                    <label  for="ciudadNacimiento"><font color="red" size="4">*</font>Ciudad De Nacimiento:</label>
                    <asp:DropDownList ID="ddlCiudad" runat="server" style="padding:3px;width:160px"></asp:DropDownList>
                </div>

                  
                <div class="form-group">
                    <label  for="departamento" style="margin-left:50px"><font color="red" size="4">*</font>Departamento:</label>
                    <asp:DropDownList ID="ddlDepartamento" runat="server" style="margin-left:10px;padding:3px;width:170px"></asp:DropDownList>
                    <label  for="sexo" style="margin-left:10px"><font color="red" size="4">*</font>Sexo:</label>
                    <asp:DropDownList ID="ddlSexo" runat="server" style="margin-left:90px;padding:3px;width:180px">
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
                    <label  for="cargo" style="margin-left:10px"><font color="red" size="4">*</font>Cargo:</label>
                    <asp:DropDownList ID="ddlCargo" runat="server" style="margin-left:100px; padding:3px;width:160px"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <label  for="fechaNacimiento" style="margin-left:50px"><font color="red" size="4">*</font>F.Nacimiento:</label>
                    <asp:TextBox ID="txtFechaNacimiento" runat="server" style="width:188px"></asp:TextBox><!--<asp:ImageButton ID="imgCalendario" runat="server" Height="16px" ImageUrl="~/resources/img/calendario.jpg" OnClick="imgCalendario_Click" Width="38px" />
                    <asp:Calendar ID="calFechaNacimiento" runat="server" OnSelectionChanged="calFechaNacimiento_SelectionChanged"></asp:Calendar>-->
                    <label  for="area" style="margin-left:10px"><font color="red" size="4">*</font>Area:</label>
                    <asp:DropDownList ID="ddlArea" runat="server" style="margin-left:96px;padding:3px;width:180px"></asp:DropDownList>
                    <label  for="entidad" style="margin-left:10px"><font color="red" size="4">*</font>Entidad:</label>
                    <asp:DropDownList ID="ddlEntidad" runat="server" style="margin-left:20px; padding:3px;width:230px"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <label  for="rol" style="margin-left:50px"><font color="red" size="4">*</font>Rol:</label>
                    <asp:CheckBox ID="chbUsuario" runat="server" Text="Usuario" style="margin-left:10px" />
                    <asp:CheckBox ID="chbSecretario" runat="server" Text="Secretario" />
                    <asp:CheckBox ID="chbAdministrador" runat="server" Text="Administrador" />
                </div>

                <!-- Button -->
                <div class="form-group">
                    <div class="col-md-4">
                        <asp:Button ID="btnRegistrar" runat="server" class="btn btn-success" Text="Registar" style="margin-left:550px" OnClick="btnRegistrar_Click"/>
                    </div>
                </div>
            </fieldset>
        </form>
    </div>
</asp:Content>
