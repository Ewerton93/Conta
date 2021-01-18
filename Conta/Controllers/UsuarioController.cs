using Conta.WebApp.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Conta.WebApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Autenticacao([FromBody] User model)
        {
            var usuario = await Task.Run(() => UserRepositorio.Get(model.Email, model.Password));

            if (usuario == null)
            {
                return NotFound(new { message = "Usuario com e-mail e senha não encontrados" });
            }
            var token = TokenService.GenerateToken(usuario);
            usuario.Password = "";

            return Ok(new { user = usuario, token = token });
        }

        [HttpGet]
        [Route("anonimos")]
        [AllowAnonymous]
        public string Anonimos() => string.Format("Anônimo");

        [HttpGet]
        [Route("Autenticado")]
        [Authorize]
        public string Autenticado() => string.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("funcionario")]
        [Authorize(Roles = "gestor, funcionario")]
        public string Funcionario() => "funcionario";

        [HttpGet]
        [Route("gestor")]
        [Authorize(Roles = "gestor")]
        public string gestores() => "gestor";

    }
}
