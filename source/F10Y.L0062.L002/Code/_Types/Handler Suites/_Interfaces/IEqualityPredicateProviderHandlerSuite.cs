using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    [DataTypeMarker]
    public interface IEqualityPredicateProviderHandlerSuite<THandled>
    {
        Func<THandled, THandled, bool> EqualityPredicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    [DataTypeMarker]
    public interface IEqualityPredicateProviderHandlerSuite<THandled>
    {
        Func<THandled, THandled, Task<bool>> EqualityPredicate { get; set; }
    }
}
