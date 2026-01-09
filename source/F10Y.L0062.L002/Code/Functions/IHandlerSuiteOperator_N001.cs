using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    /// <summary>
    /// Contains functions for working with dictionaries typed by type.
    /// (Useful for per-type lookups.)
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator
    {
        bool Can_Handle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType,
            out THandlerSuite handlerSuite_OrDefault,
            out Type implementationType)
        {
            implementationType = Instances.TypeOperator.Get_Type_ImplementationType(handled);

            var output = handlerSuites_ByHandledImplementationType.ContainsKey(implementationType);

            handlerSuite_OrDefault = output
                ? handlerSuites_ByHandledImplementationType[implementationType]
                : default
                ;

            return output;
        }

        bool Can_Handle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType,
            out THandlerSuite handlerSuite_OrDefault)
        {
            var output = this.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out handlerSuite_OrDefault,
                out _);

            return output;
        }

        bool Can_Handle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var output = this.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out _);

            return output;
        }

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

        Dictionary<Type, THandlerSuite> Get_HandlerSuites_ByType<THandled, THandlerSuite>(IEnumerable<THandlerSuite> descriptorOperationHandlerSets)
            where THandlerSuite : IHas_Type
        {
            var output = descriptorOperationHandlerSets
                .ToDictionary(
                    x => x.Type);

            return output;
        }

        Dictionary<Type, THandlerSuite> Get_HandlerSuites_ByType<THandled, THandlerSuite>(params THandlerSuite[] descriptorOperationHandlerSets)
            where THandlerSuite : IHas_Type
        {
            var output = this.Get_HandlerSuites_ByType<THandled, THandlerSuite>(descriptorOperationHandlerSets.AsEnumerable());
            return output;
        }

        THandlerSuite Verify_CanHandle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var can_Handle = this.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out var handlerSuite);

            if (!can_Handle)
            {
                throw Instances.ExceptionOperator.Get_NoHandlerSuiteFoundForDescriptorTypeException(handled);
            }

            return handlerSuite;
        }
    }
}
