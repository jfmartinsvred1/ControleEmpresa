using AutoMapper;
using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using ControleEmpresa.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmpresa.Data.Entity
{
    public class FuncionarioDaoComEfCore : IFuncionarioDao
    {
        AppDbContext _context;
        IMapper _mapper;

        public FuncionarioDaoComEfCore(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Criar(CreateFuncionarioDto dto)
        {
            var func = _mapper.Map<Funcionario>(dto);
            _context.Funcionarios.Add(func);
            _context.SaveChanges();
        }
        public void DeletarFuncionario(int id)
        {
            var funcionario = _mapper.Map<Funcionario>(_context.Funcionarios.FirstOrDefault(i=>i.FuncionarioId==id));
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }

        public IEnumerable<ReadFuncionarioDto> LerFuncionariosPorSetor(string setor)
        {
            return _mapper.Map<IEnumerable<ReadFuncionarioDto>>(_context.Funcionarios.Include(s => s.Setor).Where(s=>s.Setor.Nome==setor));
        }

        public ReadFuncionarioDto LerFuncionarioUnico(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(i => i.FuncionarioId == id);
            return _mapper.Map<ReadFuncionarioDto>(funcionario);
        }

        public IEnumerable<ReadFuncionarioDto> LerTodosFuncionarios()
        {
            var func = _context.Funcionarios.Include(p => p.Pontos).Include(s => s.Setor).ToList();
            var funcsDto = _mapper.Map<List<ReadFuncionarioDto>>(func);
            return funcsDto;
        }
        public TimeSpan HorarioMedioDeEntrada(int id)
        {
            var pontos = _context.Pontos.Where(i=>i.FuncionarioId==id).ToList();
            int horas = 0;
            int min = 0;
            foreach (var ponto in pontos)
            {
                horas += ponto.Entrada.Hours;
                min += ponto.Entrada.Minutes;

            }
            horas /= pontos.Count();
            min /= pontos.Count();
            string minS = $"{min}";
            if (min < 10)
            {
                minS = $"0" + min;
            }


            string horaCompleta = $"{horas}:{minS}";
            
            TimeSpan time = new TimeSpan(horas,int.Parse(minS),0);
            return time;
        }
    }
}
