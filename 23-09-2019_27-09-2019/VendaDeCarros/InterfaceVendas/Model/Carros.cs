using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVendas.Model
{
   
    public class Carros
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public double Valor { get; set; }
        public int QuantidadeVendida { get; set; }
        public DateTime DataDaVenda { get; set; }

    }
}
