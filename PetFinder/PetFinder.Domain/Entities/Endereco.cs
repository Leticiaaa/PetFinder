using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    public class Endereco: ICamposPadrao
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Referencia { get; set; }
        public string EstadoId { get; set; }
        public string CidadeId { get; set; }
        public string PaisId { get; set; }
        public string Cep { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
