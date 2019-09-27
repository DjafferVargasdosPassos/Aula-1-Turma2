using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate doc = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while(menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistem de pasta");
                Console.WriteLine("1 - Criar pasta em menu documentos");
                Console.WriteLine("2 - Deletar pasta nos meus documentos");
                Console.WriteLine("3 - Listar meus documentos");
                Console.WriteLine("4 - Sextou");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //informo pro usuario que ele devera informar um nome para a pasta
                        Console.WriteLine("Informe o nome da pasta:");
                        //Aqui obtemos o nome que ele digitou para a pasta dele
                        var nomePasta = Console.ReadLine();
                        //este metodo mostra na documentação e cria a pasta com base no nome que passamos
                        doc.CriarPastaMeusDocumentos(nomePasta);
                        break;

                    case 2:                        
                        Console.WriteLine("Informe o nome da pasta para excluir:");                       
                        var nomePastaD = Console.ReadLine();                       
                        doc.DeletarPastaMeusDocumentos(nomePastaD, true);
                        break;

                    case 3:
                        //obtemos a lista completa de pasta dentro dos meus documentos
                        doc.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                        break;

                    case 4:
                        new HoraDoShow().Birllllllllll();
                        break;
                }
            }
            //doc.CriarPastaMeusDocumentos("Djaffer");
            //doc.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));           
            //doc.DeletarPastaMeusDocumentos("",false);
            //doc.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
        }
    }
}
