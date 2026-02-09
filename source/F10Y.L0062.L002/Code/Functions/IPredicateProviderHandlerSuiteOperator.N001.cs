using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous.N001
{
    /// <inheritdoc cref="IPredicateProviderHandlerSuite{THandled}"/>
    [FunctionsMarker]
    public partial interface IPredicateProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator
        where THandlerSuite : IPredicateProviderHandlerSuite<THandled>
    {
        Func<THandled, bool> Get_Predicate(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Get_Predicate(handled);
            return output;
        }
    }


    /// <inheritdoc cref="IPredicateProviderHandlerSuite{THandled, TValue}"/>
    [FunctionsMarker]
    public partial interface IPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator
        where THandlerSuite : IPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<TValue, bool> Get_Predicate(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Get_Predicate(handled);
            return output;
        }
    }
}