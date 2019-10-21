$(document).ready(
    function () {
        $('input[name="btnsave"]').click(
            function () {
                var marca = $('input[name=marca]').val();
                var valor = $('input[name=valor]').val();
                var peso = $('input[name=peso]').val();

                var bike = { marca: marca, valor: valor, peso: peso }

                alert("saved")
                LimparTela();

                $('input[name="btnshow"]').click(
                    function () {
                        $('input[name=marca]').val(bike.marca);
                        $('input[name=valor]').val(bike.valor);
                        $('input[name=peso]').val(bike.peso);


                        alert("Bicicleta da marca " + marca +
                            " - valor: " + valor +
                            " - peso: " + peso +
                            " - Cadastrado realizado com Sucesso!");

                    });

            });
    });
function LimparTela() {
    var meusInputs = $('input[type="text"],input[type="number"]');
    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");
    }

}