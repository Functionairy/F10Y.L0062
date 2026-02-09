using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderSuite<THandled> :
        IPredicateHandlerSuite<THandled>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, bool> Predicate { get; set; }
    }


    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderSuite<THandled, TValue> :
        IPredicateHandlerSuite<THandled, TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, TValue, bool> Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderSuite<THandled> :
        IPredicateHandlerSuite<THandled>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Task<bool>> Predicate { get; set; }
    }


    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderSuite<THandled, TValue> :
        IPredicateHandlerSuite<THandled, TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, TValue, Task<bool>> Predicate { get; set; }
    }
}