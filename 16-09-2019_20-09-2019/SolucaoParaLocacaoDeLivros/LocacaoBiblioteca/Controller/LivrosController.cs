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
                    
        //Inserir        
        public void AdicionarLivro(Livro item)
        {            
            //Adiciona o livro em nossa lista.
            contextDB.Livros.Add(item);
            contextDB.SaveChanges();
                                    
        }
        //Atualizar
        public bool AtualizarLivro(Livro item)
        {
            var livro = // Definimos uma variavel para o celular
           contextDB // ussamos o banco de dados
           .Livros // Nossa tabela que tem os celulares
           .FirstOrDefault // buscamos em nossa tabela o celular
           (x => x.Id == item.Id); // regra para realizar a busca

            //falmos que nosso celular da tabela vai ser igual nosso celular que estamos passando
            if (livro == null) // verificamos se ele realmente encontrou um celular
                return false; // caso não tenha encontrado retornamos falso
            else
            {
                item.DataAlteracao = DateTime.Now; // atualizamos a data da alteração do nosso celular
            }
            contextDB.SaveChanges();// salvamos a informação no banco
       
            return true;
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
            contextDB.SaveChanges();
                       
        }
        //listagem
        public IQueryable<Livro> GetLivros()
        {
            return contextDB // nosso acesso ao banco de dados
                .Livros // mostra tabela do banco de dados 
                .Where(x => x.Ativo == true);
        }

    }
}
