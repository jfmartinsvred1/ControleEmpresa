using ControleEmpresa.Data.Dtos.SetorDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data.Dtos.FuncionarioDTO
{
    public class ReadFuncionarioDto
    {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataDeContratacao { get; set; }
        public ReadSetorDto? Setor { get; set; }
    }
}
