$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var nome = $('input[name="nome"]').val();
                alert(" Oi " + nome + " seja bem vindo!!!");
                
            });
    });
