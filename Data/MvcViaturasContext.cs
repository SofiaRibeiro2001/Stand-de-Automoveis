using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcViaturas.Models;

namespace MvcViaturas.Data
{
    public class MvcViaturasContext : DbContext
    {
        public MvcViaturasContext (DbContextOptions<MvcViaturasContext> options)
            : base(options)
        {
        }

        public DbSet<MvcViaturas.Models.Viatura> Viatura { get; set; } = default!;

        public DbSet<MvcViaturas.Models.Funcionario>? Funcionario { get; set; }

        public DbSet<MvcViaturas.Models.Cliente>? Cliente { get; set; }
    }
}
