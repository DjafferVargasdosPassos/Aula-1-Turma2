using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaDeAmigoFixo.Model;

namespace SystemaDeAmigoFixo
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeAmigos = new List<Amigos>();

            listaDeAmigos.Add(new Amigos()
            {
                Nome = "Gian",
                TempoAmizade = 6
            });

            listaDeAmigos.Add(new Amigos()
            {
                Nome = "Varley",
                TempoAmizade = 2 
            });

            listaDeAmigos.Add(new Amigos()
            {
                Nome = "Fernando",
                TempoAmizade = 1
            });

            listaDeAmigos.ForEach(amigo => Console.WriteLine($"Nome{amigo.Nome} Quant {amigo.TempoAmizade}"));
            Console.ReadKey();
        }
       
    }
}     

