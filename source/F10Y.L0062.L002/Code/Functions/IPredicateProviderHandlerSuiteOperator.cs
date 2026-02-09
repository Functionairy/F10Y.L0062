using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous
{
    [FunctionsMarker]
    public partial interface IPredicateProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IPredicateProviderHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : IPredicateProviderHandlerSuite<THandled>
    {
        Func<THandled, bool> Get_Predicate(THandled handled)
            => this.Get_Predicate(
                handled,
                this.HandlerSuites_ByHandledImplementationType);
    }


    [FunctionsMarker]
    public partial interface IPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite>
        where THandlerSuite : IPredicateProviderHandlerSuite<THandled, TValue>
    {
        Func<TValue, bool> Get_Predicate(THandled handled)
            => this.Get_Predicate(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        bool Has_Predicate_Synchronous(
            THandled descriptor,
            out Func<TValue, bool> predicate_OrDefault)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                predicate_OrDefault = default;

                return false;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType,
                out var handlerSuite_OrDefault);

            predicate_OrDefault = can_Handle
                ? handlerSuite_OrDefault.Get_Predicate(descriptor)
                : default
                ;

            return can_Handle;
        }

        For_Results.N004.Result<Func<TValue, bool>> Has_Predicate_Synchronous(THandled descriptor)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                descriptor,
                out var predicate_OrDefault);

            var output = new For_Results.N004.Result<Func<TValue, bool>>
            {
                Success = has_Predicate,
                Value = predicate_OrDefault
            };

            return output;
        }
    }
}
