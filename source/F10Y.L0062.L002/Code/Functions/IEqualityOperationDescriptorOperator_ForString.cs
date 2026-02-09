using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorOperator_ForString :
        IEqualityOperationDescriptorOperator<string>
    {
        IDictionary<Type, EqualityOperationDescriptorHandlerSuite<string>> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<IEqualityOperationDescriptor, EqualityOperationDescriptorHandlerSuite<string>>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_EqualityOperationDescriptors_OfString_ByType;

        IDictionary<string, EqualityOperationDescriptorHandlerSuite<string>> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<EqualityOperationDescriptorHandlerSuite<string>>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_EqualityOperationDescriptors_OfString_ByTypeName;
    }
}
