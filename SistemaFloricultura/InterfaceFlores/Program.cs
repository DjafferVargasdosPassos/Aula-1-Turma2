using CatalogoFlores.Controller;
using CatalogoFlores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFlores
{
    class Program
    {
        static FloresController floresController = new FloresController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;//Definimos um opção de menu inicial

            while (opcao != 0)//Definimos que enquanto for diferente de 0 ele continua em nosso loop
            {
                
                Console.WriteLine("----Escolha um Menu----");
                Console.WriteLine("1 - Inserir Flor");
                Console.WriteLine("2 - Listar Flores");
                Console.WriteLine("3 - Ordenar as flores de forma decrescente");
                Console.WriteLine("4 - Somar a quantidade flores");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirFlores();
                        break;

                    case 2:
                        ListarFlores();
                        break;

                    case 3:
                        OrdenarFloresMenorMaior();
                        break;

                    case 4:
                        QuantidadeTotalFlores();
                        break;

                    case 0:
                        opcao = 0;
                        Console.WriteLine("Saindo do Sistema...");
                        break;

                    default://caso colocar uma opção na valida
                        Console.WriteLine("Opção inválida");
                        break;

                }
                Console.WriteLine("\n Pressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();

            }   }

        public static void InserirFlores()
        {
            Console.WriteLine("---Cadastro de Flores---\r\n");
            Console.WriteLine(" Cadastre a Flor no sistema");
            var nome = Console.ReadLine();

            Console.WriteLine(" Informe a quantidade da flor cadastrada");
            var quantidade = int.Parse(Console.ReadLine());

            floresController.InserirFlores(new Flor()
            {
                Nome = nome,
                Quantidade = quantidade
            });

            if (nome != null)
                Console.WriteLine(" Flor cadastrado com sucesso!");
            else
                Console.WriteLine(" Erro ao cadastrar Flor");
        }
        public static void ListarFlores()
        {
            floresController.GetFlores().ToList<Flor>().ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome} Quantidade: {x.Quantidade}"));
        }

        public static void OrdenarFloresMenorMaior()
        {
            Console.Clear();
            var flor = floresController.GetFlores();
            flor.OrderByDescending(p => p.Quantidade).ToList<Flor>().ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome} Quantidade: {x.Quantidade}"));
           
        }

        public static void QuantidadeTotalFlores()
        {
            Console.Clear();

           // var total = floresController.GetFlores();
           //Console.WriteLine($"Total {total.Sum(p => p.Quantidade)}");           
                
            Console.WriteLine($"Total de flores cadastradas no sistema : {floresController.GetFlores().Sum(p => p.Quantidade)}");
                        
        }
    }
}
 