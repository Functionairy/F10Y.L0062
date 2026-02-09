using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IHashCodeProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IHashCodeProviderHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : IHashCodeProviderHandlerSuite<THandled>
    {
        /// <inheritdoc cref="Get_HashCode(THandled)" path="/summary"/>
        /// <remarks>
        /// Nulls are disallowed.
        /// To allow null values see <see cref="Get_HashCode(THandled)"/>.
        /// </remarks>
        int Get_HashCode_DisallowNull(THandled handled)
            => this.Get_HashCode_DisallowNull(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        /// <summary>
        /// Get the hash code of the handled instance.
        /// </summary>
        /// <remarks>
        /// By default, nulls are allowed.
        /// To disallow nulls, see <see cref="Get_HashCode_DisallowNull(THandled)"/>.
        /// </remarks>
        int Get_HashCode(THandled handled)
            => this.Get_HashCode(
                handled,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
