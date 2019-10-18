using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //Iniciando uma constante de um numero inteiro
        const int testeConst = 999;
        static void Main(string[] args)
        {
            string testeprimitivo = string.Empty;
            string outroTestePrimitivo = string.Empty;
            bool testComp = "123" == "123";
            Boolean testeComp = "123" == "123";

            int numeroInteiro = 999;
            long numeroInteiroLongo = 9874561;

            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "String"; //Texto
            var teste2 = 'C'; //Char
            var teste3 = 0; //INT
            var teste4 = 0.0; //Double
            var teste5 = 0x00; //Hex
            //apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadLine();
            Console.ReadKey();


                
        }
    }
}
