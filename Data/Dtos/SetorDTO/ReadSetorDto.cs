using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data.Dtos.SetorDTO
{
    public class ReadSetorDto
    {
        public string? Nome { get; set; }
        public virtual ICollection<ReadFuncionarioDto>? Funcionarios { get; set; }
    }
}
