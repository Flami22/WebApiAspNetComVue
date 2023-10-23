using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Model.Cliente
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public string email { get; private set; }
        public string password { get; private set;}
        public string? photo { get; private set; }
        public string cpf {get; private set;}
        public string data_nascimento {get; private set;}
        public datetime createdAt { get; private set;}
        public datetime updatedAt { get; private set;}
        public bool ativo { get; private set; }
        public List<ClienteEndereco> enderecos { get; private set; }

        public Cliente (string name, string email, string password, string photo, string cpf, string data_nascimento)
        {   
            this.name = name ?? throw new ArgumentNullException(nameof(name))
            this.email = email;
            this.password = password;
            this.photo = photo;
            this.cpf = cpf;
            this.data_nascimento = data_nascimento;
            this.createdAt = datetime.now;
            this.updatedAt = datetime.now;
            this.ativo = true
            this.enderecos = new List<ClienteEndereco>()
        }
    }
}
