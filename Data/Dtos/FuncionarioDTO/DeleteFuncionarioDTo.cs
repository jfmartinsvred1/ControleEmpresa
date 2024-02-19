using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Data.Dtos.FuncionarioDTO
{
    public class DeleteFuncionarioDTo
    {
        [Key]
        public int FuncId { get; set; }
    }
}
