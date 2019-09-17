using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMostraArvore
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Metodo para desenhar arvore
        /// </summary>
        public static void MostraArvore()
        {
            Console.WriteLine("         ");
            Console.WriteLine("      ( @    )");
            Console.WriteLine("    (     @   )");
            Console.WriteLine("  (   @     @  )");
            Console.WriteLine(" (  @      @    )");
            Console.WriteLine("  (    @      )");
            Console.WriteLine("    (    @  )");
            Console.WriteLine("      |   | ");
            Console.WriteLine("      |   |");
            Console.WriteLine("      |   |");
            Console.WriteLine("      |   |");
            Console.WriteLine("______|___|_____");

            Console.ReadKey();
        }
    }

}
