$(document).ready(
    function () {
        /*Chamamos nossa fun��o*/
        atualizaData();
    });
/*Criamos nossa primeira fun��o*/ 
function atualizaData() {
    /*Agora adicionamos a fun��a dentro da context do setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
   
}