using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reoalce_banana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma sequencia de numeros:");
            var textcontent = Console.ReadLine();

            Console.WriteLine(textcontent.Replace("3", "Banana"));
            Console.ReadKey();
        }
    }
}
