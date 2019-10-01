using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Informe um valor: ");
            int numero = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine($"\r\nO valor informado é {numero}");
            Console.ReadKey();
        }
    }
}
