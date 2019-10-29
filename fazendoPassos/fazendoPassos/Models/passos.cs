using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fazendoPassos.Models
{
    public class passos
    { 
        [Key]
        public int id { get; set; }
        public string Pp { get; set; }
    }
}