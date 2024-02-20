using AutoMapper;
using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using ControleEmpresa.Data.Dtos.SetorDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Profiles
{
    public class FuncionarioProfile:Profile
    {
        public FuncionarioProfile()
        {
            CreateMap<CreateFuncionarioDto, Funcionario>();
            CreateMap<Funcionario, ReadFuncionarioDto>();
        }
    }
}
