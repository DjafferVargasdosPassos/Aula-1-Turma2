using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.MODEL;
namespace Tela
{
    class Program
    {
        static void Main(string[] args)
        {
            CervejaController cervejaController = new CervejaController();
            cervejaController.GetCervejas().ForEach(x => Console.WriteLine($"Id {x.Id} Nome{x.Nome} Litros{x.Litros} Valor{x.Valor}"));
                      
            Console.WriteLine("Digite nome da cerveja:");
            var n = Console.ReadLine();
            Console.WriteLine("Digite quantidade em ml da cerveja:");
            var l = double.Parse(Console.ReadLine())/1000;
            Console.WriteLine("Digite teor alcoólico:");
            var al = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("Digite preço da cerveja:");
            var v = double.Parse(Console.ReadLine());

            Cerveja cerva = new Cerveja()
            {                
                Nome = n,
                Litros = l,
                Alcool = al,
                Valor = v
            };

                     
            
            Console.ReadKey();

        }
    }
}
