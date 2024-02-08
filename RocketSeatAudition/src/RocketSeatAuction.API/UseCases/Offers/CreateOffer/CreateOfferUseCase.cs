using Microsoft.EntityFrameworkCore.Query;
using RocketSeatAuction.API.Communication.Resquest;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Repositories;
using RocketSeatAuction.API.Services;

namespace RocketSeatAuction.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;
    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new RocketSeatAuctionDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };

        repository.Offers.Add(offer);
        repository.SaveChanges();

        return offer.Id;
    }
}


