function AgregarContacto() {

    var Nombre = $("input[ID$='txtNombreContac']").val();
    var CorreoElectronico = $("input[ID$='txtemailContac']").val();
    var Asunto = $("input[ID$='txtAsuntoContac']").val();
    var Mensaje = $("input[ID$='txtMsjContac']").val();
    console.log("ingreso");

    //var Contacto = {
    //   Nombre = $("input[ID$='txtNombreContac']").val(),
    //   CorreoElectronico = $("input[ID$='txtemailContac']").val(),
    //   Asunto = $("input[ID$='txtAsuntoContac']").val(),
    //   Mensaje = $("input[ID$='txtMsjContac']").val()
    //};
    //string nombre, string correo, string asjunto, string msj

    //console.log(Contacto);

    try {

        $.ajax({
            type: "POST",
            url: 'Index.aspx/AgregarContacto',
            data: JSON.stringify({ nombre: Nombre, correo: CorreoElectronico, asjunto: Asunto, msj:Mensaje}),
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