<%@ Page Title="" Language="C#" MasterPageFile="~/MasterJuego.Master" AutoEventWireup="true" CodeBehind="CambioClave.aspx.cs" Inherits="AquaticPrix.Administracion.CambioClave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../assets/js/administracion/CambioClave.js"></script>
    <%--<script src="<%=ResolveUrl("~/assets/js/Mensajes.js")%>"></script>--%>
    <script src="../assets/js/Mensajes.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="well well-sm">
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="subject">
                            Usuario</label>
                        <input type="text" runat="server" id="txtUsuario" class="form-control" style="background-color: #F3F2D7"
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
                    <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click" OnClientClick="ValidacionesCambioClave()" />
                </div>
            </div>
        </div>
    </div>

    <!-- Modal Generico-->
    <div id="myModal" class="modal fade" data-backdrop="static">
        <div class="modal-dialog">
            <div class="modal-content ">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                    </button>
                    <h4 class="modal-title" id="h4TituloMensaje">Confirmación</h4>
                </div>
                <div class="modal-body">
                    <div class="col-md-12">

                        <img id="imageID" align="right" src="../assets/img/Mensaje/signoInterrogacion.png" />
                        <p id="lblMensajeUser">
                        </p>
                    </div>
                    <div class="tab-content">
                        <div class="row">
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-dismiss="modal" onclick="LimpiarTodo(); return false;">
                        Aceptar</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
