using ControleEmpresa.Data.Dtos.Funcionario;

namespace ControleEmpresa.Data
{
    public interface IFuncionarioDao
    {
        void Criar(CreateFuncionarioDto dto);
    }
}
