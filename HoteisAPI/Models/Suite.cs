using System.ComponentModel.DataAnnotations;

namespace HoteisAPI.Models
{
    public class Suite
    {
        [Key]      
        [Required]
        public int Id { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }





    }
}
