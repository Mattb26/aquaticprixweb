function LimpiarTodo() {
    $("input[ID$='txtNombre']").val("");
    $("input[ID$='txtUsuario']").val("");
    $("input[ID$='txtApellido']").val("");
    $("input[ID$='txtFechaNacimiento']").val("dd/MM/yyyy");
    $("input[ID$='txtCorreo']").val("");
    $("input[ID$='txtUsuario']").val("");
    $("input[ID$='txtClave']").val("");
    $("[id*=drpdPerfil]").val("Seleccione...");
}