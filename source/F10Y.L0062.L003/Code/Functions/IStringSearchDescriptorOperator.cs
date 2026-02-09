using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IStringSearchDescriptorOperator :
        L002.IDescriptorHandlerSuiteOperator<IStringSearchDescriptor, StringSearchDescriptorHandlerSuite>,
        L002.Synchronous.IPredicateProviderHandlerSuiteOperator<IStringSearchDescriptor, string, StringSearchDescriptorHandlerSuite>
    {
        IDictionary<Type, StringSearchDescriptorHandlerSuite> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<IStringSearchDescriptor, StringSearchDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_StringSearchDescriptors_ByType;

        IDictionary<string, StringSearchDescriptorHandlerSuite> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<StringSearchDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_StringSearchDescriptors_ByTypeName;


        StringSearchDescriptor_Equals_Simple From_ToEquals_Simple(string value)
        {
            var output = new StringSearchDescriptor_Equals_Simple
            {
                Value = value
            };

            return output;
        }

        StringSearchDescriptor_EqualityOperationDescriptor From(
            string value,
            For_EqualityOperationDescriptor.IEqualityOperationDescriptor equalityOperationDescriptor)
        {
            var output = new StringSearchDescriptor_EqualityOperationDescriptor
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Value = value
            };

            return output;
        }
    }
}
