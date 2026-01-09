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
        int Get_HashCode(THandled handled)
            => this.Get_HashCode(
                handled,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
