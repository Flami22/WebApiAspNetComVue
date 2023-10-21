using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Model.EnderecoCliente

{
    [Table("enderecoCliente")]
    public class EnderecoCliente
    {
        [Key]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string ClienteId { get; set; }
    }
}