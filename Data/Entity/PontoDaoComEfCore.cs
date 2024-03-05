using AutoMapper;
using ControleEmpresa.Data.Dtos.PontoDTO;
using ControleEmpresa.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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
            if (!VerificaSeJaEntrou(dto.FuncionarioId))
            {
                var ponto = _mapper.Map<Ponto>(dto);
                _dbContext.Pontos.Add(ponto);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<ReadPontoDto> LerPontosDeUmFuncPorId(int id)
        {
            var pontos = _dbContext.Pontos.Where(i => i.FuncionarioId == id).ToList();
            var pontoDto = _mapper.Map<List<ReadPontoDto>>(pontos);
            return pontoDto;
        }

        public IEnumerable<ReadPontoDto> LerTodosPontos()
        {
            var pontos = _dbContext.Pontos.Include(f=>f.Funcionario).ToList();
            var pontosDto = _mapper.Map<List<ReadPontoDto>>(pontos);
            return pontosDto;
        }

        public void Saida(CreatePontoDto funcId)
        {

            var ponto = _dbContext.Pontos.FirstOrDefault(func=>func.FuncionarioId == funcId.FuncionarioId && func.Saida==null);
            ponto.Saida = DateTime.Now.TimeOfDay;
            _dbContext.Pontos.Update(ponto);
            _dbContext.SaveChanges();
        }

        public bool VerificaSeJaEntrou(int id)
        {
            var pontos = _dbContext.Pontos.Where(p=>p.FuncionarioId==id);
            var temp = false;
            foreach (var ponto in pontos)
            {
                if (ponto.Saida == null)
                {
                    temp = true;
                }
            }
            return temp;
        }
    }
}
