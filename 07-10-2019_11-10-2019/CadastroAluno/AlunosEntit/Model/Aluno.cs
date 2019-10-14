using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosEntit.Model
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
    }
}
