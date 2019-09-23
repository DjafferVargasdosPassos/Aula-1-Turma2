using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region codando muito
            var cestaDeFrutas = new List<Fruta>();
            #region carregando minha cesta
            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            #endregion

            #region Lista 1
            //Neste ponto ordemos os valores de forma decrescente pelo nome
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($" Id {i.Id} Nome: {i.Nome}"));
            #endregion

            Console.WriteLine("------------------------------------");

            #region Lista 2
            //aqui ordemos os valores pelo Id de forma crescente
            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($" Id {i.Id} Nome: {i.Nome}"));
            Console.ReadKey();
            #endregion

            Console.WriteLine("------------------------------------Filtro Peso");

            #region Lista 3
            //aqui filtramos os registros maiores de 100gr
            var filtroCesta = cestaDeFrutas.Where(X => X.Peso > 100)
                //ordemos estes valores pelo nome ' linha seguinte continua atras da linha anterior
                .OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Peso}"));

            //frutinha recebe cada fruta de nossa cesta
            (from frutinha in cestaDeFrutas //<- aqui temos coleção de frutas
             where frutinha.Peso >= 100 
             select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($" Fruta escolhida {i.Nome}"));
            #endregion

            Console.WriteLine("------------------------------------Filtro Cores");

            //aqui criamos uma variavel que recebera o valor buscado
            var mostrandoFind = cestaDeFrutas.// continua a linha no (Find)
                //aqui é feito o filtro das informações por uma "ou --> || <--" outra cor
                Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            
            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");

            //aqui criamos uma variavel que recebera a coleção que estamos buscando
            var mostrandoFindAll = cestaDeFrutas.//continua com o FindAll
             //FindAll com esta condição tras frutas de cor amarela "ou" vermelhas   
                FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            //imrpimo com a função do Foreach do linq   
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome { i.Nome}"));
            //Aqui ordemos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //como agora ele não é mais um List<Fruta> usamos o ForEach para apresenar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");

            Console.WriteLine("------------------------------------Find com order by");

            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");
            Console.ReadKey();
            #endregion
        }
    }
}

