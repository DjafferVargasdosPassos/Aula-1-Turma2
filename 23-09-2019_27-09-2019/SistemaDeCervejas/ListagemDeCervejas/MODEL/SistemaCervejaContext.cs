using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.MODEL
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaDeCervejas { get; set; }

        public SistemaCervejaContext()
        {
           ListaDeCervejas = new List<Cerveja>
            {
                new Cerveja() { Id = 1, Nome = "Skol", Litros = 0.35, Alcool = 4.7, Valor = 2.19 },           
                new Cerveja() { Id = 4, Nome = "Budweiser", Litros = 0.35, Alcool = 5.0, Valor = 2.50 },               
                new Cerveja() { Id = 6, Nome = "Corona", Litros = 0.55, Alcool = 5.2, Valor = 7.99 },               
                new Cerveja() { Id = 4, Nome = "Brahma", Litros = 0.6, Alcool = 5.0, Valor = 5.49 },
                new Cerveja() { Id = 5, Nome = "Original", Litros = 0.6, Alcool = 5.0, Valor = 5.50 },
            };

        }

    }
}
