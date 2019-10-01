using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaNomes();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar sobre o caractere
        /// </summary> 
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);


            }
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Djaffer para realiza a busca";

            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine(" Palavra encontrada com sucesso!");

            }
            Console.ReadKey();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuário cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe um nome de sistema");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($" O {nome} está com {idade} anos de idade.");
                }

            }

            Console.ReadKey();
        }
        private static void ForeachComSplitListaVeiculos()
        {
            //Base de informaçoes assinando o texto
            var conteudocarro = "carro:Gol,marca:VW,ano:2000;carro:Astra,marca:GM,ano:99;carro:Uno,marca:Fiat,ano:2012";
            //separa a lista (texto) depois do (;)
            var listaDeCarros = conteudocarro.Split(';');
            Console.WriteLine(" Carros cadastrados no sistema");

            foreach (var itemcarro in listaDeCarros)
            {
                Console.WriteLine(itemcarro.Split(',')[0]);
            }
            Console.WriteLine(" Digite o veiculo a ser encontardo:");
            var veiculoBusca = Console.ReadLine();

            foreach (var itemcarro in listaDeCarros)
            {
                var informacoesSplit = itemcarro.Split(',');

                var nomecarro = informacoesSplit[0].Split(':')[1];
                var marcacarro = informacoesSplit[1].Split(':')[1];
                var anocarro = informacoesSplit[2].Split(':')[1];

                if (nomecarro == veiculoBusca)
                {
                    Console.WriteLine($" O carro {nomecarro} da fabricante {marcacarro} com o ano {anocarro} já foi vendido.");
                }
                Console.ReadKey();
            }

        }
        private static void ConsultaNomes()
        {
            var texto = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listaDeInformacoe = texto.Split(';');

           
            foreach (var item in listaDeInformacoe)
            {
                var quebraInformacao = item.Split(',');
                var idade = int.Parse(quebraInformacao[1].Split(':')[1]);// verificar problema
                var nome = quebraInformacao[0].Split(':')[1];

                if (idade >= 18)
                {
                    Console.WriteLine($"Nome: {nome} Idade: {idade}");
                }

            }
        }

    

    }
}