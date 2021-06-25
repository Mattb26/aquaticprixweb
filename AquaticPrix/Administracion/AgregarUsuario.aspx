<%@ Page Title="" Language="C#" MasterPageFile="~/MasterJuego.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="AquaticPrix.Administracion.AgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta http-equiv="Cache-Control" content="no-cache" />
    <div class="container-fluid">
        <div class="well well-sm">
            <div class="row">
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Nombre</label>
                        <input type="text" runat="server" id="txtNombre" class="form-control" required="required"
                            placeholder="Nombre" onkeypress="return PasarMayuscula(event,this)" oncut="return false" 
                            oncopy="return false" autocomplete="off" maxlength="100" />
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Apellido</label>
                        <input type="text" runat="server" id="txtApellido" class="form-control" required="required"
                            placeholder="Apellido" onkeypress="return PasarMayuscula(event,this)" oncut="return false" 
                            oncopy="return false" autocomplete="off" maxlength="100" />
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Fecha Nacimiento</label>
                        <input type="date" runat="server" id="txtFechaNacimiento" class="form-control" 
                            min="2018-02-18T24:00:00" max="2090-02-20T01:30:55"
                            placeholder="Fecha y hora salida" name="txtFechaHoraSalida" style="background-color: #F3F2D7" required="required" />
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Correo Electronico</label>
                        <input type="email" runat="server" id="txtCorreoElectronico" class="form-control" style="background-color: #F3F2D7"
                            placeholder="Correo Electronico" oncut="return false" oncopy="return false" autocomplete="off" maxlength="100" />
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Usuario Login</label>
                        <input type="text" runat="server" id="txtLogin" class="form-control"
                            placeholder="Usuario Login" oncut="return false" oncopy="return false" autocomplete="off" maxlength="100" />
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Clave</label>
                        <input type="password" runat="server" id="txtClave" class="form-control" style="background-color: #F3F2D7"
                            placeholder="Clave" oncut="return false" oncopy="return false" autocomplete="off" maxlength="100" />
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="subject">
                            Perfil</label>
                        <asp:DropDownList ID="drpdPerfil" runat="server" CssClass="form-control ComboDropdown" Style="background-color: #F3F2D7" required="required">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <div class="row">
                <br />
            </div>
            <div class="row">
                <div class="col-md-12 text-right">
                    <asp:Button ID="BtnAceptar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClientClick="funcionJS()" OnClick="BtnAceptar_Click" />
<%--                    <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" />--%>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
