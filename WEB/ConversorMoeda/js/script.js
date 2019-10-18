$(document).ready( //aqui ao carregar o documento iniciamos o js
    function () { //este function funciona igual ao new 
        $('button[name="btn"]').click( // adicionamos a funcao ao nosso botão
            function () {

                var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json"


                $.getJSON(url, function (data) {
                    var valordolar = data.value[0].cotacaoVenda;
                    /*Obter valor*/
                    var meuValorReal = $('input[name="real"]').val().replace(".", "").replace(",", "."); //aqui obtemos o valor ".val(999)" setamos o valor
                    var meuValorDolar = 4.16;
                    var conversao = (meuValorReal / meuValorDolar).toFixed(2).toString().replace(/(\d)(\d{2})$/, "$1,$2");

                    /*Inserir valor*/
                    $('input[name="dolar"]').val(conversao);
                });
                $('input[name="real"]').mask("000.000,00");
            });
              
    });
	$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('button[name="btn"]').click();
    }
});