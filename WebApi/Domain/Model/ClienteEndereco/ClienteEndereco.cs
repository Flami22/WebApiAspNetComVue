using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Model.ClienteEndereco

{
    [Table("clienteEndereco")]
    public class ClienteEndereco
    {
        [Key]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int ClienteId { get; set; }
    }
}
