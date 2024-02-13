﻿using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionsUseCase
{
    public Auction Execute()
    {
        var repository = new RocketseatAuctionDbContext();

        return repository.Auctions.First();
    }
}