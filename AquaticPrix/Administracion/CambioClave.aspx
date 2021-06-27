<%@ Page Title="" Language="C#" MasterPageFile="~/MasterJuego.Master" AutoEventWireup="true" CodeBehind="CambioClave.aspx.cs" Inherits="AquaticPrix.Administracion.CambioClave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="well well-sm">
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="subject">
                            Usuario</label>
                        <input type="text" runat="server" id="txtUsuario" class="form-control" required="required"
                            placeholder="Usuario" readonly="true" oncut="return false" oncopy="return false"
                            autocomplete="off" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="subject">
                            Clave Actual</label>
                        <input type="password" runat="server" id="txtClaveAnterior" class="form-control"
                            required="required" placeholder="Clave Anterior" oncut="return false" oncopy="return false"
                            autocomplete="off" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="subject">
                            Confirmar Nueva</label>
                        <input type="password" runat="server" id="txtNuevaClave" class="form-control" required="required"
                            placeholder="Confirmar Nueva" oncut="return false" oncopy="return false" autocomplete="off" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="subject">
                            Confirmar Nueva Clave</label>
                        <input type="password" runat="server" id="txtConfirmarClave" class="form-control"
                            required="required" placeholder="Confirmar Nueva Clave" oncut="return false"
                            oncopy="return false" autocomplete="off" />
                    </div>
                </div>
                <div class="col-md-12 text-right">
                    <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" />
                    <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
