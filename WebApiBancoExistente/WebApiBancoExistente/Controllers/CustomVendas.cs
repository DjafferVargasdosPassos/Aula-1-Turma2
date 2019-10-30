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
    public partial class VendasController
    {

        [HttpGet]
        [Route("Api/Vendas/CustomVendasQuery")]
        public object CustomVendas()
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();

            var retornoVendas = from ven in listVendas
                                join car in listCarros
                                on ven.Carro equals car.Id
                                select new
                                {
                                    VendaId = ven.Id,
                                    CarroNome = car.Modelo

                                };
            return retornoVendas;
        }
    }
}