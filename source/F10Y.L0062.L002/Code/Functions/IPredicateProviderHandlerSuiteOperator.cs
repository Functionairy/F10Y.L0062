using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous
{
    [FunctionsMarker]
    public partial interface IPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        IHandlerSuiteOperator<THandled, THandlerSuite>,
        Synchronous.N001.IPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite>
        where THandlerSuite : Synchronous.IPredicateProviderHandlerSuite<THandled, TValue>
    {
        bool Evaluate(
            THandled handled,
            TValue value)
            => this.Evaluate(
                handled,
                value,
                this.HandlerSuites_ByHandledImplementationType);

        Func<TValue, bool> Get_Predicate(THandled handled)
            => this.Get_Predicate(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        Func<TValue, bool> Get_Predicate(
            THandled handled,
            THandlerSuite handlerSuite)
            => value => handlerSuite.Predicate(
                handled,
                value);

        bool Has_Predicate_Synchronous(
            THandled handled,
            out Func<TValue, bool> predicate_OrDefault)
        {
            var isNull = Instances.NullOperator.Is_Null(handled);
            if (isNull)
            {
                predicate_OrDefault = default;

                return false;
            }

            var can_Handle = this.Can_Handle(
                handled,
                out var handlerSuite_OrDefault);

            predicate_OrDefault = can_Handle
                ? this.Get_Predicate(
                    handled,
                    handlerSuite_OrDefault)
                : default
                ;

            return can_Handle;
        }

        For_Results.N004.Result<Func<TValue, bool>> Has_Predicate_Synchronous(THandled handled)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                handled,
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
