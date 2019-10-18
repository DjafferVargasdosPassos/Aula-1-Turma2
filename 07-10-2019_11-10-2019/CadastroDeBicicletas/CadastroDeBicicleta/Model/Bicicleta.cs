using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeBicicleta.Model
{
    public class Bicicleta
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public String Marca { get; set; }
        [MaxLength(50)]
        [Required]
        public String Modelo { get; set; }
        [Required]
        public double Valor { get; set; }

    }
}
