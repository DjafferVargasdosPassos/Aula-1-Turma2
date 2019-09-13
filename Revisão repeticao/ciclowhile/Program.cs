using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclowhile
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;


            //Console.WriteLine("Vamos conversar? sim(1) não(2)");
            //var resposta = int.Parse(Console.ReadKey().KeyChar.ToString());

            while (AskToContinue() == 1)
            {
                nome = AskToName();
                idade = AskToAge(nome);
                var Sexo = AskToSex();

            }

            Console.WriteLine($" {nome} Suas informações: Nome {nome} e sua idade {idade}");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo para mostrar o texto inicail do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("---Seja bem vindo---");
            Console.WriteLine("--------------------");
        }
        /// <summary>
        /// Metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns></returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        private static int AskToAge(string nome)

        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Vamos beber cerveja? sim(1) não(2)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Vamos beber guaraná? sim(1) não(2)");
                Console.ReadLine();
            }
            return idade;
        }
        /// <summary>
        /// Metodo para perguntar o nome
        /// </summary>
        /// <returns></returns>
        private static string AskToName()
        {
            Console.WriteLine("Qual o seu nome?");
            return Console.ReadLine();
        }

        private static string AskToSex()
        {
            Console.WriteLine("Qual seu sexo?");
            return Console.ReadLine();
        }
     
    }
}
