using Microsoft.AspNetCore.Mvc;
using Parser.Enums;
using Parser.Models;


namespace AiTSI_SPA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SPAController : ControllerBase
    {
        [HttpPost("[action]")]
        public ActionResult<string> ProcedureToParse(string input)
        {
            SPA.SPA.Parser.Parse(input);
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