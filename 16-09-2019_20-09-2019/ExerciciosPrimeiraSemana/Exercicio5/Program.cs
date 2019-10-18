using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("Digite qualquer palavra:");
            texto = Console.ReadLine();
            //utilizado para buscar letra em determinada posição
            Console.WriteLine(texto.Substring(0, 1));
            Console.WriteLine(texto.Substring(texto.Length - 1, 1));
            Console.ReadKey();
        }
    }
}
