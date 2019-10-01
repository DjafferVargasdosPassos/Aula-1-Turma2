using MinhaSegundaClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var frutasDacesta = new List<Frutas>();

            frutasDacesta.Add(new Frutas()
            {
                Nome = "Banana",
                Quantidade = 2
            });

            frutasDacesta.Add(new Frutas()
            {
                Nome = "Maca",
                Quantidade = 4
            });

            frutasDacesta.Add(new Frutas()
            {
                Nome = "Laranja",
                Quantidade = 4
            });

            frutasDacesta.ForEach(i => Console.WriteLine($"Nome{i.Nome} Quant {i.Quantidade}"));
            Console.ReadKey();
        }
    }
}
