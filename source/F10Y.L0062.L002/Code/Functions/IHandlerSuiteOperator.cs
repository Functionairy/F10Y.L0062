using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    public partial interface IHandlerSuiteOperator :
        N003.IHandlerSuiteOperator
    {

    }


    /// <summary>
    /// 
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IHandlerSuiteOperator<THandled, TValue, THandlerSuite>
        where THandlerSuite : IHandlerSuite<TValue>
    {
        TValue Get_Value(THandled handled)
            => this.Get_Value(
                handled,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
