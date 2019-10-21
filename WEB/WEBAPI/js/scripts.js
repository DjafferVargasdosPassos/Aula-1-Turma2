
$(document).ready(function () {
    $('input[type="button"]').click(function () {
        $.get("https://viacep.com.br/ws/89020070/json/", function (data, status) {
            $('input[name="bairro"]').val(data.bairro);
        });
    });
});





