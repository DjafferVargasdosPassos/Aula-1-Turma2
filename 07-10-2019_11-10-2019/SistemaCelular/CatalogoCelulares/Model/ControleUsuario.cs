using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class ControleUsuario
    {
        // Definimos o campo com valor default 'true' para nossos registros
        public bool Ativo { get; set; } = true;
        // Definimos 0 para o usuario criado pelo sistea sem usuario logado
        public int UsuarioCriacao { get; set; } = 0;
        // Definimos para a alteração do sistema quando não logado o usuario 0
        public int UsuarioAlteracao { get; set; } = 0;
        //Setemos nossa data de criação para data atual pela Classe DateTime
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;



    }
}
