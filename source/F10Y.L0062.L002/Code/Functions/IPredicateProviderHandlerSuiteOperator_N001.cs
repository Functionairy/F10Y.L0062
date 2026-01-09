using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous.N001
{
    [FunctionsMarker]
    public partial interface IPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator
        where THandlerSuite : L002.Synchronous.IPredicateProviderHandlerSuite<THandled, TValue>
    {
        bool Evaluate(
            THandled handled,
            TValue value,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Predicate(
                handled,
                value);

            return output;
        }

        Func<TValue, bool> Get_Predicate(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
            => value => this.Evaluate(
                handled,
                value,
                handlerSuites_ByHandledImplementationType);
    }
}
