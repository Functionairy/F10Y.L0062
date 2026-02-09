using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    /// <summary>
    /// Contains functions for working with dictionaries of handler suites keyed by the type they handle.
    /// (Useful for per-type lookups.)
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator :
        L0005.L003.TypeBased.IHandlerSuiteOperator
    {
        IEnumerable<For_Results.N005.IResult<THandled, THandlerSuite>> Can_Handle<THandled, THandlerSuite>(
            IEnumerable<THandled> handleds,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var output = handleds
                .Select(instance =>
                {
                    var can_Handle = this.Can_Handle(
                        instance,
                        handlerSuites_ByHandledImplementationType,
                        out var handlerSet_OrDefault);

                    var output = new For_Results.N005.Result<THandled, THandlerSuite>
                    {
                        Success = can_Handle,
                        Input = instance,
                        Output = handlerSet_OrDefault
                    };

                    return output;
                })
                ;

            return output;
        }
    }
}
