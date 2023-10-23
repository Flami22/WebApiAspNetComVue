namespace WebApi.Application.InputModel
{
    public class ClienteInputModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Data_nascimento { get; set; }
        public List<EnderecoContato> Enderecos { get; set; }
        public IFormFile Photo { get; set; }
    }
}
