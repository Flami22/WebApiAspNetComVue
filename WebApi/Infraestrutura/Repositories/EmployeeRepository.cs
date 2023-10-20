using WebApi.Domain.DTOs;
using WebApi.Domain.Model.Cliente;

namespace WebApi.Infraestrutura.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public List<ClientesDTO> Get(int pageNumber, int pageQuantity)
        {
            return _context.Clientes.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(b =>
                new ClienteDTO()
                {
                    Id = b.id,
                    NomeCliente = b.name,
                    Photo = b.photo
                }).ToList();
        }

        public Cliente ? Get(int id)
        {
            return _context.Clientes.Find(id);
        }
    }
}
