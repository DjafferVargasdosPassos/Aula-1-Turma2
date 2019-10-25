$(document).ready(function () {
    //adiciona uma função ao click do botao
    $('input[name="Inserir"]').click(function () {
        //obter as informações dos meus campos
        //Obtemos as informações do nosso formulario web completo
        var informacoes = $('form[name="formenviar"]').serializeArray();
        //Obtemos o atributo que indica a pagina que vamos enviar o post
        var obterAtributo = $('form[name="formenviar"]').attr('send-post');

        $.get("http://localhost:52676/api/Imc?" + informacoes, function (data) {
            //aqui como recebemos uma string com formato de JSON
            //temos que passar ela para o JSON parecido com o int.Parse()
            alert(data);
        });

    });
});