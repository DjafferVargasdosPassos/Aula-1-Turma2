using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaQuadrado
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        /// <summary>
        /// Metodo que calcula area de um quadrado
        /// </summary>
        public static void CalculoDeAreaQuadrado()
        {
            Console.WriteLine("Infomar medida:");
            double medida = double.Parse(Console.ReadLine());
            Console.WriteLine(" O Total da area do Quadrado é = " + (medida * medida) + (" m2"));
           
            Console.ReadKey();
        }
    }
}
