using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous.N001
{
    [FunctionsMarker]
    public partial interface IEqualityPredicateProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator
        where THandlerSuite : L002.Synchronous.IEqualityPredicateProviderHandlerSuite<THandled>
    {
        bool Are_Equal(
            THandled a,
            THandled b,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                a,
                handlerSuites_ByHandledImplementationType);

            var output = handler.EqualityPredicate(a, b);
            return output;
        }
    }
}
