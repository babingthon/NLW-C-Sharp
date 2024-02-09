using RocketSeatAuction.API.Contracts;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketSeatAuctionDbContext _dbContext;
    public OfferRepository(RocketSeatAuctionDbContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);
        _dbContext.SaveChanges();
    }
}
