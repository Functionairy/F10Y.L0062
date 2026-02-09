using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    /// <inheritdoc cref="N001.IHandlerSuiteOperator" path="/summary"/>
    /// <remarks>
    /// Provides the the value of the <see cref="L0005.L003.TypeBased.IHandlerSuiteOperator{THandled, THandlerSuite}.HandlerSuites_ByHandledImplementationType"/> property to methods inherited from <see cref="N001.IHandlerSuiteOperator"/>.
    /// </remarks>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        L0005.L003.TypeBased.IHandlerSuiteOperator<THandled, THandlerSuite>,
        IHandlerSuiteOperator
    {
        IEnumerable<For_Results.N005.IResult<THandled, THandlerSuite>> Can_Handle(IEnumerable<THandled> instances)
            => this.Can_Handle(
                instances,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
