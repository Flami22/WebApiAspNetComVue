namespace WebApi.Application.ViewModel
{
    public class ClienteViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string cpf { get; set; }
        public string Data_nascimento { get; set; }
        public List<EnderecoContato> Enderecos { get; set; }
        public IFormFile Photo { get; set; }
    }
}

