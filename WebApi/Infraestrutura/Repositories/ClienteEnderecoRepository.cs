using WebApi.Domain.Model.Cliente;

namespace WebApi.Infraestrutura.Repositories.ClienteRepository 
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public List<ClienteEnderecoDTO> Get(int id)
        {
            return _context.ClienteEndereco.ToList();
        }
        
         public void AtualizarEndereco (ClienteEndereco clienteEndereco)
         {
         
             _context.ClienteEndereco.Update(ClienteEndereco clienteEndereco)
           
         }
        
        public void AddEndereco (ClienteEndereco clienteEndereco)
        {
            _context.ClienteEndereco.add(clienteEndereco);
            _context.SaveChanges();
        }

        public void DeletarEndereco (int id)
        {
          var endereco =  _context.ClienteEndereco.SingleOrDefault(id)
          _context.ClienteEndereco.Remove(endereco)
        }
    }
}
