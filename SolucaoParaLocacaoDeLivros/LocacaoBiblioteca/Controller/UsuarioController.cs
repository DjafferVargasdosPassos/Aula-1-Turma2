using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{/// <summary>
/// Classe que contem os metodos de usuários do sistema
/// </summary>
    public class UsuarioController
    {
        //Criando privado para impedri o programador de adicionar um ID ou alterar fora da classe
        private int IdContador = 0;

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// Login: Admin
        /// Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome de Usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando exixtir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
            
            // if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
               // return true;
           // else
               // return false;
        }
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario()
            {
                //aiciona o id contador incrementando o mesmi com ele + 1 "++"
                Id = IdContador ++,
                Login = "Djaffer",
                Senha = "111"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContador ++,
                Login = "admin",
                Senha = "admin"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "Admin",
                Senha = "Admin"
            });
        }
        private List<Usuario> ListaDeUsuarios { get; set; }
        /// <summary>
        /// Metodo para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="usuario">novo usuario que sera adicionado a lista</param>

        public void AdicionarUsuario(Usuario usuario)
            
        {
            usuario.Id = IdContador++;
            //adiciono o meu usuario na minha lista
            ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metoo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somnte a lisat de usuarios ativos com a expressão "Where(x=> x.Ativo)"
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que sera desativado</param>
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //Aqui usamos o metodo 'FirstOrDefault' para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }
}
