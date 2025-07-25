using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator
    {
        public bool Can_Handle<T, THandlerSuite>(
            T instance,
            Dictionary<Type, THandlerSuite> handlerSuites_ByType,
            out THandlerSuite handlerSuite_OrDefault,
            out Type implementationType)
        {
            implementationType = Instances.TypeOperator.Get_Type_ImplementationType(instance);

            var output = handlerSuites_ByType.ContainsKey(implementationType);

            handlerSuite_OrDefault = output
                ? handlerSuites_ByType[implementationType]
                : default
                ;

            return output;
        }

        public bool Can_Handle<T, THandlerSuite>(
            T instance,
            Dictionary<Type, THandlerSuite> handlerSuites_ByType,
            out THandlerSuite handlerSuite_OrDefault)
        {
            var output = this.Can_Handle(
                instance,
                handlerSuites_ByType,
                out handlerSuite_OrDefault,
                out _);

            return output;
        }

        public bool Can_Handle<T, THandlerSuite>(
            T instance,
            Dictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var output = this.Can_Handle(
                instance,
                handlerSuites_ByType,
                out _);

            return output;
        }

        public bool Can_Handle<THandlerSuite>(
            string typeName,
            Dictionary<string, THandlerSuite> handlerSuites_ByTypeName,
            out THandlerSuite handlerSuite_OrDefault)
        {
            var output = handlerSuites_ByTypeName.ContainsKey(typeName);

            handlerSuite_OrDefault = output
                ? handlerSuites_ByTypeName[typeName]
                : default
                ;

            return output;
        }

        public IEnumerable<For_Results.N005.IResult<T, THandlerSuite>> Can_Handle<T, THandlerSuite>(
            IEnumerable<T> instances,
            Dictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var output = instances
                .Select(instance =>
                {
                    var can_Handle = this.Can_Handle(
                        instance,
                        handlerSuites_ByType,
                        out var handlerSet_OrDefault);

                    var output = new For_Results.N005.Result<T, THandlerSuite>
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

        public Dictionary<Type, THandlerSuite> Get_HandlerSuites_ByType<T, THandlerSuite>(IEnumerable<THandlerSuite> descriptorOperationHandlerSets)
            where THandlerSuite : IHas_Type
        {
            var output = descriptorOperationHandlerSets
                .ToDictionary(
                    x => x.Type);

            return output;
        }

        public Dictionary<Type, THandlerSuite> Get_HandlerSuites_ByType<T, THandlerSuite>(params THandlerSuite[] descriptorOperationHandlerSets)
            where THandlerSuite : IHas_Type
        {
            var output = this.Get_HandlerSuites_ByType<T, THandlerSuite>(descriptorOperationHandlerSets.AsEnumerable());
            return output;
        }

        public THandlerSuite Verify_CanHandle<T, THandlerSuite>(
            T descriptor,
            Dictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var can_Handle = this.Can_Handle(
                descriptor,
                handlerSuites_ByType,
                out var handlerSuite);

            if (!can_Handle)
            {
                throw Instances.ExceptionOperator.Get_NoHandlerSuiteFoundForDescriptorTypeException(descriptor);
            }

            return handlerSuite;
        }

        public THandlerSuite Verify_CanHandle<THandlerSuite>(
            string descriptorTypeName,
            Dictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var can_Handle = this.Can_Handle(
                descriptorTypeName,
                handlerSuites_ByTypeName,
                out var handlerSuite);

            if (!can_Handle)
            {
                throw Instances.ExceptionOperator.Get_NoHandlerSuiteFoundForDescriptorTypeException(descriptorTypeName);
            }

            return handlerSuite;
        }
    }
}
