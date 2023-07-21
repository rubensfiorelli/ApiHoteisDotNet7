using System.ComponentModel.DataAnnotations;

namespace HoteisAPI.Data.Dtos
{
    public class ReadHotelDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto ReadEnderecoDto { get; set; }


    }
}
