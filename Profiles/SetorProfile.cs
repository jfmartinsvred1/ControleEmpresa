using AutoMapper;
using ControleEmpresa.Data.Dtos.SetorDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Profiles
{
    public class SetorProfile:Profile
    {
        public SetorProfile()
        {
            CreateMap<CreateSetorDto, Setor>();
            CreateMap<Setor, ReadSetor_FuncionarioDto>();
            CreateMap<Setor, ReadSetorDto>();
        }
    }
}
