using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
     public class ListaDeCervejas
    {
        public static void ListaDeCerveja()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("Brahma");
            minhaLista.Add("SKol");
            minhaLista.Add("Patagonia");
            minhaLista.Add("Budweiser");
            minhaLista.Add("Stella Artois");

            minhaLista.ForEach(i => Console.WriteLine(i));


        }
    }
}
