using Microsoft.AspNetCore.Mvc;
using Parser.Enums;
using Parser.Models;
using PKB;


namespace AiTSI_SPA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SPAController : ControllerBase
    {
        public static PKB.PKB Pkb = new PKB.PKB();

        [HttpPost("[action]")]
        public ActionResult<string> ProcedureToParse(string input)
        {
            Pkb = new PKB.PKB();
            var parser = new Parser.Models.Parser(Pkb);
            parser.Parse(input);

            return Ok(SPA.SPA.Parser.ProcedureToParse());
        }

        [HttpPost("[action]")]
        public ActionResult<string> ProcedureToParse_FromFile(IFormFile file)
        {
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                SPA.SPA.Parser.Parse(reader.ReadToEnd());
            }

            return Ok(SPA.SPA.Parser.ProcedureToParse());
        }

        [HttpPost("[action]")]
        public ActionResult<string> QueryToParse()
        {
            return Ok();
        }

        [HttpPost("[action]")]
        public ActionResult<string> QueryToParse_FromFile(IFormFile file)
        {
            return Ok();
        }
    }
}