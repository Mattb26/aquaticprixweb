
function CorrectoMensajeMsj(mensaje) {
    $('#h4TituloMensaje').text("Confirmacion");
    $('#lblMensajeUser').text(mensaje);
    $("#imageID").attr('src', '../assets/img/Mensaje/comprobar.png');
    $("#myModal").modal("show");
}



function CorrectoMensaje() {
    $('#h4TituloMensaje').text("Confirmacion");
    $('#lblMensajeUser').text("Se agregó correctamente el nuevo usuario");
    $("#imageID").attr('src', '../assets/img/Mensaje/comprobar.png');
    $("#myModal").modal("show");
    return false;
}

function ErrorMensaje(mensaje) {
    $('#h4TituloMensaje').text("Error");
    $('#lblMensajeUser').html(mensaje);
    $("#imageID").attr('src', '../assets/img/Mensaje/advertencia.png');

    $("#myModal").modal("show");
}

function ErrorMensajeInsert(mensaje) {
    $('#h4TituloMensaje').text("Error");
    $('#lblMensajeUser').html(mensaje);
    $("#imageID").attr('src', '../assets/img/Mensaje/cancelar.png');

    $("#myModal").modal("show");
}

function ejecutarmensaje() {
    $("#modaCorrecto").modal("show");
}

function filename() {
    var rutaAbsoluta = self.location.href;
    var posicionUltimaBarra = rutaAbsoluta.lastIndexOf("/");
    var rutaRelativa = rutaAbsoluta.substring(posicionUltimaBarra + "/".length, rutaAbsoluta.length);
    return rutaRelativa;
}

function VerificarCorreo() {

    var URLactual = window.location;
    console.log(URLactual);

    try {
        if ($("input[ID$='txtCorreo']").val() != "" &&
            ValidarCorreo($("input[ID$='txtCorreo']").val())) {
            $.ajax({
                type: "POST",
                url: filename() + '/VerificarCorreoElectronico',
                data: JSON.stringify({ mail: $("input[ID$='txtCorreo']").val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: EstadoCorreo,
                failure: function (response) {
                    alert(response);
                },
                error: function (response) {
                    alert(response);
                }
            });

        }


    } catch (e) {
        console.log(e);
        alert(e);
    }


    return false;
}
function EstadoCorreo(response) {
    if (!response.d) {
        $("input[ID$='txtCorreo']").val("");
        ErrorMensaje("El correo-electronico ingresado ya se encuentra registrado");
    }
}


function VerificarUsuario() {


    try {

        if ($("input[ID$='txtUsuario']").val() != "") {
            $.ajax({
                type: "POST",
                url: filename() + '/VerificarUsuario',
                data: JSON.stringify({ usuario: $("input[ID$='txtUsuario']").val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: EstadoUsuario,
                failure: function (response) {
                    alert(response);
                },
                error: function (response) {
                    alert(response);
                }
            });

        }



    } catch (e) {
        console.log(e);
        alert(e);
    }


    return false;
}
function EstadoUsuario(response) {
    if (!response.d) {
        $("input[ID$='txtUsuario']").val("");
        ErrorMensaje("El usuario agregado ya se encuentra registrado");
    }
}



function ValidarCorreo(valor) {
    var re = /^([\da-z_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$/
    if (!re.exec(valor)) {
        return false;
    }
    else {
        return true;
    }
}