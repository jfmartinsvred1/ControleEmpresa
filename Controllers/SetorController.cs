using ControleEmpresa.Data;
using ControleEmpresa.Data.Dtos.SetorDTO;
using Microsoft.AspNetCore.Mvc;

namespace ControleEmpresa.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class SetorController:ControllerBase
    {
        ISetorDao _setorDao;

        public SetorController(ISetorDao setorDao)
        {
            _setorDao = setorDao;
        }
        [HttpPost]
        public IActionResult AddSetor([FromBody] CreateSetorDto dto)
        {
            _setorDao.Criar(dto);
            return NoContent();
        }
        [HttpGet]
        public IEnumerable<ReadSetorDto> GetSetores() 
        {
            return _setorDao.LerTodosSetores();
        }
    }
}
