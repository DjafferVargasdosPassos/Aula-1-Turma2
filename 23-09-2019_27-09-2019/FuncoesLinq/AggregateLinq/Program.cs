using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes
                //no Aggregate temos o nome atual que estamos lendo e o próximo nome da lista
                .Aggregate((nome1, nome2) => nome1 + ";" + nome2);
            //no passo seguinte temos o nome 'próximo vira o atual e pega o próximo da lista após o atual

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
