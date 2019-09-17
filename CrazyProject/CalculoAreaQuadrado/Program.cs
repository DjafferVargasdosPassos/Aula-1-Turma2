using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Metodo que calcula area de um quadrado
        /// </summary>
        public static void CalculoDeAreaQuadrado()
        {
            Console.WriteLine("Infomar medida da base");
            double medidaBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Infomar altura base");
            double alturaBase = double.Parse(Console.ReadLine());
            Console.WriteLine("O Total de área é = " + (medidaBase * alturaBase));
            Console.ReadKey();
        }
    }
}
