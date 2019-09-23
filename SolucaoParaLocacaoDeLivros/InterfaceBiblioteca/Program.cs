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
        static UsuarioController usuarioController = new UsuarioController();
        static LivrosController livrosController = new LivrosController();

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
                Console.WriteLine(" 1 - Listar usuários");
                Console.WriteLine(" 2 - Listar Livro");
                Console.WriteLine(" 3 - Cadastrar Livro");
                Console.WriteLine(" 4 - Cadastrar usuário");
                Console.WriteLine(" 5 - Remover usuário");
                Console.WriteLine(" 6 - Trocar usuário");                               
                Console.WriteLine(" 0 - Sair");


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
                            AdicionarLivro();
                        }
                        break;

                    case 4:
                        {
                            AdicionarUsuario();
                        }
                        break;

                    case 5:
                        {

                            RemoverUsuarioPeloID();
                        }
                        break;
                    case 6:
                        {
                            while (!RealizaLoginSistema())
                            {
                                Console.WriteLine("Login e senha inválidos");
                            }
                            Console.WriteLine(" Login e senha inválidos");
                           
                        }
                        break;
                                                                    
                    default:
                        break;
                }
            }
        }
        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine(" Remover um usuário peli id no sistema");
            // Metodo que mosra os usuarios criados anteriormente
            MostrarUsuarios();
            Console.WriteLine("Informe o ID para desativar do sistema:");
            var usuarioID =int.Parse(Console.ReadLine());

            //Aqui chamamos RemoverUsuarioPorID da nossa classe que controla os usuarios do sistema
            usuarioController.RemoverUsuarioPorId(usuarioID);

            Console.WriteLine(" Usuário desativado com sucesso!");
            Console.ReadKey();
        }
        private static void AdicionarUsuario()
        {
            Console.WriteLine(" Informe login do usuário para cadastro:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine(" Cadastre uma senha para o usuario:");
            var senhaDeAcesso = Console.ReadLine();
            var senhaDoUsuario = Console.ReadLine();

            usuarioController.AdicionarUsuario(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDeAcesso
            });
            Console.WriteLine(" Usuário cadastrado com sucesso!");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmoo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar Livro dentro do sistema:");
            //Informamos que para dar continuidade ele deve informar o nome de um livro
            Console.WriteLine("Nome do livro para cadastro");
            //Obtemos essa infrmação do ususario
            var nomeDoLivro = Console.ReadLine();
            //"livrosController" livros controle e nosso "objeto" em memória
            //COmm isso temos disponivel nele ferramentas que nos ajud a realizar as tarefas
            //como adicionar um item a nossa lista de Livros
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui atribuimos o nome que demos ao livro na propriedade Nome de nosso livro
                //com o sina de apenas um "=" temos atribuição, passagem de valor
                Nome = nomeDoLivro 
            });
            //Indico que finalizamos o processo de cadastro deo livro, assim o usuario ja sabe 
            //que o mesmo foi realizado sem erros
            Console.WriteLine(" Livro cadastrado com sucesso!");
            //ReadKey apenas para que ele visualize esta informação
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para mostrar a lista de usuario ja cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            Console.Clear();
            Console.WriteLine("Lista de usuários\r\n");
            usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($" Id:{i.Id}, Login usuário:{i.Login}"));
            Console.ReadKey();
        }
        private static void MostrarLivro()
        {
            Console.Clear();
            Console.WriteLine(" Lista de Livros:\r\n");
            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($" Id: {i.Id}, Nome do livro é: {i.Nome}"));
            Console.ReadKey();
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

           // UsuarioController usuarioController = new UsuarioController();

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


