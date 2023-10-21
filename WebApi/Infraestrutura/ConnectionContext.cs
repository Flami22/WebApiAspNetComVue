using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Domain.Model.CompanyAggregate;
using WebApi.Domain.Model.Cliente;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }

        
        protected override void onModelCreating() {
            Builder.entity<Cliente>(
              e => e.hasKey(c => c.Id)
            )
            Builder.entity<EnderecoCliente>(
                e => e.hasKey(ec => ec.Id)
            )
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=employee_sample;" +
              "User Id=postgres;" +
              "Password=123;");
    }
}
