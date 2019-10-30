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
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class MarcasController
    {
        [HttpGet]
        [Route("Api/Marcas/CustomMarcasQuery")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoMarcas = from mar in listaDeMarcas
                                select new
                                {
                                    NomeMarca = mar.Nome,
                                    MarcaId = mar.Id
                                };

            return retornoMarcas;
        }

    }
}