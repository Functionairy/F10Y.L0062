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
        int Get_HashCode(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByType);

            var output = handler.Get_HashCode(handled);
            return output;
        }
    }
}
