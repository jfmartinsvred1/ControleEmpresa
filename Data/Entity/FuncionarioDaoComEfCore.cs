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
            var func = _context.Funcionarios.FirstOrDefault(id => id.FuncId == dto.FuncId);
            _context.Funcionarios.Remove(func);
            _context.SaveChanges();
        }

        public IEnumerable<ReadFuncionarioDto> LerFuncionariosPorSetor()
        {
            throw new NotImplementedException();
        }

        public ReadFuncionarioDto LerFuncionarioUnico(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReadFuncionarioDto> LerTodosFuncionarios()
        {
            var funcionarios = _context.Funcionarios.Include(s=>s.Setor).Include(s=>s.Pontos).ToList();
            var readFuncsDto = _mapper.Map<List<ReadFuncionarioDto>>(funcionarios);
            return readFuncsDto;
        }
    }
}
