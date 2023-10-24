namespace WebApi.Domain.DTOs
{
    public class ClienteEnderecoDTO
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set;}
        public string? Complemento { get; set; }
        public string Cpf { get; set;}
        public int ClienteId {get; set;}

    }
 }
