using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GambCodeFirst
{
    class Program
    {
        static CervejaContextDb cervejaContext = new CervejaContextDb();
        static void Main(string[] args)
        {
            
                cervejaContext.Add(new Cerveja()
                {
                    Nome = "Cerveja Budweiser"
                });
        }
    }
}
