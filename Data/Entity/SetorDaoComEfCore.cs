using AutoMapper;
using ControleEmpresa.Data.Dtos.SetorDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data.Entity
{
    public class SetorDaoComEfCore : ISetorDao
    {
        AppDbContext _context;
        IMapper _mapper;

        public SetorDaoComEfCore(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Criar(CreateSetorDto dto)
        {
            var setor = _mapper.Map<Setor>(dto);
            _context.Setores.Add(setor);
            _context.SaveChanges();
        }

        public IEnumerable<ReadSetorDto> LerTodosSetores()
        {
            return _mapper.Map<IEnumerable<ReadSetorDto>>(_context.Setores.ToList());
        }
    }
}
