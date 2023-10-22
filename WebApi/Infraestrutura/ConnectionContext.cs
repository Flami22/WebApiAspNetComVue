using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Domain.Model.EnderecoCliente;
using WebApi.Domain.Model.Cliente;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }

        
        protected override void onModelCreating() {
            Builder.entity<Cliente>(
              e => 
              e.hasKey(c => c.Id)
              e.property(c => c.CreatedAt).columnName("dataCadastro")
              e.property(c => c.UpdatedAt).columnName("dataAtualizacao")
              e.property(c => c.data_nascimento).columnName("dataNascimento")
              e.hasMany( c => c.enderecos).hasForeignKey(ec => ec.clienteId)

            )
            Builder.entity<EnderecoCliente>(
                
                e => e.hasKey(ec => ec.Id)
            )
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=JhExpress;" +
              "User Id=root;" +
              "Password=12345678;");
    }
}
