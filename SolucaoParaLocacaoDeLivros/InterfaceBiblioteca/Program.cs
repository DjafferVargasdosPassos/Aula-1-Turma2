using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        //Instanciamos "Carregamos para a memoria" nosso controlador usuario , livros
        static UsuarioController usuario = new UsuarioController();
        static LivrosController livros = new LivrosController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");

            while (!RealizaLoginSistema())
            {
                Console.WriteLine("Login e senha inválidos");
            }
            MostraMenuSistema();

            Console.ReadKey();
            
        }
        /// <summary>
        /// Mostra no console o menu disponivel no sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("----SISTEMA DE LOCAÇÃO DE LIVROS 1.0----\r\n");
                Console.WriteLine(" -----------Meu sistema-----------\r\n");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Escolher Livro");
                Console.WriteLine("4 - Trocar usuário");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("0 - Sair");


                //aqui pega o numero digitado e executa na proxima função
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());


                switch (opcao)
                {
                    case 1:
                        {
                            // realiza a chamada o menu de listagem de usuarios
                            Console.Clear();
                            MostrarUsuarios();
                        }
                        break;

                    case 2:
                        {

                            MostrarLivro();
                            // Livro livro = new Livro()
                            //{
                            //   Nome = "puta que pariu"
                            // };
                            // Console.Clear();
                            //Console.WriteLine(livro.Nome);
                        }
                        break;

                    case 3:
                        {

                        }
                        break;

                    case 4:
                        {
                            while (!RealizaLoginSistema())
                            {
                                Console.WriteLine("Login e senha inválidos");
                            }
                           
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Metodo para mostrar a lista de usuario ja cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            usuario.ListaDeUsuarios.ForEach(i => Console.WriteLine(i.Login));
            Console.ReadKey();
        }
        private static void MostrarLivro()
        {
            livros.Livros.ForEach(i => Console.WriteLine($"Meu livro é {i.Nome}"));
           // Livro livro = new Livro()
            //{
              //  Nome = "PQP"
            //};

            //Console.WriteLine($"Meu livro é {livro.Nome}");

        }
        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do sistema
        /// como solicitação de login e senha pelo console assim como as respectivas
        /// validações que o mesmooprecisa para entrar no sistema 
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiveres corretos</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
            Console.WriteLine("Informe seu login e senha para acessar:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();//se utlizar a outra forma nao vai essas 3 linhas
            usuario.Login = loginDoUsuario;//
            usuario.Senha = loginDoUsuario;//

            return usuarioController.LoginSistema(usuario);

            //outra forma de fazer
            //return usuarioController.LoginSistema(new Usuario()
            //{
            //    Login = loginDoUsuario,
            //    Senha = senhaDoUsuario
            // });
        }
      
    }
}


