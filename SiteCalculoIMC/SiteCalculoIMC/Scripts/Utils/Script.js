$(document).ready(function () {

    $('button[name="bntcalcular"]').click(function () {

        var informacoes = $('form[name="formimc"]').serialize();
        var url = "http://localhost:60833/api/CalculoImc?";       

        $.get(url + informacoes, function (data) {
            alert(data);
           
        });

    });
});