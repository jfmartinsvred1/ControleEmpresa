using AutoMapper;
using ControleEmpresa.Data.Dtos.Ponto;
using ControleEmpresa.Models;

namespace ControleEmpresa.Profiles
{
    public class PontoProfile:Profile
    {
        public PontoProfile()
        {
            CreateMap<CreatePontoDto, Ponto>();

        }
    }
}
