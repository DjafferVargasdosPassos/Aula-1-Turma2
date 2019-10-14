using AlunosEntit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosEntit.Controller
{
    public class AlunoController
    {
        EntityContextDb contextDb = new EntityContextDb();
    

        public IQueryable<Aluno> GetAlunos()
        {
            return contextDb.ListaDeAlunos;
        }
        public void AddAluno(Aluno item)
        {
            contextDb.ListaDeAlunos.Add(item);
            contextDb.SaveChanges();
        }
    }
}
