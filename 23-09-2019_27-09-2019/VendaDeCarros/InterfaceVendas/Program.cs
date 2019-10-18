using InterfaceVendas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        private static void MostraListaDeCarros()
        {
           
        }
        private static void MostraMenuSistema()
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("----SISTEMA DE VENDAS----\r\n");
                Console.WriteLine(" -----------Meu sistema de vendas-----------\r\n");
                Console.WriteLine(" 1 - Listar informações dos carros");
                Console.WriteLine(" 2 - Gerar relatório");
                Console.WriteLine(" 0 - Sair");


                //aqui pega o numero digitado e executa na proxima função
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());


                switch (opcao)
                {
                    case 1:
                        {
                         

                        }
                        break;

                    case 2:
                        {


                        }
                        break;
                }
            }
        }
    }
}