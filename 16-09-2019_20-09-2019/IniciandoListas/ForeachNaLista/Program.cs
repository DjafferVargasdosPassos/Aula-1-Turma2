using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Metodo que mostra numeros inteiros
        /// </summary>
        private static void ListaDeInteiros()
        {
            var minhaLista = new List<int>();

            minhaLista.Add(1);
            minhaLista.Add(2);
            minhaLista.Add(3);
            minhaLista.Add(4);
            minhaLista.Add(5);
            minhaLista.Add(6);

            minhaLista.ForEach(numero => Console.WriteLine(numero));

            Console.ReadKey();

        }
        /// <summary>
        /// Mostra Lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019,9,17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("dddd/yyyy/MM/dd")));
            

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista string definidas
        /// </summary>
        private static void ListaString()
        {
            var minhalista = new List<string>();

            minhalista.Add("XIAOMI");
            minhalista.Add("IPHONE APPLE");
            minhalista.Add("SAMSUNG");
            minhalista.Add("NOKIA");

            minhalista.ForEach(i => Console.WriteLine(i));


            Console.ReadKey();
        }
        /// <summary>
        /// Minah Lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("c")+" "+FormataNumeroDecimalEmDolar(meuDecimal)+" "+ FormataNumeroDecimalEmEuro(meuDecimal)+" "+ FormataNumeroDecimalEmYen(meuDecimal)+" "+ FormataNumerosDecimaisEmBitCoin(meuDecimal)));
                       
        }
        /// <summary>
        /// Metodo que converte meu numero em dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>retorna o valor formatado em dolar</returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        } 
        /// <summary>
        /// Metodo que converte meu numero em real para euro
        /// </summary>
        /// <param name="meuEuro">meu numero em real</param>
        /// <returns>retorna meu numero formatada em euro</returns>
        private static string FormataNumeroDecimalEmEuro(double meuEuro)
        {
            return (meuEuro / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","Euro ");
        }
        /// <summary>
        /// Metodo que converte meu numero em Yen
        /// </summary>
        /// <param name="meuYen">Meu numero em real</param>
        /// <returns>retorna meu numero formatado em YEN</returns>
        private static string FormataNumeroDecimalEmYen(double meuYen)
        {
            return (meuYen / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-Jp"));
        }
        /// <summary>
        /// Metodo que converte meu numero em real para BitCoin
        /// </summary>
        /// <param name="meuBitCoin">meu numero em real</param>
        /// <returns>Retorna meu numero formatado em bitcoin</returns>
        private static string FormataNumerosDecimaisEmBitCoin(double meuBitCoin)
        {
            return (meuBitCoin / 41997.32).ToString("C10").Replace("R$","BTC");
        }

    }
}
