using System;
using System.Diagnostics.Metrics;
using api_counter.wwwapi9.Models;

namespace api_counter.wwwapi9.Repository;

public interface IRepository
{

    IEnumerable<Counter> GetCounters();
    Counter GetCounter(int id);
    IEnumerable<Counter> GetCountersGreaterThan(int value);
    IEnumerable<Counter> GetCountersLessThan(int value);
    Counter IncreaseValueOfCounter(int id);
    Counter DecreaseValueOfCounter(int id);

}
