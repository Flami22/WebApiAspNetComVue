using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Model.ClienteEndereco

{
    [Table("clienteEndereco")]
    public class ClienteEndereco
    {
        [Key]
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public int ClienteId { get; private set; }

        public void ClienteEndereco (string logradoro, string numero, string cep, string complemento, int clienteId)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Cep = cep;
            this.Complemento = complemento;
            this.ClienteId = clienteId;
                
        }

    }
}
