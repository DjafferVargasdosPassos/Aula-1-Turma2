using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_calcular_area
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Infomar medida base");
            double medidaBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Infomar altura base");
            double alturaBase = double.Parse(Console.ReadLine());
            Console.WriteLine("O Total de área é = " + (medidaBase * alturaBase));
            Console.ReadKey();

        }
    }
}