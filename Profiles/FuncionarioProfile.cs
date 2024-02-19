using AutoMapper;
using ControleEmpresa.Data.Dtos.Funcionario;
using ControleEmpresa.Models;

namespace ControleEmpresa.Profiles
{
    public class FuncionarioProfile:Profile
    {
        public FuncionarioProfile()
        {
            CreateMap<CreateFuncionarioDto, Funcionario>();
        }
    }
}
