using WebApi.Domain.DTOs;
using WebApi.Domain.Model.Cliente;

namespace WebApi.Infraestrutura.Repositories.ClienteRepository 
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public List<ClienteDTO> Get()
        {
            return _context.Cliente.ToList();
        }

        public Cliente ? Get(int id)
        {
            return _context.Cliente.include(c => c.enderecos).SingleOrDefault(id);
        }
    }
}
