using System.ComponentModel.DataAnnotations;

namespace HoteisAPI.Data.Dtos
{
    public class ReadHospedeDto
    {
              
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public long CPF { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}
