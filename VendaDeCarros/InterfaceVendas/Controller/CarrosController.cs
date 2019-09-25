using InterfaceVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVendas.Controller
{
    class CarrosController
    {
        private List<Carros> listaDeCarros { get; set; }
        public CarrosController()
        {
            listaDeCarros = new List<Carros>();

            listaDeCarros.Add(new Carros() {Id = 1,Carro = "Risus Company",Valor = 7.200,QuantidadeVendida = 18,DataDaVenda = DateTime.Parse("29/01/2019") });
            listaDeCarros.Add(new Carros() {Id =  2,Carro = "Risus Associates",Valor = 9.961,QuantidadeVendida = 4,DataDaVenda = DateTime.Parse("10/02/2019")});

        }               

    }
}
