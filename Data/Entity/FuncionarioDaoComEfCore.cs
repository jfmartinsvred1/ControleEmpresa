using AutoMapper;
using ControleEmpresa.Data.Dtos.Funcionario;
using ControleEmpresa.Models;

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
    }
}
