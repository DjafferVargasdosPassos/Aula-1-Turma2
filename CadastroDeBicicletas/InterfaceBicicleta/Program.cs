using CadastroDeBicicleta.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeBicicleta.Model;

namespace InterfaceBicicleta
{
    class Program
    {
        static BicicletaController bikes = new BicicletaController();

        static void Main(string[] args)
        {
            CadastroDeBike();
        }
        //inserir
        public static void CadastroDeBike()
        {
            Console.WriteLine("Cadastro de Bicicletas");
            Console.WriteLine("Informe a Marca da bicicleta:");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo da bicicleta cadastrada:");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor da bicicleta:");
            var valor = double.Parse(Console.ReadLine());

          bikes.InserirBike(new Bicicleta()
            {
                Marca = marca,
                Modelo = modelo,
                Valor = valor
            });

           /* if(resultado)
                Console.WriteLine("Bicicleta cadastrada com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar bicicleta!");*/
        }
    }

}
