using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int idade;

            Console.WriteLine("Digite seu nome!!!");
            name = Console.ReadLine();
            Console.WriteLine("Digite sua idade!!!");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"Parabéns {name} você já esta na fase adulta!!");

            else
                Console.WriteLine($"Calma { name } tudo ao seu tempo logo você terá 18 anos de idade.");

            Console.ReadKey();
        }
    }
}

