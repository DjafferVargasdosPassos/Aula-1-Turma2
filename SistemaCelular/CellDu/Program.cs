using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        // 1- Colocar console para startar projeto
        // 2- Adicionar referencia catalogoCelulares
        //3 - Adicionar Entity em nosso projeto
        //4 - Adicionar using ao nosso projeto Model,Controller
        static CelularesController celulares = new CelularesController();

        static void Main(string[] args)
        {
            var opcao = int.MinValue;//Definimos um opção de menu inicial

            while (opcao != 0)//Definimos que enquanto for diferente de 0 ele continua em nosso loop
            {
                Console.WriteLine("Escolha um Menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Atualizar celular");
                Console.WriteLine("3 - Remover celular");
                Console.WriteLine("4 - Listar Celular");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;

                    case 2:
                        AtualizarCelular();
                        break;

                    case 3:
                        RemoverCelular();
                        break;

                    case 4:
                        ListarCelular();
                        break;

                    case 0:
                        opcao = 0;
                        Console.WriteLine("Saindo do Sistema...");
                        break;

                    default://caso colocar uma opção na valida
                        Console.WriteLine("Opção inválida");
                        break;

                }

                //Colocamos true para não mostrar na tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para Continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        //Inserir
        /// <summary>
        /// Metodo para inserir celulares na lista
        /// </summary>
        public static void InserirCelular()
        {
            Console.WriteLine("--Inserir Celular--");

            Console.WriteLine("Informe o Marca do celular");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");
            var preco = double.Parse(Console.ReadLine());

            var resultado = celulares.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });

            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar o aparelho!");
            
        }
        //Atualizar
        /// <summary>
        /// Metodo para atualizar nossa lista
        /// </summary>
        public static void AtualizarCelular()
        {
            Console.WriteLine("--Atualizar Celular--");

            ListarCelular();

            Console.WriteLine("Informe o Id para alteração de registro");// Informamos ao usuario para colocar o Id para realizar a alteração
            var celularId = int.Parse(Console.ReadLine());//obtemos o Id informado

            var celular = celulares.GetCelulares().FirstOrDefault(x => x.Id == celularId);

            if (celular == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }
               
            Console.WriteLine("Informe o Marca do celular");
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares.AtualizarCelular(celular);

            if(resultado)
                Console.WriteLine("Celular atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar aparelho");
        }
        //Remover
        /// <summary>
        /// Metodo para remover nosso registro de celular
        /// </summary>
        public static void RemoverCelular()
        {
            Console.WriteLine("--Remover Celular--");

            ListarCelular();

            Console.WriteLine("Informe o Id para remoção do registro");// Informamos ao usuario para colocar o Id para realizar a alteração
            var celularId = int.Parse(Console.ReadLine());//obtemos o Id informado

            var resultado = celulares.RemoverCelular(celularId);

            if (resultado)
                Console.WriteLine("Celular removido com sucesso!");
            else
                Console.WriteLine("Erro ao remover aparelho");
            
        }
        //Listar
        public static void ListarCelular()
        {
            Console.WriteLine("Lista Celular");
            celulares.GetCelulares()//Obtemos a lista de celulares
               .ToList<Celular>()//Convertemos para uma lista em memoria
               .ForEach(x => //Laço de repetição para mostrar cada celular 
                             //Mostramos no console nosso celular
               Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));

        }
    }
}
