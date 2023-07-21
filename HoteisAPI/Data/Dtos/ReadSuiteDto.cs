using System.ComponentModel.DataAnnotations;

namespace HoteisAPI.Data.Dtos
{
    public class ReadSuiteDto
    {
        public int Id { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }


    }
}
