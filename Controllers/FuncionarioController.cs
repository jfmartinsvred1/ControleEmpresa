using ControleEmpresa.Data;
using ControleEmpresa.Data.Dtos.Funcionario;
using Microsoft.AspNetCore.Mvc;

namespace ControleEmpresa.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class FuncionarioController:ControllerBase
    {
        IFuncionarioDao _funcionarioDao;

        public FuncionarioController(IFuncionarioDao funcionarioDao)
        {
            _funcionarioDao = funcionarioDao;
        }

        [HttpPost]
        public IActionResult AdicionarFuncionario([FromBody]CreateFuncionarioDto dto)
        {
            _funcionarioDao.Criar(dto);
            return NoContent();
        }
    }
}
