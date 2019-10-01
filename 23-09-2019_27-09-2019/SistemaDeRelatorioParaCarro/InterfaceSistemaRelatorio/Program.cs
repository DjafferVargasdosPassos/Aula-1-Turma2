using SistemaRelatorioCarros.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));


            Console.ReadKey();
            MostraMenuRelatorio();

        }
        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(string.Format("Id {0,3} Carro {1,-35} Valor {2,-10} Quantidade {3,-3} Data {4,12}"
                , vendas.Id
                , vendas.Carro
                , vendas.Valor.ToString("C")
                , vendas.Quantidade
                , vendas.Data.ToShortDateString()));
        }
        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de relatorios");
            Console.WriteLine("1 - menu por periodo mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o fitro");
                            //obtemos a informação do mes
                            var mesEscolhido = int.Parse(Console.ReadLine());

                            var listaDoPeriodoEScolhido = vendasController.GetVendas(mesEscolhido);

                          
                                //aqui imprimimos as informações para o usuario
                                listaDoPeriodoEScolhido.ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaDoPeriodoEScolhido
                             //soma todos os registros multiplicando os valores de venda vezes a quantidade
                            .Sum(x => x.Valor * x.Quantidade);
                            //mostramos o mês escolhido e o valor total neste mês gerado

                            var mediaPeriodo = listaDoPeriodoEScolhido
                                //media de todos os registros multiplicando os valores de venda vezes a quantidade
                                .Average(x => x.Valor * x.Quantidade);
                            //mostramos o mes escolhido e o valor total do mês
                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");
                            // mostramos o mes escolhido e o valor médio de vendas no mes gerado
                            Console.WriteLine($"A média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                }
            }

        }

    }
} 

