using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data.Dtos.PontoDTO

{
    public class ReadPontoDto
    {
        public DateTime Dia { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public int FuncId { get; set; }
        public virtual ReadFuncionarioDto? Funcionario { get; set; }
    }
}
