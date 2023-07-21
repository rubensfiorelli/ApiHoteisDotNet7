﻿using System.ComponentModel.DataAnnotations;

namespace HoteisAPI.Models
{
    public class Hospede
    {
        [Required(ErrorMessage ="Preencha todos os campos!")]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set;}
        [Required]
        public long CPF { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set;}
        [Required]
        public string Telefone { get; set; }
        [Key]
        [Required]
        public int id { get; internal set; }


    }
}
