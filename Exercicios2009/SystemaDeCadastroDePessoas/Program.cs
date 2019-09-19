using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaDeCadastroDePessoas.Model;
namespace SystemaDeCadastroDePessoas
{
    class Program
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();
        static void Main(string[] args)
        {
            //primeira opção
            //var listaPessoa = new List<Pessoa>();

            //Console.WriteLine("informe nome");
            //var nome = Console.ReadLine();


            //Console.WriteLine("informe idade");
            //var idade = Console.ReadLine();
            //listaPessoa.Add(new Pessoa()
            //Console.WriteLine("informe sexo");
            //var sexo = Console.ReadLine();
            //Console.WriteLine("informe altura");
            //var altura = Console.ReadLine();
            //listaPessoa.Add(new Pessoa()
            //{
            //  Nome = nome
            //});
            //{
            //  Idade = idade
            //});
            //{
            //  Sexo = sexo
            //});
            //{
            //  Altura = altura
            //});

            

            //segunda opção
            Console.WriteLine("Digite 1 para inserir. ");
            //Console.WriteLine("Digite 2 para listar. ");
            var opcao = Console.ReadLine();

            //switch (opcao)
            //{
            //    case "1":
            //        AdicionaLista();
            //        break;
            //    case "2":
            //        listar();
            //        break;
            //    default:

            //}

            while (opcao == "1")
            {
                AdicionaLista();
                Console.WriteLine("Digite 1 para inserir. ");
                opcao = Console.ReadLine();
            }
            Listar();
            Console.ReadKey();
        }

        public static void AdicionaLista()

        {
            Pessoa objetoPessoa = new Pessoa();

            Console.WriteLine("Informe o nome");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura");
            objetoPessoa.Altura = double.Parse(Console.ReadLine());
            listaPessoa.Add(objetoPessoa);

        }
        public static void Listar()
        {
            listaPessoa.ForEach(ob => Console.WriteLine($"Nome: {ob.Nome}, Idade:{ob.Idade}, Sexo:{ob.Sexo}, Altura:{ob.Altura}"));
            Console.ReadKey();
        }
    }

}
