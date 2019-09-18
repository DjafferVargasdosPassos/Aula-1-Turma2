using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Metodo para retornar a area do quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">lado do quadrado</param>
        /// <returns>Retorna a area tota do quadrado</returns>
        public double CalculaAreaDoQuadrado(int ladoDoQuadrado)
        {
            return ladoDoQuadrado ^ 2;
        }
    }
}
