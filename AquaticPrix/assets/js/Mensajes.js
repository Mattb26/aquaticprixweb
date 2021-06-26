
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