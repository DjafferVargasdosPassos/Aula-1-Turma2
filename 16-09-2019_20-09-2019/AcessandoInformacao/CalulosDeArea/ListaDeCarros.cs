using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
     public class ListaDeCarros
    {
        public static void ListaDeCarro()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("FERRARI");
            minhaLista.Add("GOL");
            minhaLista.Add("LOGAN");
            minhaLista.Add("ASTRA");
            minhaLista.Add("AMAROK");
            minhaLista.Add("FUSCA");

            minhaLista.ForEach(i => Console.WriteLine(i));

           
        }
    }
}
