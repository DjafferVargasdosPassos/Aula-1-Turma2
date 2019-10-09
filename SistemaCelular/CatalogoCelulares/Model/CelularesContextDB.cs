using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class CelularesContextDB
        : // Definimos nossa herança
        DbContext // aqui definimos que vamos herdar toda a caixa de ferramentas do EntityFramework
    {
        //Definimos  nossa primeira tabela no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        // Definimos nossa tabela de celulares
        public DbSet<Celular> Celulares { get; set; }
    }
}
