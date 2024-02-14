using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionsUseCase
{
    private readonly IAuctionRepository _repository;
    public GetCurrentAuctionsUseCase(IAuctionRepository repository)
    {
        _repository = repository;
    }

    public Auction? Execute()
    {
       return  _repository.GetCurrent();
    }
}
