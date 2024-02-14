using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuction.API.Comunication.Requests;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Enums;
using RocketseatAuction.API.Services;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;
using Xunit;

namespace UseCases.Test.Offers.CreateOffer;
public class CreateOfferUseCaseTest
{
    [Fact]
    public void Success()
    {
        // AAA
        // Arrange
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 1000)).Generate()

            ;
        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());
        var useCase = new CreateOfferUseCase(loggedUser.Object,offerRepository.Object);
        // Act
        var id = useCase.Execute(0,request);
        // Assert
       
    }
}
