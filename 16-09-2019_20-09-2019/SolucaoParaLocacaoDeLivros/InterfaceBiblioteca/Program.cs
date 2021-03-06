﻿using System;
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
       // static UsuarioController usuarioController = new UsuarioController();
        static LivrosController livros = new LivrosController();
        /*static UsuarioController usuarios = new UsuarioController();*/

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");

            /*while (!RealizaLoginSistema())
            {
                Console.WriteLine("Login e senha inválidos");
            }*/
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
                /* Console.WriteLine(" 1 - Listar usuários");*/
                /* Console.WriteLine(" 2 - Cadastrar usuário");
                Console.WriteLine(" 3 - Remover usuário");
                Console.WriteLine(" 4 - Trocar usuário");*/
                Console.WriteLine(" 1 - Listar Livro");
                Console.WriteLine(" 2 - Adicionar Livro");
                Console.WriteLine(" 3 - Atualizar Livro");
                Console.WriteLine(" 4 - Remover Livro");                                            
                Console.WriteLine(" 0 - Sair");


                //aqui pega o numero digitado e executa na proxima função
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());


                switch (opcao)
                {


                    /* case 2:
                         {

                             MostrarLivro();
                             // Livro livro = new Livro()
                             //{
                             //   Nome = "puta que pariu"
                             // };
                             // Console.Clear();
                             //Console.WriteLine(livro.Nome);
                         }
                         break;*/

                    #region
                    /* case 5:
                         {
                             AdicionarUsuario();
                         }
                         break;*/

                    /* case 6:
                         {

                             RemoverUsuarioPeloID();
                         }
                         break;*/
                    /*case 7:
                        {
                            while (!RealizaLoginSistema())
                            {
                                Console.WriteLine("Login e senha inválidos");
                            }
                            Console.WriteLine(" Login e senha inválidos");
                           
                        }
                        break;*/
                    #endregion

                    case 1:
                        {
                            // realiza a chamada o menu de livros
                            Console.Clear();
                            MostrarLivro();
                        }
                        break;

                    case 2:
                        {
                            AdicionarLivro();
                        }
                        break;

                    case 3:
                        {
                            AtualizarLivro();
                        }
                        break;

                    case 4:
                        {
                            RemoverLivroPeloID();
                        }
                        break;

                    case 0:
                        opcao = 0;
                        Console.WriteLine("Saindo do Sistema...");
                        break;
                  
                    default:
                        break;
                }
            }
        }
        #region codigo usuario
        /// <summary>
        /// Metodo que realiza a remoção do livro no sistema
        /// </summary>

        /// <summary>
        /// metodo que remove ousuario pelo Id informado
        /// </summary>
        /* private static void RemoverUsuarioPeloID()
         {
             Console.WriteLine(" Remover um usuário pelo id no sistema");
             // Metodo que mosra os usuarios criados anteriormente
             MostrarUsuarios();
             Console.WriteLine("Informe o ID para desativar do sistema:");
             var usuarioID =int.Parse(Console.ReadLine());

             //Aqui chamamos RemoverUsuarioPorID da nossa classe que controla os usuarios do sistema
             usuarioController.RemoverUsuarioPorId(usuarioID);

             Console.WriteLine(" Usuário desativado com sucesso!");
             Console.ReadKey();
         }*/
        /* private static void AdicionarUsuario()
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

         }*/
        #endregion
        private static void AdicionarLivro()
        {
            Console.Clear();
            //Identificamos que o mesmoo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar Livro dentro do sistema:");
            //Informamos que para dar continuidade ele deve informar o nome de um livro
            Console.WriteLine("Nome do livro para cadastro");
            //Obtemos essa infrmação do ususario
            var nomeDoLivro = Console.ReadLine();
            //"livrosController" livros controle e nosso "objeto" em memória
            //COmm isso temos disponivel nele ferramentas que nos ajud a realizar as tarefas
            //como adicionar um item a nossa lista de Livros
            livros.AdicionarLivro(new Livro()
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
        public static void AtualizarLivro()
        {
            Console.Clear();
            Console.WriteLine("--Atualizar Livro--");

            MostrarLivro();

            Console.WriteLine("Informe o Id para alteração de registro");// Informamos ao usuario para colocar o Id para realizar a alteração
            var livroId = int.Parse(Console.ReadLine());//obtemos o Id informado

            var livro = livros.GetLivros().FirstOrDefault(x => x.Id == livroId);

            if (livro == null)
            {
                Console.WriteLine("Id informado inválido");
                Console.ReadKey();
                Console.WriteLine("Aperte qualquer tecla para repetir a operação");
                return;
            }

            Console.WriteLine("Informe o Nome do livro");
            livro.Nome = Console.ReadLine();
                       
            var resultado = livros.AtualizarLivro(livro);

            if (resultado)
                Console.WriteLine("Livro atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar Livro");

            Console.ReadKey();

        }
        private static void RemoverLivroPeloID()
        {
            Console.Clear();
            Console.WriteLine("--Remover um livro pelo id cadastrado no sistema");

            MostrarLivro();

            Console.WriteLine("  Informe o Id do livro a ser removido da sua lista");
            var livroID = int.Parse(Console.ReadLine());
            livros.RemoverLivroPorId(livroID);
         

            Console.WriteLine(" Livro removido com sucesso!");
            Console.ReadKey();
        }
                   

        private static void MostrarLivro()
        {
            Console.Clear();
            Console.WriteLine(" Lista de Livros:\r\n");
            livros.GetLivros().ToList<Livro>().ForEach(i => Console.WriteLine($" Id: {i.Id}, Nome do livro é: {i.Nome}"));
            Console.ReadKey();
                     
        }

        #region codigo login
        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do sistema
        /// como solicitação de login e senha pelo console assim como as respectivas
        /// validações que o mesmooprecisa para entrar no sistema 
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiveres corretos</returns>
        /* private static bool RealizaLoginSistema()
          {
              Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
              Console.WriteLine("Informe seu login e senha para acessar:");

              Console.WriteLine("Login:");
              var loginDoUsuario = Console.ReadLine();

              Console.WriteLine("Senha");
              var senhaDoUsuario = Console.ReadLine();

             // UsuarioController usuarioController = new UsuarioController();


              //outra forma de fazer
              return usuarios.(new Usuario()
              {
                Login = loginDoUsuario,
                  Senha = senhaDoUsuario
               });*/
        #endregion

    }
}


