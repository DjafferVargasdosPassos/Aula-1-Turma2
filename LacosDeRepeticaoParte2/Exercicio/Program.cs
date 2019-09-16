using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //string criada para alterar nome no texto
            string nome = "Djaffer";
            // var criada para texto usando $ para colocar a string nome dentro do texto
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{nome};para;depois;usar;com;o;replace";
            //pedidndo para printar o texto
            Console.WriteLine(conteudoDoTexto);
            //pede para digitar a palavra a se buscada 
            Console.WriteLine(" Digite a palavra procurada:");
            //palavra digitada 
            var palavra = Console.ReadLine();


            var conteudoDoTextoSplit = conteudoDoTexto.Split(';');
            //criada um variavel para contagem
            int contpalavras = 0;
            // rastreia palava por palavra (item)
            foreach (var item in conteudoDoTextoSplit)
            {
                // se a palavra procurada for igual alguma(item)
                if (palavra == item)
                    // se for verdade abre a contagem
                    contpalavras++;


            }
            Console.WriteLine($" palavra foi encontrada {contpalavras} vezes.");
            Console.WriteLine(conteudoDoTexto.Replace(";", " "));
            Console.ReadKey();

           
        }
    }
}
