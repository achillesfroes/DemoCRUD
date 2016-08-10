$('input.btn').on('click', submeter);

function submeter(evento) {

    evento.preventDefault();

    if (validarFormulario()) {

        var url = formulario.prop("action");
        var metodo = formulario.prop("method");

        var dadosFormulario = formulario.serialize();

        $.ajax({
            url: url,
            type: metodo,
            data: dadosFormulario,
            success: tratarRetorno
        });

    }

}

function validarFormulario() {

    btnAcao.prop("disabled", true);
 
    var validado = false;

    // verifica se formulario tem o método valid
    if (formulario.valid == undefined) {

        validado = true;
    }
    else {

        validado = formulario.valid();

        if (!validado) {

            btnAcao.prop("disabled", false);
        }
    }
    

    return validado;

}

function tratarRetorno(resultadoServidor) {

    if (resultadoServidor.resultado) {

        toastr['success'](resultadoServidor.message);

        $('#minhaModal').modal('hide');

        $('#gridDados').bootgrid('reload');

    }
    else {

        toastr['error'](resultadoServidor.message, msgErro);

        btnAcao.prop("disabled", false);
    }
}