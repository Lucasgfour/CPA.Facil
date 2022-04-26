using CPA.Facil.Data.Commom;
using CPA.Facil.Data.Model;
using CPA.Facil.Data.Rules.Validation;
using CPA.Facil.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace CPA.Facil.Application.Web.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionarioController : ControllerBase {

        [Route("id/{id}")]
        [Authorize]
        [HttpGet]
        public Resultado Consult([FromRoute] int id) {

            var UserLogadoID = int.Parse(HttpContext.User.Identity.Name.ToString());

            return new Resultado(true, "OK", QuestionarioService.Consult(id, UserLogadoID));

        }

        [Authorize]
        [HttpPost]
        public Resultado Insert([FromBody] Questionario questionario) {

            var UserLogadoID = int.Parse(HttpContext.User.Identity.Name.ToString());

            questionario.instituicao_id = UserLogadoID;

            QuestionarioService.Insert(questionario);

            return new Resultado(true, "Inserido com sucesso.");

        }

    }
}
