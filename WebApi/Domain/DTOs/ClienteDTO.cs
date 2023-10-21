namespace WebApi.Domain.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}
        public string? Photo { get; set; }
        public string Cpf {get; set;}
        public string Data_nascimento

    }
}
