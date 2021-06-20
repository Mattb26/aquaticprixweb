function AgregarContacto() {

    var Nombre = $("input[ID$='txtNombreContac']").val();
    var CorreoElectronico = $("input[ID$='txtemailContac']").val();
    var Asunto = $("input[ID$='txtAsuntoContac']").val();
    var Mensaje = $("#txtMsjContac").val();

    try {

        $.ajax({
            type: "POST",
            url: 'Index.aspx/AgregarContacto',
            data: JSON.stringify({ nombre: Nombre, correo: CorreoElectronico, asunto: Asunto, msj:Mensaje}),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: Estado,
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response);
            }
        });

    } catch (e) {
        console.log(e);
        alert(e);
    }


    return false;
}

function Estado(response) {

   

    if (response.d) {
      
    }

}


function AgregarUsuario() {

    try {
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
            success: EstadoUsuario,
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response);
            }
        });

    } catch (e) {
        console.log(e);
        alert(e);
    }


    return false;
}

function EstadoUsuario(response) {



    if (response.d) {

    }

}