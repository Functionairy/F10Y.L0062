using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    [FunctionsMarker]
    public partial interface IHashCodeProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator
        where THandlerSuite : IHashCodeProviderHandlerSuite<THandled>
    {
        /// <summary>
        /// Determine if the two handled instance are equal.
        /// </summary>
        /// <remarks>
        /// By default, allow handling null values.
        /// To allow null values see <see cref="Get_HashCode(THandled, IDictionary{Type, THandlerSuite})"/>.
        /// </remarks>
        int Get_HashCode_DisallowNull(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByType);

            var output = handler.Get_HashCode(handled);
            return output;
        }

        /// <summary>
        /// Get the hash code of the handled instance.
        /// </summary>
        /// <remarks>
        /// By default, nulls are allowed.
        /// To disallow nulls, see <see cref="Get_HashCode_DisallowNull(THandled, IDictionary{Type, THandlerSuite})"/>.
        /// </remarks>
        int Get_HashCode(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var is_Null = Instances.NullOperator.Is_Null(handled);

            if(is_Null)
            {
                return Instances.HashCodes.For_Null;
            }

            // Else
            var output = this.Get_HashCode_DisallowNull(
                handled,
                handlerSuites_ByType);

            return output;
        }
    }
}
