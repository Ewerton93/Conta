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

        private readonly IBancoRepositorio _bancoRepositorio;

        public ContaBancariaController(IContaBancariaRepositorio contaBancariaRepositorio, IBancoRepositorio bancoRepositorio)
        {
            _contaBancariaRepositorio = contaBancariaRepositorio;
            _bancoRepositorio = bancoRepositorio;
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

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult Get(long id)
        {
            try
            {
               var conta = _contaBancariaRepositorio.ObterPorId(id);
               return Ok(conta);
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

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Put(long id, [FromBody] ContaBancaria contaBancaria)
        {
            try
            {
                var conta = _contaBancariaRepositorio.ObterPorId(id);
                
                conta.Atualizar(contaBancaria.Banco, contaBancaria.NumeroConta, contaBancaria.NumeroAgencia, contaBancaria.Cpf, contaBancaria.Nome, contaBancaria.Cnpj, contaBancaria.RazaoSocial);
                
                _contaBancariaRepositorio.Atualizar(conta);
                
                return Ok(contaBancaria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("{id}/ativar")]
        [Authorize]
        public IActionResult Ativar(long id)
        {
            try
            {
                var conta = _contaBancariaRepositorio.ObterPorId(id);

                conta.SetAtivar();

                _contaBancariaRepositorio.Adicionar(conta);

                return Ok(conta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("{id}/inativar")]
        [Authorize]
        public IActionResult Inativar(long id)
        {
            try
            {
                var conta = _contaBancariaRepositorio.ObterPorId(id);

                conta.SetInativar();

                _contaBancariaRepositorio.Adicionar(conta);

                return Ok(conta);
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
