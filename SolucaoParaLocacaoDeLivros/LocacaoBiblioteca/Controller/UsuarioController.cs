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
                Login = "Djaffer",
                Senha = "111"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
            });
        }
        public List<Usuario> ListaDeUsuarios { get; set; }

    }
}
