using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiWebImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        MigrationContext db = new MigrationContext();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuário já existente em nossa base de dados");

                if (value.ToString().Contains("Djaffer"))
                    return new ValidationResult("Não é possível registrar nome!")
            }                      

            if (validationContext.DisplayName == "DataDeNascimento")
            {
                var data = DateTime.Parse(value.ToString());

                if (data >= DateTime.Now.AddYears(-18))
                    return new ValidationResult("Não é possivel cadastrar pessoas menores de idade");

                if (data <= DateTime.Now.AddYears(-150))
                    return new ValidationResult("Não é possivel cadastrar pessoas maiores de 150 anos");
            }            
                return ValidationResult.Success;
        }
    }
}