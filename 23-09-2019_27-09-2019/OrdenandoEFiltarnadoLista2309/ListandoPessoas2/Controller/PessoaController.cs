using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Model;


namespace ListandoPessoas2.Controller
{
    class PessoaController
    {
        /// <summary>
        /// lista que contem as pessoas para realizar as atividades
        /// </summary>
        private List<Pessoa> listaDePessoas { get; set; }
        /// <summary>
        /// o metodo construtor ajuda a iniciar nossa para utilizarmos a lista
        /// </summary>
        public PessoaController()
        {
            listaDePessoas = new List<Pessoa>();

            listaDePessoas.Add(new Pessoa(1 , "Spears"  ,  DateTime.Parse("07/11/2004"),846.96));
            listaDePessoas.Add(new Pessoa(2 , "Swanson  ", DateTime.Parse("20/06/2003"),233.09));
            listaDePessoas.Add(new Pessoa(3 , "Gay      ", DateTime.Parse("03/12/2001"),911.92));
            listaDePessoas.Add(new Pessoa(4 , "Gregory  ", DateTime.Parse("02/01/2000"),469.01));
            listaDePessoas.Add(new Pessoa(5 , "Olson    ", DateTime.Parse("18/07/2001"),261.90));
            listaDePessoas.Add(new Pessoa(6 , "Garza    ", DateTime.Parse("01/04/2000"),360.41));
            listaDePessoas.Add(new Pessoa(7 , "Sweet    ", DateTime.Parse("12/03/2003"),312.76));
            listaDePessoas.Add(new Pessoa(8 , "Cline    ", DateTime.Parse("26/03/2002"),484.51));
            listaDePessoas.Add(new Pessoa(9 , "Oliver  ",  DateTime.Parse("05/07/2004"),513.76));
            listaDePessoas.Add(new Pessoa(10, "Vang     ", DateTime.Parse("10/07/2000"),271.05));
            listaDePessoas.Add(new Pessoa(11, "Maddox   ", DateTime.Parse("29/05/2004"),783.97));
            listaDePessoas.Add(new Pessoa(12, "Garrett  ", DateTime.Parse("03/06/2006"),154.11));
            listaDePessoas.Add(new Pessoa(13, "Mcintosh ", DateTime.Parse("06/07/2006"),902.80));
            listaDePessoas.Add(new Pessoa(14, "Yang     ", DateTime.Parse("29/04/2005"),550.48));
            listaDePessoas.Add(new Pessoa(15, "Hendricks", DateTime.Parse("05/09/2003"),410.56));
            listaDePessoas.Add(new Pessoa(16, "Cain     ", DateTime.Parse("12/01/2002"),221.13));
            listaDePessoas.Add(new Pessoa(17, "Blackburn", DateTime.Parse("10/05/2000"),135.67));
            listaDePessoas.Add(new Pessoa(18, "Howe     ", DateTime.Parse("27/09/2005"),360.14));
            listaDePessoas.Add(new Pessoa(19, "Pratt    ", DateTime.Parse("18/09/2000"),991.83));
            listaDePessoas.Add(new Pessoa(20, "Sherman  ", DateTime.Parse("20/02/2003"),667.00));
        }                                   
        /// <summary>
        /// Temos uma propriedade que retorna nossa lista
        /// com essa propriedade temos a lista completa e sem regras
        /// da lista de pessoas, mas ao liberar somente o "GET"
        /// não damos acesso para alterar fora da classe a lista apenas visualização
        /// </summary>
        public List<Pessoa> ListaDePessoasPublica
        {
            //No get podemos retornar propriedades privadas e calculo de metodos quando necessa´rio
            get { return listaDePessoas; }
        }
        /// <summary>
        /// metodo que retorna nossa lista de pessoas ordenada de forma Asc pelo nome de cada uma 
        /// </summary>
        /// <returns>Retormas o valor ja ordenada de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadaAsc()
        {
            //aqui temos nossa lista
            return listaDePessoas
                //Aqui ordenamos ela, Ienurrable é novo tipo dela durante a conversão 
                .OrderBy(x => x.Nome)
                //Aqui voltamos o tipo para a lista de pessoas
                .ToList<Pessoa>();
        }
        /// <summary>
        /// metodo publico que retorna a lista ordenada pela data de nascimento da maior para amenor data
        /// </summary>
        /// <returns>lista ordenada</returns>
        public List<Pessoa> GetPessoasOrdenadaDescPelaDataNascimento()
        {
            return listaDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo que retorna as pessoas com determinado valor dentro da carteira
        /// </summary>
        /// <param name="valor">Valor informado para o filtro
        /// caso não informado o parametro o valor padrão se torna 500</param>
        /// <returns>Retorna a lista com valor definido e ordenado</returns>
        public List<Pessoa> GetPessoasComMaisPilaNaCarteira(double valor = 500)
        {
            return listaDePessoas
                //Realizamos o filtro de busca
                .FindAll(x => x.Carteira > valor)
                //Ordenamos as informações
                .OrderBy(x => x.Carteira)
                //Convertemos para uma lista do tipo pessoa
                .ToList<Pessoa>();
        }
        /// <summary>
        /// metodo que retorna a lista de pessaoas com idade maior que idade informada,
        /// caso não informado um valor padrão seria 18
        /// </summary>
        /// <param name="idade">Idade que vamos usar para comparar</param>
        /// <returns>Retorna a lista de pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasComIdadeMaiorA(int idade = 18)
        {
            return listaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= idade);
        }
        /// <summary>
        /// Metodo que retorna idade menor que idade informada por parametro
        /// caso parametro nao informado o valor padrão é 16
        /// </summary>
        /// <param name="idade">parametro de idade</param>
        /// <returns>retorna alista apenas com os valores</returns>
        public List<Pessoa> GetPessoasComIdadeMenorQue(int idade = 16)
        {
            return listaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) <= idade);
        }
    }
}
