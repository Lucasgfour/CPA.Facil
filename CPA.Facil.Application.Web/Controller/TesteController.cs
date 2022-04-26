using CPA.Facil.Data.Model;
using CPA.Facil.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPA.Facil.Application.Web.Controller {
    [Route("api/teste")]
    [ApiController]
    public class TesteController : ControllerBase {

        [Route("token/{id}")]
        [HttpGet]
        public String ChamarMetodoTeste([FromRoute]int id) {

            Instituicao a = new Instituicao();
            a.email = "";
            a.id = id;

            String Token = UserAuthentication.NewToken(a);

            return Token;


        }

    }
}
