function soloNumeros(e) {
    var key = window.Event ? e.which : e.keyCode;
    return (key >= 48 && key <= 57);
}
function soloLetras(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
    especiales = [8, 37, 39, 46];

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (letras.indexOf(tecla) == -1 && !tecla_especial)
        return false;
}
function PasarMayuscula(e, solicitar) {
    // Admitir solo letras
    tecla = (document.all) ? e.keyCode : e.which;
    if (tecla == 8) return true;
    patron = /[\D\s]/;
    te = String.fromCharCode(tecla);
    if (!patron.test(te)) return false;
    // No amitir espacios iniciales y convertir 1ª letra a mayúscula
    txt = solicitar.value;
    if (txt.length == 0 && te == ' ') return false;
    if (txt.length == 0 || txt.substr(txt.length - 1, 1) == ' ') {
        solicitar.value = txt + te.toUpperCase();
        return false;
    }
}
function validarEmail(email) {
    expr = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (!expr.test(email))
        alert("Error: La dirección de correo " + email + " es incorrecta.");
}