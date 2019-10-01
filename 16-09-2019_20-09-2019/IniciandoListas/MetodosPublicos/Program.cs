using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
   public class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Metodo que converte moeda em real para um alvo especificado COMO "DOLAR,EURO,YEN.BTC" pelo usuário
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {

            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalEmYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumerosDecimaisEmBitCoin(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("Tipo de moeda não encontrada");
                    break;
            }


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
            return (meuEuro / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro ");
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
            return (meuBitCoin / 41997.32).ToString("C10").Replace("R$", "BTC");
        }
        /// <summary>
        /// Metodo principal de conversor monetário
        /// </summary>
        public static void ConversosMonetarioSis()
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine().ToUpper();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
    }

}