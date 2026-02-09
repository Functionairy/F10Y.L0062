using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous.N001
{
    [FunctionsMarker]
    public partial interface IBinaryPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator
        where THandlerSuite : IBinaryPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<TValue, TValue, bool> Get_Predicate(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Get_Predicate(handled);
            return output;
        }

        bool Has_Predicate(
            THandled handled,
            out Func<TValue, TValue, bool> predicate_OrDefault,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var isNull = Instances.NullOperator.Is_Null(handled);
            if (isNull)
            {
                predicate_OrDefault = default;

                return false;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out var handlerSuite_OrDefault);

            predicate_OrDefault = can_Handle
                ? handlerSuite_OrDefault.Get_Predicate(handled)
                : default
                ;

            return can_Handle;
        }

        For_Results.N004.Result<Func<TValue, TValue, bool>> Has_Predicate(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var has_Predicate = this.Has_Predicate(
                handled,
                out var predicate_OrDefault,
                handlerSuites_ByHandledImplementationType);

            var output = new For_Results.N004.Result<Func<TValue, TValue, bool>>
            {
                Success = has_Predicate,
                Value = predicate_OrDefault
            };

            return output;
        }
    }
}
