using Bogus;
using FluentAssertions;
using Moq;
using RocketSeatAuction.API.Communication.Resquest;
using RocketSeatAuction.API.Contracts;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Services;
using RocketSeatAuction.API.UseCases.Auctions.GetCurrent;
using RocketSeatAuction.API.UseCases.Offers.CreateOffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UseCases.Test.Offer;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Success(int itemId)
    {
        //Arrange
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(r => r.Price, f => f.Random.Number(1, 500)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggerUser = new Mock<ILoggedUser>();
        loggerUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggerUser.Object, offerRepository.Object);

        //Act
        var act = () => useCase.Execute(itemId, request);

        //Assert
        act.Should().NotThrow();

    }
}
