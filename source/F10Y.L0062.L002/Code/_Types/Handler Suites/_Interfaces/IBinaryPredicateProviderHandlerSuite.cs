using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    [DataTypeMarker]
    public interface IBinaryPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<THandled, Func<TValue, TValue, bool>> Get_Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    [DataTypeMarker]
    public interface IBinaryPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<THandled, Func<TValue, TValue, Task<bool>>> Get_Predicate { get; set; }
    }
}