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

        public string Get(double altura, double peso, string nomeUsuario= "Defaul")
        {
            
            double imc = peso / (altura * altura);           

            return $" Olá {nomeUsuario} seu IMC é {imc} e ele foi calculado de acordo com sua Altura: {altura} e Peso: {peso}";           
           
        }
    }
}
