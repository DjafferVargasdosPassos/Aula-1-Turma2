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
    /*public class UsuarioController
    {
        private LocacaoContext contextDB = new LocacaoContext();

        //listagem
        public IQueryable<Usuario> GetUsuarios()
        {
            return contextDB // nosso acesso ao banco de dados
                .Usuarios // mostra tabela do banco de dados 
                .Where(x => x.Ativo == true);
        }
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
            return contextDB.Usuarios.ToList().ForEach(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);

            if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
                return true;
            else
                return false;
        }
            
        public void AdicionarUsuario(Usuario usuario)
            
        {
            //adiciono o meu usuario na minha lista
            contextDB.Usuarios.Add(usuario);
        }
        /// <summary>
        /// Metoo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios</returns>
        public  List<Usuario> RetornaUsuarios()
        {
            //retorna agora somnte a lisat de usuarios ativos com a expressão "Where(x=> x.Ativo)"
            return contextDB.Usuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que sera desativado</param>
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //Aqui usamos o metodo 'FirstOrDefault' para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            contextDB.Usuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }*/
}
