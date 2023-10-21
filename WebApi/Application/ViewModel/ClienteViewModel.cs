namespace WebApi.Application.ViewModel
{
    public class ClienteViewModel
    {
        public string Name { get; set; }
        public int Email { get; set; }
        public List<EnderecoContato> Enderecos { get; set; }
        public IFormFile Photo { get; set; }
    }
}
