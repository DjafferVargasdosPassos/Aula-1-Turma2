using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext : DbContext
    {
       // DbSet cria uma 'lista tabela' no banco de dados
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
