using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Model.ClienteAggregate
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }
        public string? photo { get; private set; }
        public string cpf {get; private set;}
        public string data_nascimento {get; private set;}
        public datetime createdAt { get; private set;}
        public datetime updatedAt { get; private set;}
        public bool ativo { get; private set; }

        public Cliente (string name, int age, string photo, string cpf, string data_nascimento)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name))
            this.age = age;
            this.photo = photo;
            this.cpf = cpf;
            this.data_nascimento = data_nadata_nascimento
            this.createdAt = datetime.now;
            this.updatedAt = datetime.now;
            this.ativo = true
        }
    }
}
