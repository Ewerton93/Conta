using Conta.Common.ViewModel.Entrada;
using Conta.Dados.Intefarce;
using Conta.Dominio.Entidade;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conta.WebApp.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoRepositorio _bancoRepositorio;
        public BancoController(IBancoRepositorio bancoRepositorio)
        {
            _bancoRepositorio = bancoRepositorio;
        }


        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var retorno = Ok(_bancoRepositorio.ObterTodos());     
                return retorno;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpGet("id")]
        public ActionResult Get(long id)
        {
            try
            {
               var banco =  _bancoRepositorio.ObterPorId(id);

                return Ok(banco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Banco banco)
        {
            try
            {
                _bancoRepositorio.Adicionar(banco);
                return Ok(banco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Banco banco)
        {
            try
            {
                _bancoRepositorio.Atualizar(banco);
                return Ok(banco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Banco banco)
        {
            try
            {
                _bancoRepositorio.Remover(banco);
                return Ok(banco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
