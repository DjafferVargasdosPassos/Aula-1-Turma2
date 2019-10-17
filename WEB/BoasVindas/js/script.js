$(document).ready(
    function () {
        $('button[name="btn"]').click(
            function () {
                var nomeusuario = $('input[name="nome"]').val();
                $('span[name="usuariotext"]').text(nomeusuario);

            });
    }
    );

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('button[name="btn"]').click();
    }
});
