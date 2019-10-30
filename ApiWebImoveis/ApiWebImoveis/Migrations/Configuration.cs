namespace ApiWebImoveis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiWebImoveis.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ApiWebImoveis.Models.MigrationContext";
        }

        protected override void Seed(ApiWebImoveis.Models.MigrationContext context)
        {
            context.Proprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario()
            {
                Nome = "Djaffer",
                DataDeNascimento = DateTime.Parse("10/11/1987"),
                Email = "djaffervargas@gmail.com"

            });

            context.SaveChanges();

            var ProprietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Djaffer").Id;

            context.Imoveis.AddOrUpdate(x => x.ProprietarioId, new Models.Imovel()
            {
                Cep = "89020070",
                Logradouro = "Manaus",
                Bairro = "Garcia",
                Municipio = "Blumenau",
                Numero = 115,
                Complemento = "casa",
                ProprietarioId = ProprietarioId
            });

            context.SaveChanges();
        }
    }
}
