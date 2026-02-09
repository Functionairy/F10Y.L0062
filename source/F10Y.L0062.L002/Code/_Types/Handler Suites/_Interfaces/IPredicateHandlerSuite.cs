using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    [DataTypeMarker]
    public interface IPredicateHandlerSuite<THandled>
    {
        Func<THandled, bool> Predicate { get; set; }
    }

    [DataTypeMarker]
    public interface IPredicateHandlerSuite<THandled, TValue>
    {
        Func<THandled, TValue, bool> Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    [DataTypeMarker]
    public interface IPredicateHandlerSuite<THandled>
    {
        Func<THandled, Task<bool>> Predicate { get; set; }
    }

    [DataTypeMarker]
    public interface IPredicateHandlerSuite<THandled, TValue>
    {
        Func<THandled, TValue, Task<bool>> Predicate { get; set; }
    }
}