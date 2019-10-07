using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosEntit.Model;
using AlunosEntit.Controller;


namespace Interface
{
   public class Program
    {
         AlunoController alunoController = new AlunoController();
        static void Main(string[] args)
        {
            alunoController.AddAluno(new Aluno()
            {
                Nome = "Djaffer",
                Idade = 31
            });

            alunoController.AddAluno(new Aluno()
            {
                Nome = "Daniela",
                Idade = 33
            });

            alunoController.AddAluno(new Aluno()
            {
                Nome = "Guilherme",
                Idade = 12
            });
            alunoController.AddAluno(new Aluno()
            {
                Nome = "Lui",
                Idade = 9
            });

            alunoController.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine($"{x.Nome} , {x.Idade}"));
            Console.ReadKey();
        }

    }
    
}
