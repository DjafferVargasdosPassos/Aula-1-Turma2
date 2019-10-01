using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaDeCarrosContext
    {
        public List<Carro> ListaDeCarros { get; set; }

        public SistemaDeCarrosContext()
        {
            List<Carro> ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Fiat", Modelo = "Palio" , Ano = 1998, Cilindradas = 1000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 2, Marca = "GM", Modelo = "VECTRA", Ano = 2010, Cilindradas = 2000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 3, Marca = "MERCEDES", Modelo = "CLA", Ano = 2016, Cilindradas = 2400, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 4, Marca = "BMW", Modelo = "X6", Ano = 2018, Cilindradas = 3200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 5, Marca = "HONDA", Modelo = "CIVIC", Ano = 2017, Cilindradas = 2000, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 6, Marca = "HYUNDAY", Modelo = "HB20", Ano = 2016, Cilindradas = 1000, Portas = 2 });
           
            
        }
    }
}
