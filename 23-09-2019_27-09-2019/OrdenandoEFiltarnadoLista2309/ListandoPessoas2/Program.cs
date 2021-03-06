﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;
namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas
            //podemos agora listar e demias funcionalidades
            PessoaController pessoaController 
                //nesta parte ao iniciar em memória iniciamos o construtor
                = new PessoaController();

            //Aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoasPublica
                //usamos o ForEach do linq para percorrer a lista
                .ForEach(i => // criamos a variavel "i" para receber o item da nossa lista
                //Imprimimos a informação de cada item da nosa lista
                MostraInformacoes(i));

            MostraIdentificador("Lista ordenada por nome");

            pessoaController
                .GetPessoasOrdenadaAsc()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista ordenada por Data");

            pessoaController.GetPessoasOrdenadaDescPelaDataNascimento().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista ordenada pela carteira");

            pessoaController
                .GetPessoasComMaisPilaNaCarteira()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista maior de {18} anos");

            pessoaController
                .GetPessoasComIdadeMaiorA()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista menor de {16} anos");

            pessoaController
                .GetPessoasComIdadeMenorQue()
                .ForEach(i => MostraInformacoes(i));


            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para mostrar a informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">Identificador da listagem</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("---- {0,20} ----", nomeAcao));
        }
        /// <summary>
        /// metodo que mostra no console formatado nosso objeto "Pessoa"
        /// </summary>
        /// <param name="pessoa"></param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Nosso template que apresenta as informaçoes bonitinhas 
            // o format usa {0} essa expressão pode colocar de acordo com a ordem informada dos parametros
            string template = "Id {0,-3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}";
            //Recebemos as informções bonitinhas com o string format
            string textoFormatado =
                //string.Format e usado para formatar as string
                //deixando nosso texto padrao e apresentavel
                string.Format( 
                    //noso primeiro parametro é o template que usamos
                    template,
            //Apos inforamar o template, temos o parametro este metodo espera um array de parametros
            //ou seja, podemos passar muitos parametros nele
            pessoa.Id, 
            pessoa.Nome,
            //formatamos a data de nascimento para apresentar a informação reduziad
            pessoa.DataNascimento.ToShortDateString(),
            //aqui apresentamos em valor monetário de acrodo com as configurações local da maquina
            pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);
        }
    }
}
