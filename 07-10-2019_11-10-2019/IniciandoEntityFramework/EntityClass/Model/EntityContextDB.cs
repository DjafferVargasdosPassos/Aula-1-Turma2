using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext // DbContext Classe pronta que contem todo o processo de conexão com o banco de dados listagem 
        //das tabelas seleção das informações 
    {
        public DbSet// Palavra resrvada para o Entity que indica que vamos definir uma tabela do nosso banco de dados 
            <Pessoa>// Aqui definimos nossa tabela de pessoa
            //ou seja especificamos qual de nossas classe sera uma referencia de uma tabela no banco d dados
            //ela vai no banco com o nome que definimos em noosa classe
            ListaDePessoas { get; set; } // nesta parte liberamos nossa tabela para acessar

    }
}
