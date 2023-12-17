using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Infra.Configuracao
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        { }
        
        public DbSet<Despesa> Despesa { get; set; }
        public DbSet<SistemaFinanceiro> SistemaFinanceiro { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ObterStringConexao(), Microsoft.EntityFrameworkCore
                .ServerVersion.Parse("8.0.34-mysql"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override  void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }

        public string ObterStringConexao()
        {
            return "server=localhost;port=3306;database=sistema_financeiro;uid=root;password=123456;Persist Security Info=false;Connect Timeout=300";
        }
    }
}
