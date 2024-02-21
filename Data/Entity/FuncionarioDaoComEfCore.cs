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
    }
}
