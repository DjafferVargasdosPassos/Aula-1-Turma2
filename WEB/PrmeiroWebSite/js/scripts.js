$(document).ready(
    function () {
        /*Chamamos nossa função*/
        atualizaData();
    });
/*Criamos nossa primeira função*/ 
function atualizaData() {
    /*Agora adicionamos a funçõa dentro da context do setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
   
}