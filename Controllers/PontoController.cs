using ControleEmpresa.Data;
using ControleEmpresa.Data.Dtos.PontoDTO;
using Microsoft.AspNetCore.Mvc;

namespace ControleEmpresa.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PontoController:ControllerBase
    {
        IPontoDao _pontoDao;

        public PontoController(IPontoDao pontoDao)
        {
            _pontoDao = pontoDao;
        }
        [HttpPost("Entrada")]
        public IActionResult Entrada(CreatePontoDto dto)
        {
            _pontoDao.Entrada(dto);
            return NoContent();
        }
        [HttpPost("Saida")]
        public IActionResult Saida(int id)
        {
            _pontoDao.Saida(id);
            return NoContent();
        }
        [HttpGet]
        public IEnumerable<ReadPontoDto> GetAll()
        {
            return _pontoDao.LerTodosPontos();

        }
        [HttpGet("PorId")]
        public IEnumerable<ReadPontoDto> GetPorId(int id)
        {
            return _pontoDao.LerPontosDeUmFuncPorId(id);
        }
        [HttpGet("string")]
        public string get(int id)
        {
            return _pontoDao.DiaDaSemana(id);
        }
    }
}
