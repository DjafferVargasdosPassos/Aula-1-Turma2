using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe publica
    public class Cerveja
    {
        
        [Key]// Aqui apertei CTRL. quando o [Key](chave primaria) apresentou erro para abrir sugestoes usei
        //'using System.ComponentModel.DataAnnotations;'
        public int Id { get; set; }

        //Aqui definimos a quantidade maxima de caracteres para nosso campo "Nome" dentro do banco 
        [StringLength(50)]
        [Required]//Identifica que este campo é obrigatório = NOT NULL No DB
        public string Nome { get; set; }

        [StringLength(30)] // Tamanho maimo de caracteres para o tipo
        public string Tipo { get; set; }
        public double Teor { get; set; }

    }
}
