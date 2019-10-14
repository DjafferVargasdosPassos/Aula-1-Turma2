using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Controller;


namespace GambCodeFirst
{
    class Program
    {
       static CervejaController cervejaContext = new CervejaController();
        static void Main(string[] args)
        {
            
                cervejaContext.AddCerveja(new Cerveja()
                {
                    Nome = "Cerveja Budweiser"
                });
        }
    }
}
