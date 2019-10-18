using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas2.Model
{
    public class Pessoa
    {
        public Pessoa(int cod, string nome, DateTime data, double carteira)
        {
            this.Id = cod;
            this.Nome = nome;
            this.DataNascimento = data;
            this.Carteira = carteira;

        }

    
     public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Carteira { get; set; }
}   }

