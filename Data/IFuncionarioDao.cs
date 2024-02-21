using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data
{
    public interface IFuncionarioDao
    {
        void Criar(CreateFuncionarioDto dto);
        IEnumerable<ReadFuncionarioDto> LerTodosFuncionarios();
        IEnumerable<ReadFuncionarioDto> LerFuncionariosPorSetor(string setor);
        ReadFuncionarioDto LerFuncionarioUnico(int id);
        void DeletarFuncionario(int id);
    }
}
