using BHF.MS.DirectDebit.Models;
using BHF.MS.DirectDebit.Services;
using Microsoft.AspNetCore.Mvc;

namespace BHF.MS.DirectDebit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectDebitController(ILogger<DirectDebitController> logger, IExampleService service) : ControllerBase
    {
        [HttpGet]
        [ResponseCache(VaryByQueryKeys = ["*"], Duration = 60)]
        public async Task<IActionResult> Get()
        {
            var response = await service.GetSomething();

            // Logger messages should be formatted like so to avoid CA2254 warnings. Please avoid concatenation and interpolation.
            logger.LogWarning("Responses {Response} are invalid!", response);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ExampleModel requestModel)
        {
            var response = await service.PostSomething(requestModel);

            // Logger messages should be formatted like so to avoid CA2254 warnings. Please avoid concatenation and interpolation.
            logger.LogWarning("Responses {Response} are invalid!", response);

            return Ok();
        }
    }
}
