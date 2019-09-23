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
        private int IdContador = 0;
        public LivrosController()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = " Meu Primeiro Livro"
            });

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = " Meu Segundo Livro"
            });
        }
        private List<Livro> Livros { get; set; }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já !instamciada criada dentro do construtor
        /// </summary>
        /// <param name="parametrolivro">Informações que vamos adiconar em nossa lista</param>
        public void AdicionarLivro(Livro parametrolivro)
        {
            parametrolivro.Id = IdContador++;
            //Adiciona o livro em nossa lista.
            Livros.Add(parametrolivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return Livros;
        }
        public void RemoverLivroPorId(int identificadoID)
        {
            
        }
            
    }
}
