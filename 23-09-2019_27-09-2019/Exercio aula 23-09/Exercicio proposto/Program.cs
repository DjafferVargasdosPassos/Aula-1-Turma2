using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDePessoas = new List<Pessoas>();

            listaDePessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96                

            }) ;

            listaDePessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            }) ;

            listaDePessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2001"),
                Carteira = 469.01

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 5,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 9,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76

            });

            listaDePessoas.Add(new Pessoas()
            {
                Id = 10,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira =271.05

            });

            //listaDePessoas.Add(new Pessoas()
           // {
              //  Id = 11,
             //   Nome = "",
              //  DataNascimento = DateTime.Parse(""),
               // Carteira = 

           // });

            //listaDePessoas.Add(new Pessoas()
            //{
            //    Id = 12,
            //    Nome = "",
            //    DataNascimento = DateTime.Parse(""),
            //    Carteira = 

            //});

            //listaDePessoas.Add(new Pessoas()
            //{
            //    Id = 13,
            //    Nome = "",
            //    DataNascimento = DateTime.Parse(""),
            //    Carteira = 

            //});

            //listaDePessoas.Add(new Pessoas()
            //{
            //    Id = 14,
            //    Nome = "Gay",
            //    DataNascimento = DateTime.Parse("03/12/2001"),
            //    Carteira = 911.92

            //});

            //listaDePessoas.Add(new Pessoas()
            //{
            //    Id = 15,
            //    Nome = "Gay",
            //    DataNascimento = DateTime.Parse("03/12/2001"),
            //    Carteira = 911.92

            //});

            Console.WriteLine("------------Apresentando Nomes em Ordem Crescente-------------");
            listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id {i.Id}, Nome {i.Nome} Data de nascimento, {i.DataNascimento.ToShortDateString()}, carteira {i.Carteira}"));

            Console.WriteLine("\r\n------------Apresentando Datas em Ordem Decrescente-------------");
            listaDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id {i.Id}, Nome {i.Nome}, Data de nascimento {i.DataNascimento.ToShortDateString()}, carteira {i.Carteira}"));

            Console.WriteLine("\r\n------------Apresentando Pessoas com Valore acima de 500-------------");
            var filtroDeGrana = listaDePessoas.Where(x => x.Carteira > 500.00).OrderBy(x => x.Carteira);
            filtroDeGrana.ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id {i.Id}, Nome {i.Nome}, Data {i.DataNascimento.ToShortDateString()}, carteira {i.Carteira}"));

            Console.WriteLine("\r\n------------Apresentando Pessoas com mais de 18 anos-------------");
            var filtroDeMaiorIdade = listaDePessoas.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) > 18);

            
            
            Console.ReadKey();
        }
    }
}
