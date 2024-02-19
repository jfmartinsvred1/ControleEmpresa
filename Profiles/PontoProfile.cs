using AutoMapper;
using ControleEmpresa.Data.Dtos.PontoDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Profiles
{
    public class PontoProfile:Profile
    {
        public PontoProfile()
        {
            CreateMap<CreatePontoDto, Ponto>();
            CreateMap<Ponto, ReadPontoDto>();
            CreateMap<Ponto, ReadPonto_FuncionarioDto>();

        }
    }
}
