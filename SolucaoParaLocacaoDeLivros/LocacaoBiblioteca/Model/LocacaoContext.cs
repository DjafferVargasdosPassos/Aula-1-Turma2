using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext        
    {
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;
        /// <summary>
        /// Metodo que prepara nossa classe locacaoContext
        /// </summary>
        public LocacaoContext()
        {
            //criamos uma lista de livros em memoria
            Livros = new List<Livro>();
            //criamos uma lista de usuarios em memoria
            ListaDeUsuarios = new List<Usuario>();

            //adicionamos os livros
            Livros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = " Meu Primeiro Livro"
            });
            Livros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = " Meu Segundo Livro"
            });
            Livros.Add(new Livro()
            {
             Id = IdContadorLivros++,
             Nome = "Guia do mochileiro das galaxias 'Pika'"
            });

            //adicionamos o usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });
        }
        public List<Livro> Livros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
             
    }
}
