using AutoMapper;
using ControleEmpresa.Data.Dtos.PontoDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data.Entity
{
    public class PontoDaoComEfCore : IPontoDao
    {
        IMapper _mapper;
        AppDbContext _dbContext;

        public PontoDaoComEfCore(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public void Entrada(CreatePontoDto dto)
        {
            var ponto = _mapper.Map<Ponto>(dto);
            _dbContext.Pontos.Add(ponto);
            _dbContext.SaveChanges();
        }

        public void Saida(int funcId)
        {
            var ponto = _dbContext.Pontos.FirstOrDefault(func=>func.FuncId == funcId && func.Dia == DateTime.Today);
            ponto.Saida = DateTime.Now;
            _dbContext.Pontos.Update(ponto);
            _dbContext.SaveChanges();
        }
    }
}
