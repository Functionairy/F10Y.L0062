using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    /// <summary>
    /// 
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        N001.IHandlerSuiteOperator
        where THandlerSuite : IHandlerSuite<TValue>
    {
        TValue Get_Value(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Value;
            return output;
        }
    }
}
