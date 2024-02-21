using ControleEmpresa.Data;
using ControleEmpresa.Data.Dtos.FuncionarioDTO;
using Microsoft.AspNetCore.Mvc;
using ControleEmpresa.Filters.Pontos;

namespace ControleEmpresa.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class FuncionarioController:ControllerBase
    {
        PontoFilter _pontoFilter;
        IFuncionarioDao _funcionarioDao;

        public FuncionarioController(IFuncionarioDao funcionarioDao, PontoFilter pontoFilter)
        {
            _funcionarioDao = funcionarioDao;
            _pontoFilter = pontoFilter;
        }

        [HttpPost]
        public IActionResult AdicionarFuncionario([FromBody]CreateFuncionarioDto dto)
        {
            _funcionarioDao.Criar(dto);
            return NoContent();
        }
        [HttpGet]
        public IEnumerable<ReadFuncionarioDto> ListarFuncionarios()
        {
            return _funcionarioDao.LerTodosFuncionarios();
        }
        [HttpGet("ghg")]
        public IActionResult GetTeste(int id)
        {
            return Ok(_pontoFilter.RetornaHorarioMedioDeEntrada(id));
        }
    }
}
