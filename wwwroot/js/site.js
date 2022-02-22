// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Cadastrar() {

    //array com dados do form
    let parametros = {
        Nome: $("#nome").val(),
        Email: $("#email").val(),
        Mensagem: $("#mensagem").val()
    };

    console.log("Linha 14" + parametros);


    //requisicao via POST informando o endereco e array de parametros
    $.post("/Home/Cadastrar", parametros)

        .done(
            function (data) {

                if (data.status === "OK") 
                {
                    $("#modalCad").after("<p>NewsLetter assinado com sucesso!</p>");
                    $("#modalCad").hide();
                }
                else 
                {
                    $("#modalCad").after("<p>" + data.mensagem + "</p>");
                }
            }
        )

        .fail(
            function () 
            {
                alert("Ocorreu um erro");
            }
        );
}


$(document).ready(

    function () {
        $("#frmCadastro").submit(

            function (e) {
                e.preventDefault();
                Cadastrar();
            }
        );
    }
);
