using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCervejas
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Metodo criado com lista de marcas de cerveja
        /// </summary>
        public static void ListaDeCerveja()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("Brahma");
            minhaLista.Add("SKol");
            minhaLista.Add("Patagonia");
            minhaLista.Add("Budweiser");
            minhaLista.Add("Stella Artois");

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

        }
    }
}