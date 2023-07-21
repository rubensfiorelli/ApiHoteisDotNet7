using System.ComponentModel.DataAnnotations;

namespace HoteisAPI.Models
{
    public class Hotel
    {
        [Key]
        [Required]
        public int Id { get; set;}
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

    }
}
