using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto que possua a palavra banana!!");
            var texto = Console.ReadLine();

            Console.WriteLine(texto.Replace("banana","laranja"));
            Console.ReadKey();


        }
    }
}
