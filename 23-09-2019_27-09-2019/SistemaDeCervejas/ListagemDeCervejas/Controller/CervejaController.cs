using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.MODEL;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
            SistemaCervejaContext cervejaContext = new SistemaCervejaContext();
           
            /// <summary>
            /// Metodo que retorna lista de cerveja completa
            /// </summary>
            /// <returns>retorna a lista</returns>
            public List<Cerveja> GetCervejas()
            {
                return cervejaContext.ListaDeCervejas;
            }
            /// <summary>
            /// Metodo que permite adicionar cervejas em nossa lista passando um objeto de cerveja como parametro
            /// </summary>
            /// <param name="c">objeto de cerveja a ser informado pelo usuario</param>
            public void AdicionarCervejas(Cerveja c)
            {
                var novoId = cervejaContext.ListaDeCervejas.Count;
                c.Id = novoId + 1;
                cervejaContext.ListaDeCervejas.Add(c);
            }
            /// <summary>
            /// metodo que soma valores contidos na nossa lista
            /// </summary>
            /// <returns>valor total da nossa lista</returns>
            public double ValorTotal()
            {
                return cervejaContext.ListaDeCervejas.Sum(x => x.Valor);
            }
        /// <summary>
        /// Metodo que retorna valor total de litros em nossa lista 
        /// </summary>
        /// <returns>retornamos o valor total em litros</returns>
            public double ValorTotalEmLitros()
            {
                return cervejaContext.ListaDeCervejas.Sum(x => x.Litros);
            }
        }
    }
