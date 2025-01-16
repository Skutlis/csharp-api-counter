using System;
using api_counter.wwwapi9.Data;
using api_counter.wwwapi9.Models;

namespace api_counter.wwwapi9.Repository;

public class Repository : IRepository
{
    public Counter DecreaseValueOfCounter(int id)
    {
        CounterHelper.Counters.ForEach(c => {if (c.Id == id) c.Value -= 1;});
        return CounterHelper.Counters.FirstOrDefault(c => c.Id == id) ?? new Counter();
    }

    public Counter GetCounter(int id)
    {
        return CounterHelper.Counters.FirstOrDefault(c => c.Id == id) ?? new Counter();
    }

    public IEnumerable<Counter> GetCounters()
    {
        return CounterHelper.Counters;
    }

    public IEnumerable<Counter> GetCountersGreaterThan(int value)
    {
        return CounterHelper.Counters.Where(c => c.Value > value);
    }

    public IEnumerable<Counter> GetCountersLessThan(int value)
    {
        return CounterHelper.Counters.Where(c => c.Value < value);
    }

    public Counter IncreaseValueOfCounter(int id)
    {
        CounterHelper.Counters.ForEach(c => {if (c.Id == id) c.Value += 1;});
        return CounterHelper.Counters.FirstOrDefault(c => c.Id == id) ?? new Counter();
    }
}
