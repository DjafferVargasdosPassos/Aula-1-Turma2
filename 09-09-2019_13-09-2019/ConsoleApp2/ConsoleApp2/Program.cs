using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o livro");
            var numeroDoLivro = Console.ReadLine();
            if (numeroDoLivro == "123456")
            {
                Console.WriteLine(" Livro indisponível");
                Console.ReadKey();
                return;                
            }
            else
            {
                Console.WriteLine(" Deseja alocar livro? 1-sim ou 2-não");
                var alocarLivro = Console.ReadLine();
                if (alocarLivro == "1")
                {
                    Console.WriteLine(" Livro alocado.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" Livro não alocado");
                    Console.ReadKey();
                }

            }
           

        }
    }
}
