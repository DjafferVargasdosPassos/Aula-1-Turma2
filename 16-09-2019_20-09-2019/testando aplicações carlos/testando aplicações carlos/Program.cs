using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando_aplicações_carlos
{
    class Program
    {
        static void Main(string[] args)
        {

            //sistema solicita as notas e realiza o cálculo da média e retorna se o aluno foi aprovado ou não
            double nota1, nota2, nota3, nota4, media = 0;   //assinando as variáveis do tipo double
            string frase = "Digite a {0}º nota: ";

            Console.WriteLine(frase, 1);    //escreve a frase
            nota1 = Convert.ToDouble(Console.ReadLine());   //assina a nota1 com o valor digitado. o Convert.ToDouble funciona como o int.Parse

            Console.WriteLine(frase, 2);    //escreve a frase
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 3);    //escreve a frase
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 4);    //escreve a frase
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;    //cálcula a média entre as notas

            Console.WriteLine("A média foi de " + media);   //escreve a frase concatenando com o valor da variável media

            if (media < 4)  //estrutura de decisão avalia se o aluno está aprovado, reprovado ou em exame
            {
                Console.WriteLine("O aluno está reprovado!");
            }
            else
            {
                if (media < 7)
                {
                    Console.WriteLine("O aluno está em exame!");
                }
                else
                {
                    Console.WriteLine("O aluno está aprovado!");
                }
            }
            Console.ReadKey();
        }
    }
}
