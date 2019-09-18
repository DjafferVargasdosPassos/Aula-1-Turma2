using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;


namespace AcessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }
        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Calculo de área:");
            Console.WriteLine("2 - Mostrar árvore");
            Console.WriteLine("3 - Lista de cervejas:");
            Console.WriteLine("4 - Lista de carros:");

            var opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    {
                        CalculandoAreaDoAmigo();
                        MenuSistema();
                    }
                    break;

                case 2:
                    {
                        arvoreDoAmigo();
                        MenuSistema();
                    }
                    break;

                case 3:
                    {
                        cervejaDoAmigo();
                        MenuSistema();
                    }
                    break;

                case 4:
                    {
                        carrosDoAmigo();
                        MenuSistema();
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine(" Saindo!!");
                        return;
                    }
                default:
                    break;
            }

        }
        private static void CalculandoAreaDoAmigo()
        {
            var dllDoAmigo = new MinhaBiblioteca.CalculosDeArea();
            Console.WriteLine(dllDoAmigo.CalculaAreaQuadrado(3));

        }
        private static void arvoreDoAmigo()
        {
            AnimacoesEmFrames.Arvore();
            Console.ReadKey();
        }
        private static void cervejaDoAmigo()
        {
            ListarCervejas.ListaCervejasME();
            Console.ReadKey();
        }
        private static void carrosDoAmigo()
        {
            ListarCarros.ListarCarrosMe();
            Console.ReadKey();
        }

    }
}
