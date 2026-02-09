using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.Synchronous
{
    [FunctionsMarker]
    public partial interface IBinaryPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite> :
        L002.N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IBinaryPredicateProviderHandlerSuiteOperator<THandled, TValue, THandlerSuite>
        where THandlerSuite : IBinaryPredicateProviderHandlerSuite<THandled, TValue>
    {
        bool Are_Equal(
            THandled handled,
            TValue a,
            TValue b)
        {
            var predicate = this.Get_Predicate(handled);

            var output = predicate(a, b);
            return output;
        }

        Func<TValue, TValue, bool> Get_Predicate(THandled handled)
            => this.Get_Predicate(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        bool Has_Predicate(
           THandled handled,
           out Func<TValue, TValue, bool> predicate_OrDefault)
            => this.Has_Predicate(
                handled,
                out predicate_OrDefault,
                this.HandlerSuites_ByHandledImplementationType);

        For_Results.N004.Result<Func<TValue, TValue, bool>> Has_Predicate(THandled handled)
            => this.Has_Predicate(
                handled,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
