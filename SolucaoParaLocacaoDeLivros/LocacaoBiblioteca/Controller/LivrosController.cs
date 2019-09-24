using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        
        public LivrosController()
        {
        
        }
        private List<Livro> Livros { get; set; }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já !instamciada criada dentro do construtor
        /// </summary>
        /// <param name="parametrolivro">Informações que vamos adiconar em nossa lista</param>
        public void AdicionarLivro(Livro parametrolivro)
        {
            parametrolivro.Id = contextDB.IdContadorLivros++;
            //Adiciona o livro em nossa lista.
            contextDB.Livros.Add(parametrolivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {           
            return contextDB.Livros.Where(x => x.Ativo).ToList<Livro>();
        }
        /// <summary>
        /// Metodo para desativar o registro do livro pelo ID
        /// </summary>
        /// <param name="identificadoID"></param>
        public void RemoverLivroPorId(int identificadoID)
        {
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == identificadoID);

            if (livro != null)
                livro.Ativo = false;
           
        }
            
    }
}
