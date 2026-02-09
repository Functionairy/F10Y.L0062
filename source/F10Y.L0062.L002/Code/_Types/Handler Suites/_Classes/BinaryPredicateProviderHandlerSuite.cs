using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class BinaryPredicateProviderHandlerSuite<THandled, TValue> :
        IBinaryPredicateProviderHandlerSuite<THandled, TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Func<TValue, TValue, bool>> Get_Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class BinaryPredicateProviderHandlerSuite<THandled, TValue> :
        IBinaryPredicateProviderHandlerSuite<THandled, TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Func<TValue, TValue, Task<bool>>> Get_Predicate { get; set; }
    }
}