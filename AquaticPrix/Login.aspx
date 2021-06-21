<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AquaticPrix.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio Sesion</title>

    <link href="assets/vendor/bootstrap/css/bootstrap.css" rel="stylesheet" />

    <link href="assets/css/Login.css" rel="stylesheet" />
        <script src="<%=ResolveUrl("~/js/LoginAcceso.js")%>"
        type="text/javascript"></script>

    <script src="assets/vendor/jquery/jquery.min.js"></script>
    <script src="assets/vendor/bootstrap/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card card-container">
                <img id="profile-img" class="profile-img-card" src="assets/img/Mensaje/UserLogin.png" />
                <p id="profile-name" class="profile-name-card">
                </p>
                <form class="form-signin">
                    <span id="reauth-email" class="reauth-email"></span>
                    <input type="text" runat="server" id="txtUser" class="form-control" placeholder="Usuario"
                        required autofocus oncut="return false" oncopy="return false" autocomplete="off" />
                    <br />
                    <input type="password" runat="server" id="txtPassword" class="form-control" placeholder="Clave"
                        required oncut="return false" oncopy="return false" autocomplete="off" />
                    <br />
                    <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesion" CssClass="btn btn-lg btn-primary btn-block btn-signin" OnClick="btnIniciar_Click"/>
                </form>
                <a href="<%=ResolveUrl("~/BlqueoClavePregunta.aspx")%>" class="forgot-password">¿Ha
                olvidado la contraseña? </a>
            </div>
        </div>

        <!-- Modal -->
        <div id="modalLoginError" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content ">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                            &times;</button>
                        <h4 class="modal-title" id="h4TituloMensajeModificar">Error Login</h4>
                    </div>
                    <div class="modal-body">
                        <div class="col-md-12">
                            <img src="../dist/img/advertencia.png" align="right" id="imageIDModificar" />

                            <label for="subject" id="lblMensajeModificar">
                                Por favor verificar el usuario y contraseña que sea el correcto
                            </label>
                        </div>
                        <div class="tab-content">
                            <div class="row">
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">
                            Aceptar</button>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>

