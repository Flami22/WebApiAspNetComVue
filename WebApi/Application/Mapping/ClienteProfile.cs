using AutoMapper;
using WebApi.Domain.DTOs;
using WebApi.Domain.Model;

namespace WebApi.Application.Mapping
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile() 
        {
            CreateMap<Cliente, ClienteDTO>():
            CreateMap<ClienteEndereco, ClienteEnderecoDTO>();
                
        }
    }
}
