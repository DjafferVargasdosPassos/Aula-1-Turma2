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
            float medidaBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Infomar altura base");
            float alturaBase = float.Parse(Console.ReadLine());
            Console.WriteLine("area = " + (medidaBase * alturaBase));
            Console.ReadKey();

        }
    }
}