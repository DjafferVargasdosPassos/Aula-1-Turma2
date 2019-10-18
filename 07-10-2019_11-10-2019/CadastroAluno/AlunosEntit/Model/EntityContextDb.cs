using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosEntit.Model
{
   public class EntityContextDb : DbContext
    {
        public DbSet<Aluno> ListaDeAlunos { get; set; }
    }
}
