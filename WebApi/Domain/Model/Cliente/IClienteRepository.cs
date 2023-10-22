using WebApi.Domain.DTOs;

namespace WebApi.Domain.Model.Cliente
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);

        List<ClienteDTO> Get();
        Cliente ? Get(int id);
    }
}
