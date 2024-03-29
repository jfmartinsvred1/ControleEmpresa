﻿using ControleEmpresa.Data;
using ControleEmpresa.Data.Dtos.FuncionarioDTO;
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
        [HttpGet]
        public IEnumerable<ReadFuncionarioDto> ListarFuncionarios()
        {
            return _funcionarioDao.LerTodosFuncionarios();
        }

        [HttpGet("HoraMedia")]
        public IActionResult GetHoraMediaDeEntrada(int id)
        {
           return Ok( _funcionarioDao.HorarioMedioDeEntrada(id));
        }
        [HttpGet("id={id}")]
        public IActionResult DeletarFuncionario(int id)
        {
            _funcionarioDao.DeletarFuncionario(id);
            return NoContent();
        }
    }
}
