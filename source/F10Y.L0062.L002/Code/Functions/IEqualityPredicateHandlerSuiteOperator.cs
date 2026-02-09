using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous
{
    [FunctionsMarker]
    public partial interface IEqualityPredicateHandlerSuiteOperator<THandled, THandlerSuite> :
        N003.IHandlerSuiteOperator<THandled, THandlerSuite>,
        Synchronous.N001.IEqualityPredicateHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : Synchronous.IEqualityPredicateHandlerSuite<THandled>
    {
        /// <inheritdoc cref="Are_Equal(THandled, THandled)" path="/summary"/>
        /// <remarks>
        /// Disallow null values.
        /// </remarks>
        bool Are_Equal_DisallowNull(
            THandled a,
            THandled b)
            => this.Are_Equal_DisallowNull(
                a,
                b,
                this.HandlerSuites_ByHandledImplementationType);

        /// <summary>
        /// Determine if the two handled instance are equal.
        /// </summary>
        /// <remarks>
        /// By default, allow handling null values.
        /// To disallow null values, see <see cref="Are_Equal_DisallowNull(THandled, THandled)"/>.
        /// </remarks>
        bool Are_Equal(
            THandled a,
            THandled b)
            => this.Are_Equal(
                a,
                b,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
