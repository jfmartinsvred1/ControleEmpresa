using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data
{
    public interface IFuncionarioDao
    {
        void Criar(CreateFuncionarioDto dto);
        IEnumerable<ReadFuncionarioDto> LerTodosFuncionarios();
        IEnumerable<Funcionario> LerFuncionariosPorSetor();
        Funcionario LerFuncionarioUnico(int id);
        void DeletarFuncionario(DeleteFuncionarioDTo dto);
    }
}
