using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Filters;
using RocketSeatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketSeatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class AuctionController : RocketSeatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {     
        var result = useCase.Execute();

        if (result is null)
            return NoContent();
 
        return Ok(result);
    }

}