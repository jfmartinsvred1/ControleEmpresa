using ControleEmpresa.Data.Dtos.PontoDTO;
using ControleEmpresa.Data.Dtos.SetorDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data.Dtos.FuncionarioDTO

{
    public class ReadFuncionarioDto
    {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ReadSetor_FuncionarioDto? Setor { get; set; }
        public virtual ICollection<ReadPonto_FuncionarioDto> Pontos { get; set; }
    }
}
