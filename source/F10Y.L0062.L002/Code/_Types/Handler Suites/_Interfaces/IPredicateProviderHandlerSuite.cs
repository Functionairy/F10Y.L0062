using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002.Synchronous
{
    /// <summary>
    /// Not sure why you would want this instead of <see cref="IPredicateHandlerSuite{THandled}"/>, but ok!
    /// </summary>
    [DataTypeMarker]
    public interface IPredicateProviderHandlerSuite<THandled>
    {
        Func<THandled, Func<THandled, bool>> Get_Predicate { get; set; }
    }

    [DataTypeMarker]
    public interface IPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<THandled, Func<TValue, bool>> Get_Predicate { get; set; }
    }
}


namespace F10Y.L0062.L002.Asynchronous
{
    /// <summary>
    /// Not sure why you would want this instead of <see cref="IPredicateHandlerSuite{THandled}"/>, but ok!
    /// </summary>
    [DataTypeMarker]
    public interface IPredicateProviderHandlerSuite<THandled>
    {
        Func<THandled, Func<THandled, Task<bool>>> Get_Predicate { get; set; }
    }

    [DataTypeMarker]
    public interface IPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<THandled, Func<TValue, Task<bool>>> Get_Predicate { get; set; }
    }
}