using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaDeCarros.Model;

namespace SystemaDeCarros
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Carros> listaCarros = new List<Carros>();

            Carros c1 = new Carros();
            c1.Marca = "Porsche";
            c1.Modelo = "Cayenne";
            c1.Ano = 2010;
            c1.Valor = 500;

            listaCarros.Add(c1);

            Carros c2 = new Carros();
            c2.Marca = "VW";
            c2.Modelo = "Golf Gti";
            c2.Ano = 2018;
            c2.Valor = 120000;

            listaCarros.Add(c2);

            Carros c3 = new Carros();
            c3.Marca = "Renault";
            c3.Modelo = "Logan";
            c3.Ano = 2015;
            c3.Valor = 35500;

            listaCarros.Add(c3);

            foreach (Carros item in listaCarros)
            {
                Console.WriteLine(item.Marca + item.Modelo +)
            }

        }


    }
}
