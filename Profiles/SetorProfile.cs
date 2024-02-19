using AutoMapper;
using ControleEmpresa.Data.Dtos.Setor;
using ControleEmpresa.Models;

namespace ControleEmpresa.Profiles
{
    public class SetorProfile:Profile
    {
        public SetorProfile()
        {
            CreateMap<CreateSetorDto, Setor>();
        }
    }
}
