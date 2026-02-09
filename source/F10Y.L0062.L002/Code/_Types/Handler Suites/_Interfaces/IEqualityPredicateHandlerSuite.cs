using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    [DataTypeMarker]
    public interface IEqualityPredicateHandlerSuite<THandled>
    {
        Func<THandled, THandled, bool> Equality_Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    [DataTypeMarker]
    public interface IEqualityPredicateHandlerSuite<THandled>
    {
        Func<THandled, THandled, Task<bool>> Equality_Predicate { get; set; }
    }
}
