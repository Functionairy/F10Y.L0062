using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IExceptionMessageOperator
    {
        public string Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(string implementationType_TypeName)
        {
            var message = $"No handler suite found for descriptor type '{implementationType_TypeName}'";
            return message;
        }

        public string Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage<TDescriptor>(TDescriptor descriptor)
        {
            var implementationType_TypeName = Instances.TypeOperator.Get_TypeName_OfImplementationType(descriptor);

            var output = this.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(implementationType_TypeName);
            return output;
        }

        /// <summary>
        /// <para><value>No predicate provider found for descriptor.</value></para>
        /// </summary>
        public string Get_NoPredicateProviderFound_ForDescriptorExceptionMessage<TDescriptor>(TDescriptor descriptor)
        {
            var typeName = Instances.TypeOperator.Get_TypeName(descriptor);

            var output = $"No predicate provider found for descriptor type '{typeName}'.";
            return output;
        }
    }
}
