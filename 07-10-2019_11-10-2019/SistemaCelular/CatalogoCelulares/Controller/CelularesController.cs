using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;


namespace CatalogoCelulares.Controller
{
    // usar nossa pasta model
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();
     //Listagem
     /// <summary>
     /// Metodo que retorna nossa lista de celulares ativos apenas
     /// </summary>
     /// <>returnsQueryList de celulares filtrando por ativo</returns>
     public IQueryable<Celular> GetCelulares()
        {
            return contextDB // nosso acesso ao banco de dados
                .Celulares // mostra tabela do banco de dados 
                .Where(x => x.Ativo == true); // as condições do filtro
        }
     //Atualização
     /// <summary>
     /// Metodo que atualiza um registro valido do nosso sistema
     /// </summary>
     /// <param name="item">Item que vamos atualizar</param>
     /// <returns>Retorna verdadeiro caso item exista</returns>
     public bool AtualizarCelular(Celular item)
        {
            var celular = // Definimos uma variavel para o celular
            contextDB // ussamos o banco de dados
            .Celulares // Nossa tabela que tem os celulares
            .FirstOrDefault // buscamos em nossa tabela o celular
            (x => x.Id == item.Id); // regra para realizar a busca

            //falmos que nosso celular da tabela vai ser igual nosso celular que estamos passando
            if (celular == null) // verificamos se ele realmente encontrou um celular
                return false; // caso não tenha encontrado retornamos falso
            else
            {
             item.DataAlteracao = DateTime.Now; // atualizamos a data da alteração do nosso celular
            }
            contextDB.SaveChanges();// salvamos a informação no banco

            return true;
        }
     //Inserção
     /// <summary>
     /// Metodo que valida e insere os registros dentro do sistema
     /// </summary>
     /// <param name="item">Nosso novo celular</param>
     /// <returns>Retorna verdadeiro para um item valido</returns>
     public bool InserirCelular(Celular item)
        {
            if (string // Nosso tipo que contem varios metodos prontos para string 
                .IsNullOrWhiteSpace // metod que identifica espaços em branco apenas ou valor null
                (item.Marca)) // cmpo que vamos validar
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0) // verificamos se o valor informado é menor que 0
                return false;

            contextDB.Celulares.Add(item);// salvamos item dentro da tabela em memoria 
            contextDB.SaveChanges();//salvo no banco

            return true;//retorna verdadeiro para indicar sucesso na inserção do registro
        }
     //'Remoção'
     /// <summary>
     /// Metodo utilizado apenas para desativar o item dentro do nosso sistema 
     /// </summary>
     /// <param name="id">Id que vamos desativar</param>
     /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
     public bool RemoverCelular(int id)
        {
            var celular = //nossa variavel
                contextDB // nossa base de dados
                .Celulares // tabela de celular
                .FirstOrDefault // buscamos o item para desativar
                (x => x.Id == id);// Informamos a regra de busca por Id

            if (celular == null)
                return false;

            celular.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }
    }
}
