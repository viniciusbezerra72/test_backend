using Locadora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora.data
{
    public class locacaoContext : DbContext
    {
        public DbSet<locacao> locacoes { get; set; }
        public DbSet<cliente> clientes { get; set; }
        public DbSet<filme> filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

    }
}