using WebApi.Domain.DTOs;
using WebApi.Domain.Model.EmployeeAggregate;

namespace WebApi.Infraestrutura.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Cliente employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(b =>
                new EmployeeDTO()
                {
                    Id = b.id,
                    NameEmployee = b.name,
                    Photo = b.photo
                }).ToList();
        }

        public Cliente ? Get(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
