using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002.N001
{
    /// <inheritdoc cref="N001.IHandlerSuiteOperator" path="/summary"/>
    /// <remarks>
    /// Provides the <see cref="HandlerSuites_ByHandledImplementationType"/> property to methods inherited from <see cref="N001.IHandlerSuiteOperator"/>.
    /// </remarks>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        IHandlerSuiteOperator _HandlerSuiteOperator => HandlerSuiteOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IDictionary<Type, THandlerSuite> HandlerSuites_ByHandledImplementationType { get; }


        bool Can_Handle(
            THandled value,
            out THandlerSuite handlerSuite_OrDefault,
            out Type implementationType)
            => this.Can_Handle(
                value,
                this.HandlerSuites_ByHandledImplementationType,
                out handlerSuite_OrDefault,
                out implementationType);

        bool Can_Handle(
            THandled instance,
            out THandlerSuite handlerSuite_OrDefault)
            => this.Can_Handle(
                instance,
                this.HandlerSuites_ByHandledImplementationType,
                out handlerSuite_OrDefault);

        bool Can_Handle(THandled instance)
            => this.Can_Handle(
                instance,
                this.HandlerSuites_ByHandledImplementationType);

        IEnumerable<For_Results.N005.IResult<THandled, THandlerSuite>> Can_Handle(IEnumerable<THandled> instances)
            => this.Can_Handle(
                instances,
                this.HandlerSuites_ByHandledImplementationType);

        THandlerSuite Verify_CanHandle(THandled value)
            => this.Verify_CanHandle(
                value,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
