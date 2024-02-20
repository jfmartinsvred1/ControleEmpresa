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

        public void DeletarFuncionario(DeleteFuncionarioDTo dto)
        {
            var func = _context.Funcionarios.FirstOrDefault(id => id.FuncionarioId == dto.FuncionarioId);
            _context.Funcionarios.Remove(func);
            _context.SaveChanges();
        }

        public IEnumerable<Funcionario> LerFuncionariosPorSetor()
        {
            throw new NotImplementedException();
        }

        public Funcionario LerFuncionarioUnico(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReadFuncionarioDto> LerTodosFuncionarios()
        {
            var func = _context.Funcionarios.Include(p => p.Pontos).Include(s => s.Setor).ToList();
            var funcsDto = _mapper.Map<List<ReadFuncionarioDto>>(func);
            return funcsDto;
        }
    }
}
