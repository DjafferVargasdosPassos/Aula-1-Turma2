using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoLista
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }
        /// <summary>
        /// metodo de lista de valores
        /// </summary>
        private static void ListaDeValores()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(11.52);
            minhaLista.Add(6.89);
            minhaLista.Add(39.54);

            minhaLista.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
        private static string FormatNumDecimalEmDol (double meuDolar)
        {
            return (meuDolar / 4.50).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        private static string  FormatNumDecimalEmEu (double meuEuro)
        {
            return (meuEuro / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("fr-Fr"));
        }
        private static string FormatNumDecimalEmYen (double meuYen)
        {
            return (meuYen / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("Ja-Jp"));
        }
        private static string FormatNemDecimalEmBtc(double meuBtc)
        {
            return (meuBtc / 41997.32).ToString("C", CultureInfo.CreateSpecificCulture("en-Us")).Replace("$,BTC");
        }
    }
}
