using Microsoft.EntityFrameworkCore;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Repositories;

namespace RocketSeatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new RocketSeatAuctionDbContext();

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .First(); 
              
    }
}
