using Microsoft.AspNetCore.Mvc;
using ServiceMocks.Contracts.Dtos;
using System;
using System.Threading.Tasks;

namespace ServiceMocks.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ImpostersController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ImposterDto imposter)
        {
            throw new NotImplementedException();
        }
    }
}