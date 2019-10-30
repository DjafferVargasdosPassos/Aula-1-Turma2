using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiWebImoveis.Models;


namespace ApiWebImoveis.Controllers
{
    public partial class ImovelsController
    {
        [HttpGet]
        [Route("Api/Imoveis/ImoveisComProprietarios")]
        public object CustomImoveisOnProprietarios()
        {
            var listProprietarios = db.Proprietarios.ToList();
            var listImoveis = db.Imoveis.ToList();

            var conteudoRetorno = from pro in listProprietarios
                                  join imo in listImoveis
                                  on pro.Id equals imo.ProprietarioId
                                  select new
                                  {
                                      ProprietarioImovel = pro.Nome,
                                      ImovelCep = imo.Cep,
                                      ImovelRua = imo.Logradouro,
                                      ImovelNumero = imo.Numero,
                                      ImovelBairro = imo.Bairro,
                                      ImovelCidade = imo.Municipio
                                  };
            return conteudoRetorno;
        }

    }
}