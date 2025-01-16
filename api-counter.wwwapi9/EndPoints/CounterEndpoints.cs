using System;
using api_counter.wwwapi9.Repository;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_counter.wwwapi9.EndPoints;

public static class CounterEndpoints
{

    public static void ConfigureCounterEndpoints(this WebApplication app)
    {
        var counters = app.MapGroup("/counters");
        counters.MapGet("/", GetCounters);
        counters.MapGet("/{id}", GetCounter);
        counters.MapGet("/greaterthan/{value}", GetCountersGreaterThan);
        counters.MapGet("/lessthan/{value}", GetCountersLessThan);
        counters.MapPatch("/increasevalue/{id}", IncreaseValueOfCounter);
        counters.MapPatch("/decreasevalue/{id}", DecreaseValueOfCounter);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCounters(IRepository repo)
    {
        return TypedResults.Ok(repo.GetCounters());
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCounter(IRepository repo, int id)
    {
        return TypedResults.Ok(repo.GetCounter(id));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCountersGreaterThan(IRepository repo, int value)
    {
        return TypedResults.Ok(repo.GetCountersGreaterThan(value));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCountersLessThan(IRepository repo, int value)
    {
        return TypedResults.Ok(repo.GetCountersLessThan(value));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> IncreaseValueOfCounter(IRepository repo, int id)
    {
        return TypedResults.Ok(repo.IncreaseValueOfCounter(id));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> DecreaseValueOfCounter(IRepository repo, int id)
    {
        return TypedResults.Ok(repo.DecreaseValueOfCounter(id));
    }
    

}
