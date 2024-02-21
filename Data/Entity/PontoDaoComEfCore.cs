using AutoMapper;
using ControleEmpresa.Data.Dtos.PontoDTO;
using ControleEmpresa.Filters.Pontos;
using ControleEmpresa.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmpresa.Data.Entity
{
    public class PontoDaoComEfCore : IPontoDao
    {
        IMapper _mapper;
        AppDbContext _dbContext;
        PontoFilter _filter;

        public PontoDaoComEfCore(IMapper mapper, AppDbContext dbContext, PontoFilter filter)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _filter = filter;
        }

        public void Entrada(CreatePontoDto dto)
        {
            if (_filter.VerificaSeNaoBateuPontoDeEntrada(dto.FuncionarioId))
            {
                var ponto = _mapper.Map<Ponto>(dto);
                _dbContext.Pontos.Add(ponto);
                _dbContext.SaveChanges();
            }
            
        }

        public IEnumerable<ReadPontoDto> ReadPonto()
        {
            var pontos = _dbContext.Pontos.Include(f=>f.Funcionario).ToList();
            var pontosDto = _mapper.Map<List<ReadPontoDto>>(pontos);
            return pontosDto;
        }

        public void Saida(int funcId)
        {
            var ponto = _dbContext.Pontos.FirstOrDefault(func=>func.FuncionarioId == funcId && func.Saida==null);
            ponto.Saida = DateTime.Now;
            _dbContext.Pontos.Update(ponto);
            _dbContext.SaveChanges();
        }
        
    }
}
