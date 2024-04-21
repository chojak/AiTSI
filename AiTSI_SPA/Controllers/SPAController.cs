using Microsoft.AspNetCore.Mvc;
using Parser.Models;

namespace AiTSI_SPA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SPAController : ControllerBase
    {
        // tutaj ustawimy jakies statyczne potrzebne properties tak aby wszystko dzialalo elegancko
        private static string albercik = "albercik";
        //]

        [HttpPost("[action]")]
        public ActionResult<string> ProcedureToParse(string input)
        {
            albercik = "input";
            return Ok("super");
        }

        [HttpPost("[action]")]
        public ActionResult<string> ProcedureToParse_FromFile(IFormFile file)
        {
            albercik = "testowy_Albercik";
            return Ok("super");
        }

        [HttpPost("[action]")]
        public ActionResult<string> QueryToParse()
        {
            return Ok("super");
        }

        [HttpPost("[action]")]
        public ActionResult<string> QueryToParse_FromFile(IFormFile file)
        {
            return Ok("super");
        }
    }
}
