using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SolucaoListaDeNomes.Models;

namespace SolucaoListaDeNomes.Controllers
{

    public class ListaNomesController : ApiController
    {
        List<Pessoa> listaDePessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Felipe", Idade = 27 },
            new Pessoa(){Nome = "Cliber", Idade = 52},
            new Pessoa(){Nome = "Giomar", Idade = 80},
            new Pessoa(){Nome = "Fernando D.", Idade = 36},
            new Pessoa(){Nome = "Fernando N", Idade = 32},
            new Pessoa(){Nome = "Djaffer", Idade = 31},
            new Pessoa(){Nome = "Giscleidson", Idade = 38},
            new Pessoa(){Nome = "Climber Tabajara", Idade = 64},
            new Pessoa(){Nome = "Maraja", Idade = 50}

        };
        public List<Pessoa> Get()
        {
            //Informo que minha api esta rodando normalmente
            return listaDePessoas;
        }
        public List<Pessoa> Post(Pessoa values)
        {
            listaDePessoas.Add(values);
            return listaDePessoas;
        }
    }
}
