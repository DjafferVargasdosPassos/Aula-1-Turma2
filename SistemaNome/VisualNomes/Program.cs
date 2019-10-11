using NomeLibrary.Controller;
using NomeLibrary.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNomes
{
    public class Program
    {
        static NameController nameController = new NameController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine(" Escolha um Menu\r\n");
                Console.WriteLine("1 - Inserir Nome");
                Console.WriteLine("2 - Listar Nome");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        GravarNomes();
                        break;

                    case 2:
                        Console.Clear();
                        ListarNomes();
                        break;
                    default://caso colocar uma opção na valida
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("\r\n Pressione qualquer tecla para Continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
            public static void GravarNomes()
            {
                Console.WriteLine("---Gravar Nomes---\r\n");
                Console.WriteLine(" Cadastre o Nome no sistema");
                var nome = Console.ReadLine();
                nameController.InserirNome(new Name()
                {
                    Nome = nome
                });

                if (nome != null)
                    Console.WriteLine(" Nome cadastrado com sucesso!");
                else
                    Console.WriteLine(" Erro ao cadastrar nome");
            }
            public static void ListarNomes()
            {
                Console.WriteLine("---Lista de Nomes---\r\n");
            nameController.GetNames().ToList().ForEach(x => Console.WriteLine($"Id: {x.Id} nome: {x.Nome}"));
            }               
    }
}
