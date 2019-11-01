using ConectDbInnerJoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConectDbInnerJoin.Controllers
{
    
    public  class ReportsController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Vendas/Relatorio/{ano}")]
        public object RelatorioVendasOnYear(int ano)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                      ven.Id,
                                      CarroVendido = car.Modelo,
                                      ven.Quantidade,
                                      ven.Valor,
                                      Total = (ven.Quantidade * ven.Valor).ToString("N2")
                                  };

            return conteudoRetorno;
        }                    


        [HttpGet]
        [Route("Api/VendasPorVendedor/Relatorio/{ano}/{usuario}")]
        public object RelVendedorOnYear(int ano, int usuario)
        {
            var listVendas = db.Vendas.Where(x => x.DatInc.Year == ano && x.UsuInc == usuario).ToList();
            var listUsuarios = db.Usuarios.ToList();
            var listCarros = db.Carros.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join usu in listUsuarios
                                  on ven.UsuInc equals usu.Id                                  
                                  group new { ven, usu, car } by new { ven.DatInc.Year, ven.UsuInc, ven.Quantidade, car.Modelo } into groupby
                                  select new
                                  {
                                      AnoVenda = groupby.Key.Year,
                                      Vendedor = groupby.Key.UsuInc, 
                                      QuantidadeVendida = groupby.Key.Quantidade,
                                      ValorQueOMalucaoVendeu = groupby.Sum(p => p.ven.Quantidade * p.ven.Valor).ToString("N2")
                                  };
            return conteudoRetorno;
        }


        [HttpGet]
        [Route("Api/RelatorioVendasMarcasMesAno/{ano}/{marca}")]
        public object CustomMarcaOrderby(int ano, int marca)
        {

            var listVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listCarros = db.Carros.Where(x => x.Marca == marca).ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join mar in listMarcas
                                  on car.Marca equals mar.Id                                  
                                  group new { ven, mar,car } by new { ven.DatInc.Month, mar.Nome, car.Modelo } into groupby
                                  select new
                                  {
                                      PeriodoVendas = groupby.Key.Month,
                                      TotalDeVendasDaMarca = groupby.Sum(x => x.ven.Quantidade * x.ven.Valor),
                                      NomeMarca = groupby.Key.Nome
                                  };
            return conteudoRetorno.OrderByDescending(x => x.TotalDeVendasDaMarca);
        }


    }
}
