using WebApi.Domain.DTOs;

namespace WebApi.Domain.Model.ClienteAggregate
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);

        List<ClienteDTO> Get(int pageNumber, int pageQuantity);
        Cliente ? Get(int id);
    }
}
