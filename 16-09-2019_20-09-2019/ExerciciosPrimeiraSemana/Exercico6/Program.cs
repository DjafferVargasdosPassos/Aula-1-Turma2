using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico6
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;
            Console.WriteLine("Digite alguma frase que contenha a palavra banana!!");
            texto = Console.ReadLine();

            Console.WriteLine(texto.Replace("banana" ,"laranja"));
            Console.ReadKey();

        }
    }
}
