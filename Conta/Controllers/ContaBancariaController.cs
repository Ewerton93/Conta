using Conta.Dados.Intefarce;
using Conta.Dominio.Entidade;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Conta.WebApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ContaBancariaController : ControllerBase
    {
        private readonly IContaBancariaRepositorio _contaBancariaRepositorio;
        public ContaBancariaController(IContaBancariaRepositorio contaBancariaRepositorio)
        {
            _contaBancariaRepositorio = contaBancariaRepositorio;
        }

        [HttpGet]
        [Authorize]
        public ActionResult Get()
        {
            try
            {
                var retorno = Ok(_contaBancariaRepositorio.ObterTodos());     
                return retorno;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpGet("id")]
        [Authorize]
        public ActionResult Get(long id)
        {
            try
            {
               var banco = _contaBancariaRepositorio.ObterPorId(id);

                return Ok(banco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ContaBancaria contaBancaria)
        {
            try
            {
                _contaBancariaRepositorio.Adicionar(contaBancaria);
                return Ok(contaBancaria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Authorize]
        public IActionResult Put([FromBody] ContaBancaria contaBancaria)
        {
            try
            {
                _contaBancariaRepositorio.Atualizar(contaBancaria);
                return Ok(contaBancaria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Authorize]
        public IActionResult Delete([FromBody] ContaBancaria contaBancaria)
        {
            try
            {
                _contaBancariaRepositorio.Remover(contaBancaria);
                return Ok(contaBancaria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
