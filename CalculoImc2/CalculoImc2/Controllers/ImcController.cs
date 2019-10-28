using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculoImc2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ImcController : ApiController
    {
        public string Get()
        {
            return "teste";
        }         


        public string Post(Pessoa pessoa)
        {
            
            double imc = pessoa.Peso/ (pessoa.Altura *  pessoa.Altura);
            var result = imc.ToString("F");
            return $" Olá {pessoa.Nome} seu IMC é {result} e ele foi calculado de acordo com sua Altura: {pessoa.Altura } e Peso: {pessoa.Peso}";           
           
        }
    }
}
