using ControleFinanceiro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControleFinanceiro.DAO
{
    public class FinancasContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimentacao>().HasRequired(m => m.Usuario);
        }
    }
}