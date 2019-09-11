using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_tamanho_do_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o nome a ser calculado");
            var nomeLength = Console.ReadLine();

            Console.WriteLine($" O tamanho deste nome é:{nomeLength.Replace("", "").Length}");
            Console.ReadKey();
        }
    }
}
