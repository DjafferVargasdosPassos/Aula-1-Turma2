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

        public VendasContext contextDB = new VendasContext();
                     
         public List<Carros> RetornaListaDeCarros()
        {
            return contextDB.listaDeCarros;

        }

    }
}
