function AgregarContacto() {

    try {

        if ($("input[ID$='txtNombreContac']").val() != "" &&
            $("input[ID$='txtemailContac']").val() != "" &&
            $("input[ID$='txtAsuntoContac']").val() != "" &&
            $("#txtMsjContac").val() != "" && ValidarCorreo($("input[ID$='txtemailContac']").val())) {


            var Nombre = $("input[ID$='txtNombreContac']").val();
            var CorreoElectronico = $("input[ID$='txtemailContac']").val();
            var Asunto = $("input[ID$='txtAsuntoContac']").val();
            var Mensaje = $("#txtMsjContac").val();

            $.ajax({
                type: "POST",
                url: 'Index.aspx/AgregarContacto',
                data: JSON.stringify({ nombre: Nombre, correo: CorreoElectronico, asunto: Asunto, msj: Mensaje }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: EstadoContacto,
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
    }


    return false;
}

function EstadoContacto(response) {

   

    if (response.d) {

        $("input[ID$='txtNombreContac']").val("");
        $("input[ID$='txtemailContac']").val("");
        $("input[ID$='txtAsuntoContac']").val("");
        $("#txtMsjContac").val("");

        CorrectoMensajeMsj("En la brevedad estaremos respondiendo su consulta");
    }
    else {
        CorrectoMensajeMsj("Error en la comunicación");
    }
    return false;
}


function AgregarUsuario() {

    try {
        if ($("input[ID$='txtNombre']").val() != "" &&
            $("input[ID$='txtApellido']").val() != "" &&
            $("input[ID$='txtFechaNacimiento']").val() != "" &&
            $("input[ID$='txtUsuario']").val() != "" &&
            $("input[ID$='txtClave']").val() != "" &&
            $("input[ID$='txttxtCorreo']").val() &&
            ValidarCorreo($("input[ID$='txttxtCorreo']").val())) {
            $.ajax({
                type: "POST",
                url: 'Index.aspx/Alta',
                data: JSON.stringify({
                    nombre: $("input[ID$='txtNombre']").val(),
                    apellido: $("input[ID$='txtApellido']").val(),
                    fechaNacimiento: $("input[ID$='txtFechaNacimiento']").val(),
                    nick: $("input[ID$='txtUsuario']").val(),
                    clave: $("input[ID$='txtClave']").val(),
                    correo: $("input[ID$='txttxtCorreo']").val()
                }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: EstadoUsuarioAlta,
                failure: function (response) {
                    alert(response);
                },
                error: function (response) {
                    alert(response);
                }
            });
        }
        else {
            return false;
        }
        return false;

    } catch (e) {
        console.log(e);
    }


    return false;
}

function EstadoUsuarioAlta(response) {



    if (response.d) {
        CorrectoMensajeMsj("Se creó correctamente su cuenta");
        $("input[ID$='txtNombre']").val("");
        $("input[ID$='txtApellido']").val("");
        
        $("input[ID$='txtUsuario']").val("");
        $("input[ID$='txtClave']").val("");
        $("input[ID$='txttxtCorreo']").val("");
        $("input[ID$='txtFechaNacimiento']").val("dd/MM/yyyy");
        return false;
    }
    else {
        ErrorMensaje("Error en la comunicación");
    }
   
}


function VerificarUsuario() {


    try {

        if ($("input[ID$='txtUsuario']").val() != "") {
            $.ajax({
                type: "POST",
                url: 'Index.aspx/VerificarUsuario',
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
    }


    return false;
}
function EstadoUsuario(response) {
    if (!response.d) {
        $("input[ID$='txtUsuario']").val("");
        ErrorMensaje("El usuario agregado ya se encuentra registrado");
    }
}



function VerificarCorreo() {


    try {
        if ($("input[ID$='txttxtCorreo']"). val() != "" &&
            ValidarCorreo($("input[ID$='txttxtCorreo']").val())) {
            $.ajax({
                type: "POST",
                url: 'Index.aspx/VerificarCorreoElectronico',
                data: JSON.stringify({ mail: $("input[ID$='txttxtCorreo']").val() }),
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
    }


    return false;
}
function EstadoCorreo(response) {
    if (!response.d) {
        $("input[ID$='txttxtCorreo']").val("");
        ErrorMensaje("El correo-electronico ingresado ya se encuentra registrado");
    }
}



function CorrectoMensajeMsj(mensaje) {
    $('#h4TituloMensaje').text("Confirmacion");
    $('#lblMensajeUser').text(mensaje);
    $("#imageID").attr('src', 'assets/img/Mensaje/comprobar.png');
    $("#myModal").modal("show");
}



function CorrectoMensaje() {
    $('#h4TituloMensaje').text("Confirmacion");
    $('#lblMensajeUser').text("Se agregó correctamente el nuevo usuario");
    $("#imageID").attr('src', 'assets/img/Mensaje/comprobar.png');
    $("#myModal").modal("show");
}

function ErrorMensaje(mensaje) {
    $('#h4TituloMensaje').text("Error");
    $('#lblMensajeUser').html(mensaje);
    $("#imageID").attr('src', 'assets/img/Mensaje/advertencia.png');

    $("#myModal").modal("show");
}

function ErrorMensajeInsert(mensaje) {
    $('#h4TituloMensaje').text("Error");
    $('#lblMensajeUser').html(mensaje);
    $("#imageID").attr('src', 'assets/img/Mensaje/cancelar.png');

    $("#myModal").modal("show");
}

function ejecutarmensaje() {
    $("#modaCorrecto").modal("show");
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


function Bajar() {

    try {

        $.ajax({
            type: "POST",
            url: 'Index.aspx/Descargar',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: respuesta,
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response);
            }
        });

    } catch (e) {
        console.log(e);
    }
}
function respuesta(value) {
    console.log(value);
}