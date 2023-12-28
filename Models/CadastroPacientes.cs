using System.ComponentModel.DataAnnotations;

namespace CadastroPacientes.Models
{

    public enum TipoConsulta {
        PRESENCIAL,
        REMOTA,
    }

    public enum DiaRecorrencia {
        SEGUNDA,
        TERÇA,
        QUARTA,
        QUINTA,
        SEXTA
    }


    public class CadastroPacientes
    {

        public int Id {get; set;}
        public string? Nome { get; set; }

        public int Idade { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? NotaObservacao { get; set; }

        [EnumDataType(typeof(TipoConsulta))]
        public string? TipoConsulta { get; set; }

        public decimal ValorConsulta { get; set; }

        [EnumDataType(typeof(DiaRecorrencia))]
        public string? DiaRecorrencia { get; set; }
    }
}