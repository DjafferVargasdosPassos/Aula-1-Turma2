using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicação
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }
        public string Get(int anoNascimento, string nomeUsuario = "Defaul")
        {           

            if((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $" Olá {nomeUsuario} De acordo com os calculos realizados vc está liberado para meter o loko na birita";
            }
            else
            {
                return $" Olá {nomeUsuario}Bora beber leite para ficar fortinho";
            }
            
        }
    }
}
