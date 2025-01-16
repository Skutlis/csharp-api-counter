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
        return TypedResults.Ok(repo.GetCounters);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCounter(IRepository repo)
    {
        return TypedResults.Ok(repo.GetCounter);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCountersGreaterThan(IRepository repo)
    {
        return TypedResults.Ok(repo.GetCountersGreaterThan);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCountersLessThan(IRepository repo)
    {
        return TypedResults.Ok(repo.GetCountersLessThan);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> IncreaseValueOfCounter(IRepository repo)
    {
        return TypedResults.Ok(repo.IncreaseValueOfCounter);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> DecreaseValueOfCounter(IRepository repo)
    {
        return TypedResults.Ok(repo.DecreaseValueOfCounter);
    }
    

}
