using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarros
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        /// <summary>
        /// metodo criado com lista de carros
        /// </summary>
        public static void ListaDeCarros()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("FERRARI");
            minhaLista.Add("GOL");
            minhaLista.Add("LOGAN");
            minhaLista.Add("ASTRA");
            minhaLista.Add("AMAROK");
            minhaLista.Add("FUSCA");

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

        }
             
    }
}
