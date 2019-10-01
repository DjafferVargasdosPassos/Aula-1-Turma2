using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteirosPrimitivos();
            SomaInteirosLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra numeros inteiros do tipo primitivo
        /// </summary>
        private static void SomarInteirosPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção destes valores
            int[] colecoaInteiros =
             //alocamos memoria para a nossa coleção de valor e informamos a quantidade de memoria que vamos ocupar  
             //memoriaOcupada * quantidadeInformada
             new int[5] 
            //aqui carregamos nossa coleção de valores
            { 1,2,3,4,5 };

            //aqui somamos os valores em nossa lista
            Console.WriteLine(colecoaInteiros.Sum());
        }
        /// <summary>
        /// metodo que soma valoresde um em um na lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                //nossa coleção de valores
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma aquantidade de bala das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memoria
            List<Crianca> criancas = new List<Crianca>()
            {
                //criado uma nova criança dentro da minha lista
                new Crianca()
                {
                    Nome = "Joazinho",// neste caso apenas uma propriedade de outra
                    Balas = 9
                },// virgula separamos um objeto de outro
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };

            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda");
            Console.WriteLine(
                //Soma nossa quantidade de balas
                criancas.Sum(x => x.Balas));
        }
    }
}
