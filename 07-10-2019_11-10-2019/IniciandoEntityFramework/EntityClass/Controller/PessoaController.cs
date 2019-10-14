using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        //Realizo minha conexão com o banco de dados
        EntityContextDB contextDb = new EntityContextDB();

        public 
            IQueryable//Aqui temos nossa primeira Interface com a classe 
            //IQueryable essa classe contem varios funcianalidades prontas para usar igual ao banco de dados com os selects
            <Pessoa> // definimos o tipo que ira retornar
            GetPessoas()//Damos um nome ao nosso metodo
        {
            return contextDb.ListaDePessoas;//retornamos nossa lista de pessoas
        }
        /// <summary>
        /// Metodo adicionar pessoas no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDb //nosso banco de dados
                .ListaDePessoas // nossa tabela de pessoas
                .Add(item); // adicionamos o item

            contextDb.SaveChanges(); // salvamos no banco
        }
    }
}
