using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous.N001
{
    [FunctionsMarker]
    public partial interface IEqualityPredicateHandlerSuiteOperator<THandled, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator
        where THandlerSuite : L002.Synchronous.IEqualityPredicateHandlerSuite<THandled>
    {
        /// <inheritdoc cref="Are_Equal(THandled, THandled, IDictionary{Type, THandlerSuite})" path="/summary"/>
        /// <remarks>
        /// Disallow null values.
        /// </remarks>
        bool Are_Equal_DisallowNull(
            THandled a,
            THandled b,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                a,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Equality_Predicate(a, b);
            return output;
        }

        /// <summary>
        /// Determine if the two handled instance are equal.
        /// </summary>
        /// <remarks>
        /// By default, allow handling null values.
        /// To disallow null values, see <see cref="Are_Equal_DisallowNull(THandled, THandled, IDictionary{Type, THandlerSuite})"/>.
        /// </remarks>
        bool Are_Equal(
            THandled a,
            THandled b,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var output = Instances.NullOperator.NullCheckDeterminesEquality_Else_AllowValueTypes(
                a,
                b,
                (x, y) => this.Are_Equal_DisallowNull(
                    x, y,
                    handlerSuites_ByHandledImplementationType));

            return output;
        }
    }
}
