using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction() 
        {
            var useCase = new GetCurrentAuctionsUseCase();
            var result = useCase.Execute();

            return Ok(result);
        }

        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok("Teste!");
        }
    }
}
