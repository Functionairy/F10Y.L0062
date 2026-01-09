using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous
{
    [FunctionsMarker]
    public partial interface IEqualityPredicateProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator<THandled, THandlerSuite>,
        Synchronous.N001.IEqualityPredicateProviderHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : Synchronous.IEqualityPredicateProviderHandlerSuite<THandled>
    {
        bool Are_Equal(
            THandled a,
            THandled b)
            => this.Are_Equal(
                a,
                b,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
