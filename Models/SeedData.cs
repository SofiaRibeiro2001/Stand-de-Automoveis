using Microsoft.EntityFrameworkCore;
using MvcViaturas.Data;

namespace MvcViaturas.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcViaturasContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcViaturasContext>>()))
            {
                if (context.Viatura.Any())
                {
                    return;
                }
                context.Viatura.AddRange(
                    new Viatura
                    {
                        Marca = "Volvo",
                        Modelo = "XC40",
                        Cor = "Preto",
                        Cilindrada = 1000,
                        Ano = 2021,
                        Mes = 05,
                        Tipo = "Suv",
                        Preco = 35955.00M,
                        ForPgto = "Prestações"

                    },
                    new Viatura
                    {
                        Marca = "Corsa",
                        Modelo = "Opel",
                        Cor = "Preto",
                        Cilindrada = 500,
                        Ano = 2008,
                        Mes = 07,
                        Tipo = "Ligeiro",
                        Preco = 8110.00M,
                        ForPgto = "Prestações"

                    },
                    new Viatura
                    {
                        Marca = "Mercedes-Benz",
                        Modelo = "Sprinter",
                        Cor = "Branco",
                        Cilindrada = 300,
                        Ano = 2005,
                        Mes = 11,
                        Tipo = "Carrinha",
                        Preco = 11594.00M,
                        ForPgto = "Prestações"

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
