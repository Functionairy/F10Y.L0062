using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderHandlerSuite<THandled> :
        IPredicateProviderHandlerSuite<THandled>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Func<THandled, bool>> Get_Predicate { get; set; }
    }


    /// <summary>
    /// Provides a predicate for a type based on a different type (multiple types).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderHandlerSuite<THandled, TValue> :
        IPredicateProviderHandlerSuite<THandled, TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Func<TValue, bool>> Get_Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderHandlerSuite<THandled> :
        IPredicateProviderHandlerSuite<THandled>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Func<THandled, Task<bool>>> Get_Predicate { get; set; }
    }


    /// <summary>
    /// Provides a predicate for a type based on a different type (multiple types).
    /// </summary>
    [UtilityTypeMarker]
    public class PredicateProviderHandlerSuite<THandled, TValue> :
        IPredicateProviderHandlerSuite<THandled, TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, Func<TValue, Task<bool>>> Get_Predicate { get; set; }
    }
}