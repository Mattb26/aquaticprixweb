function ValidacionesCambioClave() {
    if (($("input[ID$='txtClaveAnterior']").val() != "") &&
        ($("input[ID$='txtNuevaClave']").val() == $("input[ID$='txtConfirmarClave']").val())) {

        if ($("input[ID$='txtClaveAnterior']").val() == $("input[ID$='txtConfirmarClave']").val()) {
            ErrorMensaje("La clave nueva no puede ser igual a la anterior");
            //return false;
        }
        else {
            return false;
        }

    } else if ($("input[ID$='txtClaveAnterior']").val() == "") {
        ErrorMensaje("Por favor ingrese la clave actual");
        //return true;
    } else if ($("input[ID$='txtNuevaClave']").val() != $("input[ID$='txtConfirmarClave']").val()) {
        ErrorMensaje("La nueva clave ingresada no coincide");
        //return true;
    }
}
function LimpiarTodo() {
    $("input[ID$='txtClaveAnterior']").val();
    $("input[ID$='txtNuevaClave']").val();
    $("input[ID$='txtConfirmarClave']").val();
}