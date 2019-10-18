using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }
        private static void MenuSistema()
        {
            
            Console.WriteLine("Escolha uma das opções do menu");
            Console.WriteLine("1 - Calculo da área");
            Console.WriteLine("2 - Mostrar árvore");
            Console.WriteLine("3 - Listar Cervejas");
            Console.WriteLine("4 - Listar Carros");
            Console.WriteLine("5 - Sair do sistema");


            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                    break;

                case 2:
                    {
                        MinhaArvore.MostraArvore();
                        MenuSistema();
                    }
                    break;

                case 3:
                    {
                        ListaDeCervejas.ListaDeCerveja();
                        MenuSistema();

                    }
                    break;

                case 4:
                    {
                        ListaDeCarros.ListaDeCarro();
                        MenuSistema();
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }
                default:
                    break;
                    

            }
            
        }
        public static void CalculaArea()
        {
            Console.WriteLine("Informar do lado do quadrado");
            var ladoDoQuadrado = int.Parse(Console.ReadLine());
            var bibliotecaDeCalculos = new CalculosDeArea();
            Console.WriteLine($"A área do quaddrado é {bibliotecaDeCalculos.CalculaAreaDoQuadrado(ladoDoQuadrado)}");
        }

    }
}
